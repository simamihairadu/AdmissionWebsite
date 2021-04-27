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
    public class SessionController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public SessionController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            var sessionList = mapper.Map<List<SessionViewModel>>(unitOfWork.Sessions.GetAll());
            return View(sessionList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SessionViewModel sessionViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create");
                }
                var session = mapper.Map<Session>(sessionViewModel);
                unitOfWork.Sessions.Add(session);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var session = unitOfWork.Sessions.Get(id);
                unitOfWork.Sessions.Remove(session);
                unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
