using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using AdmissionWebsiteFinal.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using AdmissionWebsiteFinal.DataExport;

namespace AdmissionWebsiteFinal.Controllers
{
    public class StandingsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        static List<AdmissionEntry> rromEntries;
        static List<AdmissionEntry> rdpEntries;
        static List<AdmissionEntry> bugetEntries;
        static List<AdmissionEntry> taxaEntries;
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
        private List<AdmissionEntry> GetRDPEntries(ref List<AdmissionEntry> entries, int spotNumber)
        {
            List<AdmissionEntry> rdpEntries = entries.Where(e => e.RDPSpot == true).
                OrderByDescending(e => e.EntryScore).
                Take(spotNumber).ToList();
            entries.RemoveAll(e => rdpEntries.Contains(e));
            return rdpEntries;
        }
        public IActionResult Index(StandingViewModel standingViewModel)
        {
            var option = unitOfWork.Options.Get(standingViewModel.OptionId);
            var session = mapper.Map<SessionViewModel>(unitOfWork.Sessions.GetActiveSession());
            var options = mapper.Map<IEnumerable<OptionViewModel>>(unitOfWork.Options.GetOptionsBySessionId(session.Id));

            var entries = unitOfWork.AdmissionEntries.GetAdmissionEntriesByOptionId(standingViewModel.OptionId).ToList();
            if(option != null)
            {
                rromEntries = GetRromEntries(ref entries, option.LocuriRrom);
                rdpEntries = GetRDPEntries(ref entries, option.LocuriRomanDePretutindeni);
                bugetEntries = entries.Take(option.LocuriBuget).ToList();
                taxaEntries = entries.Skip(option.LocuriBuget).Take(option.LocuriTaxa).ToList();

                standingViewModel.BugetEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(bugetEntries);
                standingViewModel.TaxaEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(taxaEntries);
                standingViewModel.RromEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(rromEntries);
                standingViewModel.RDPEntries = mapper.Map<IEnumerable<AdmissionEntryViewModel>>(rdpEntries);
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

        public IActionResult StandingsToPdf()
        {
            PdfExporter pdfExporter = new PdfExporter();
            PdfDocument doc = new PdfDocument();

            pdfExporter.CreatePdfTable(ref doc,"Locuri buget", mapper.Map<IEnumerable<AdmissionEntryViewModel>>(bugetEntries));
            pdfExporter.CreatePdfTable(ref doc,"Locuri taxa", mapper.Map<IEnumerable<AdmissionEntryViewModel>>(taxaEntries));
            pdfExporter.CreatePdfTable(ref doc,"Locuri rrom", mapper.Map<IEnumerable<AdmissionEntryViewModel>>(rromEntries));
            pdfExporter.CreatePdfTable(ref doc,"Locuri romani de pretutindeni", mapper.Map<IEnumerable<AdmissionEntryViewModel>>(rdpEntries));

            MemoryStream stream = new MemoryStream();
            doc.Save(stream);
            stream.Position = 0;
            doc.Close(true);
            string contentType = "application/pdf";
            string fileName = "Output.pdf";

            return File(stream, contentType, fileName);
        }
    }
}
