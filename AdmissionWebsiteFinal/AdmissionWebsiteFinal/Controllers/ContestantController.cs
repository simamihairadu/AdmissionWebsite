using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using AdmissionWebsiteFinal.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Controllers
{
    public class ContestantController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<IdentityUser> userManager;
        public ContestantController(IMapper mapper, IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var user = (ContestantAccount)userManager.GetUserAsync(User).Result;
            var contestant = mapper.Map<ContestantViewModel>(unitOfWork.Contestants.Get(user.ContestantId));
            var entry = mapper.Map<AdmissionEntryViewModel>(unitOfWork.AdmissionEntries.GetAdmissionEntryByContestant(user.ContestantId));

            var contestantAccount = new ContestantAccountViewModel
            {
                Contestant = contestant,
                Entry = entry
            };
            return View(contestantAccount);
        }

        public IActionResult ContestantEntryDetails(int id)
        {
            var admissionEntryViewModel = mapper.Map<AdmissionEntryViewModel>(unitOfWork.AdmissionEntries.Get(id));
            var entryOptions = unitOfWork.EntryOptions.GetEntryOptionsByEntryId(admissionEntryViewModel.Id);
            List<OptionViewModel> mappedOptions = new List<OptionViewModel>();
            foreach (var entryOption in entryOptions)
            {
                mappedOptions.Add(new OptionViewModel
                {
                    Id = entryOption.Id,
                    Specialization = mapper.Map<SpecializationViewModel>(entryOption.Option.Specialization),
                    Confirmed = entryOption.Confirmed
                });
            }
            var contestantAccountViewModel = new ContestantAccountViewModel
            {
                Entry = admissionEntryViewModel,
                EntryOptions = mappedOptions
            };

            return View(contestantAccountViewModel);
        }

        public IActionResult ConfirmOption(int id)
        {
            var entryOption = unitOfWork.EntryOptions.Get(id);
            entryOption.Confirmed = true;
            unitOfWork.EntryOptions.Update(entryOption);
            unitOfWork.Complete();
            return RedirectToAction(nameof(Index));
        }
    }
}
