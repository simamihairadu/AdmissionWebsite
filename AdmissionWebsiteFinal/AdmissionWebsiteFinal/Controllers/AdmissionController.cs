using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using AdmissionWebsiteFinal.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Controllers
{
    [Authorize]
    public class AdmissionController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<IdentityUser> userManager;
        public AdmissionController(IMapper mapper, IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        public ActionResult Index()
        {
            if (unitOfWork.Sessions.IsAnyActive())
            {
                var admissionEntries = unitOfWork.AdmissionEntries.GetAdmissionEntriesBySessionId(unitOfWork.Sessions.GetActiveSession().Id);
                var admissionEntryViewModels = mapper.Map<List<AdmissionEntryViewModel>>(admissionEntries);
                return View(admissionEntryViewModels);
            }

            return View("RegisterError");
        }

        public ActionResult EntryDetails(int id)
        {
            var admissionEntryViewModel = mapper.Map<AdmissionEntryViewModel>(unitOfWork.AdmissionEntries.Get(id));
            var entryOptions = unitOfWork.EntryOptions.GetEntryOptionsByEntryId(admissionEntryViewModel.Id);
            List<Option> options = new List<Option>();

            foreach (var entryOption in entryOptions)
            {
                options.Add(entryOption.Option);
            }
            var mappedOptions = mapper.Map<List<OptionViewModel>>(options);
            admissionEntryViewModel.Options = mappedOptions;

            return View(admissionEntryViewModel);
        }
        private void CreateContestantAccount(Contestant contestant)
        {
            //string password = contestant.FirstName + contestant.ContestantId.TakeLast(6);
            string password = "Parola123!";
            var user = new ContestantAccount
            {
                UserName = contestant.Email,
                Email = contestant.Email,
                ContestantId = contestant.ContestantId,
                EmailConfirmed = true
            };
            var result = userManager.CreateAsync(user, password).Result;
            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user, "ContestantAccount").Wait();
            }
        }
        public ActionResult RegisterContestant()
        {
            var admissionEntryViewModel = GetAdmissionEntryViewModel();
            if (admissionEntryViewModel != null)
            {
                return View(admissionEntryViewModel);
            }
            return View("RegisterError");
        }

        private AdmissionEntryViewModel GetAdmissionEntryViewModel()
        {
            if (unitOfWork.Sessions.IsAnyActive())
            {
                var session = unitOfWork.Sessions.GetActiveSession();
                var entryOptions = mapper.Map<List<EntryOptionViewModel>>(unitOfWork.Options.GetOptionsBySessionId(session.Id));
                foreach (var option in entryOptions)
                {
                    option.Name = unitOfWork.Specializations.GetNameById(option.SpecializationId);
                }
                var admissionEntryViewModel = new AdmissionEntryViewModel
                {
                    EntryOptions = entryOptions
                };
                return admissionEntryViewModel;
            }
            return null;
        }
        public ActionResult RegisterExisting()
        {
            var admissionEntryViewModel = GetAdmissionEntryViewModel();
            if (admissionEntryViewModel != null)
            {
                var existingContestantViewModel = new ExistingContestantViewModel
                {
                    EntryOptions = admissionEntryViewModel.EntryOptions
                };
                return View(existingContestantViewModel);
            }
            return View("RegisterError");
        }

        [HttpPost]
        public ActionResult RegisterExisting(ExistingContestantViewModel model,int[] entryOptionId)
        {
            try
            {
                var contestant = unitOfWork.Contestants.Get(model.ContestantId);
                if (contestant == null)
                {
                    ModelState.AddModelError("ContestantId", "CNP dosen't exist.");
                }
                if (!ModelState.IsValid)
                {
                    return View(GetAdmissionEntryViewModel());
                }

                var employee = userManager.GetUserAsync(User).Result;
                var admissionEntry = new AdmissionEntry
                {
                    ContestantId = contestant.ContestantId,
                    EntryScore = model.EntryScore,
                    EmployeeId = employee.Id,
                    DateCreated = DateTime.Now,
                    RromSpot = model.RromSpot,
                    RDPSpot = model.RDPSpot
                };
                unitOfWork.AdmissionEntries.Add(admissionEntry);
                unitOfWork.Complete();

                admissionEntry = unitOfWork.AdmissionEntries.GetAdmissionEntryByContestant(contestant.ContestantId);

                foreach (int id in entryOptionId)
                {
                    unitOfWork.EntryOptions.Add(new EntryOption
                    {
                        OptionId = id,
                        AdmissionEntryId = admissionEntry.Id
                    });
                }
                unitOfWork.Complete();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View(GetAdmissionEntryViewModel());
            }
        }
        [HttpPost]
        public ActionResult RegisterContestant(AdmissionEntryViewModel model,int[] entryOptionId)
        {
            try
            {
                if(unitOfWork.Contestants.Get(model.Contestant.Id) != null)
                {
                    ModelState.AddModelError("Contestant.Id", "CNP already exists. Use \"Add existing\" instead.");
                }
                if (!ModelState.IsValid)
                { 
                    return View(GetAdmissionEntryViewModel());
                }

                var employee = userManager.GetUserAsync(User).Result;
                var contestant = mapper.Map<Contestant>(model.Contestant);
                contestant.ContestantId = model.Contestant.Id;

                unitOfWork.Contestants.Add(contestant);

                var admissionEntry = new AdmissionEntry
                {
                    ContestantId = contestant.ContestantId,
                    EntryScore = model.EntryScore,
                    EmployeeId = employee.Id,
                    DateCreated = DateTime.Now,
                    RromSpot = model.RromSpot,
                    RDPSpot = model.RDPSpot
                };
                unitOfWork.AdmissionEntries.Add(admissionEntry);
                unitOfWork.Complete();

                admissionEntry = unitOfWork.AdmissionEntries.GetAdmissionEntryByContestant(contestant.ContestantId);

                foreach(int id in entryOptionId)
                {
                    unitOfWork.EntryOptions.Add(new EntryOption
                    {
                        OptionId = id,
                        AdmissionEntryId = admissionEntry.Id
                    });
                }
                unitOfWork.Complete();
                CreateContestantAccount(contestant);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View(GetAdmissionEntryViewModel());
            }
        }

        public ActionResult RegisterError()
        {
            return View();
        }
    }
}
