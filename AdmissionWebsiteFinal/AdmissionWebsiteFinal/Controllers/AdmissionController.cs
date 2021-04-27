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
    public class AdmissionController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public AdmissionController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var departments = unitOfWork.Departments.GetAll();
            var model = mapper.Map<List<DepartmentViewModel>>(departments);

            return View(model);
        }

        public ActionResult Apply()
        {
            var departments = unitOfWork.Departments.GetAll();
            var mappedDepartments = mapper.Map<IEnumerable<DepartmentViewModel>>(departments);
            var admissionEntryViewModel = new AdmissionEntryViewModel
            {
                Departments = mappedDepartments
            };
            return View(admissionEntryViewModel);
        }

        [HttpPost]
        public ActionResult Apply(AdmissionEntryViewModel model)
        {
            return View();
        }
    }
}
