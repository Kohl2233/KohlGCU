﻿using AppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduler.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAppointmentDetails(AppointmentModel appointmentModel)
        {
            return View(appointmentModel);
        }
    }
}
