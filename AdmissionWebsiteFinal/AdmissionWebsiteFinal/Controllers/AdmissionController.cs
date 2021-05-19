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
            var departments = unitOfWork.Specializations.GetAll();
            var model = mapper.Map<List<SpecializationViewModel>>(departments);

            return View(model);
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
                var entryOptions = mapper.Map<IEnumerable<EntryOptionViewModel>>(unitOfWork.Options.GetOptionsBySessionId(session.Id));
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

        [HttpPost]
        public ActionResult RegisterContestant(AdmissionEntryViewModel model,int[] entryOptionId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(GetAdmissionEntryViewModel());
                }

                var employee = userManager.GetUserAsync(User).Result;
                var contestant = mapper.Map<Contestant>(model.Contestant);
                unitOfWork.Contestants.Add(contestant);

                var admissionEntry = new AdmissionEntry
                {
                    ContestantId = contestant.ContestantId,
                    EntryScore = model.EntryScore,
                    EmployeeId = employee.Id,
                    DateCreated = DateTime.Now
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
