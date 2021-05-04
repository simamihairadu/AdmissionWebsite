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
            var departments = unitOfWork.Departments.GetAll();
            var model = mapper.Map<List<DepartmentViewModel>>(departments);

            return View(model);
        }

        public ActionResult RegisterContestant()
        {
            if (unitOfWork.Sessions.IsAnyActive())
            {
                var departments = unitOfWork.Departments.GetAll();
                var mappedDepartments = mapper.Map<IEnumerable<DepartmentViewModel>>(departments);
                var admissionEntryViewModel = new AdmissionEntryViewModel
                {
                    Departments = mappedDepartments
                };
                return View(admissionEntryViewModel);
            }
            return View("RegisterError");
        }

        [HttpPost]
        public ActionResult RegisterContestant(AdmissionEntryViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var departments = unitOfWork.Departments.GetAll();
                    var mappedDepartments = mapper.Map<IEnumerable<DepartmentViewModel>>(departments);
                    var admissionEntryViewModel = new AdmissionEntryViewModel
                    {
                        Departments = mappedDepartments
                    };
                    return View("RegisterContestant", admissionEntryViewModel);
                }

                var employee = userManager.GetUserAsync(User).Result;
                var contestant = mapper.Map<Contestant>(model.Contestant);
                var session = unitOfWork.Sessions.GetActiveSession();
                unitOfWork.Contestants.Add(contestant);

                var admissionEntry = new AdmissionEntry
                {
                    ContestantId = contestant.ContestantId,
                    EntryScore = model.EntryScore,
                    DepartmentId = model.DepartmentId,
                    EmployeeId = employee.Id,
                    SessionId = session.Id,
                    DateCreated = DateTime.Now
                };
                unitOfWork.AdmissionEntries.Add(admissionEntry);
                unitOfWork.Complete();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public ActionResult RegisterError()
        {
            return View();
        }
    }
}
