using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using AdmissionWebsiteFinal.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Controllers
{
    public class StandingsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public StandingsController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        private List<AdmissionEntry> GetRromEntries(ref List<AdmissionEntry> entries,int spotNumber)
        {
            List<AdmissionEntry> rromEntries = entries.Where(e => e.RromSpot == true).
                OrderByDescending(e => e.EntryScore).
                Take(spotNumber).ToList();
            entries.RemoveAll(e => rromEntries.Contains(e));
            return rromEntries;
        }
        public IActionResult Index(StandingViewModel standingViewModel)
        {
            var option = unitOfWork.Options.Get(standingViewModel.OptionId);
            var session = mapper.Map<SessionViewModel>(unitOfWork.Sessions.GetActiveSession());
            var options = mapper.Map<IEnumerable<OptionViewModel>>(unitOfWork.Options.GetOptionsBySessionId(session.Id));

            var entries = unitOfWork.AdmissionEntries.GetAdmissionEntriesByOptionId(standingViewModel.OptionId).ToList();
            if(option != null)
            {
                List<AdmissionEntry> rromEntries = GetRromEntries(ref entries, option.LocuriRrom);
                List<AdmissionEntry> bugetEntries = entries.Take(option.LocuriBuget).ToList();
                List<AdmissionEntry> taxaEntries = entries.Skip(option.LocuriBuget).Take(option.LocuriTaxa).ToList();

                standingViewModel.BugetEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(bugetEntries);
                standingViewModel.TaxaEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(taxaEntries);
                standingViewModel.RromEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(rromEntries);
            }
            standingViewModel.Options = options;
            return View(standingViewModel);
        }

        public IActionResult StandingsByOption(int optionId,StandingViewModel standingViewModel)
        {
            var option = unitOfWork.Options.Get(optionId);
            var entries = unitOfWork.AdmissionEntries.GetAdmissionEntriesByOptionId(optionId);
            standingViewModel.BugetEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(entries).Take(option.LocuriBuget);
            return View("Index",standingViewModel);
        }
    }
}
