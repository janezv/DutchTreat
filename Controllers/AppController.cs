using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController:Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet("Contact")]
       public IActionResult Contact()
        {
            //throw new InvalidProgramException("Bad things happen to good developers");
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("shawn@wd.com", model.Subject, $"From - {model.Name}: {model.Email}, Message:{model.Message}");
                ViewBag.UserMessage = "Message Send";
                ModelState.Clear();
            }
   
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
