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
    [Authorize(Roles="Admin")]
    public class EmployeeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<IdentityUser> userManager;
        public EmployeeController(IMapper mapper, IUnitOfWork unitOfWork, UserManager<IdentityUser> userManager)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
        }
        public async Task<ActionResult> Index()
        {
            var users = await userManager.GetUsersInRoleAsync("Employee");
            var employees = mapper.Map<List<EmployeeViewModel>>(users);
            return View(employees);
        }

        public async Task<ActionResult> ConfirmAccount(string id)
        {
            var user = userManager.FindByIdAsync(id).Result;
            user.EmailConfirmed = true;
            await userManager.UpdateAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
