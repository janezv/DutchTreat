using DutchTreat.Data;
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
        private readonly DutchContext _context;

        public AppController(IMailService mailService, DutchContext context)
        {
            _mailService = mailService;
            _context = context;
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

        public IActionResult Shop()
        {
            var result=from p in _context.Products
                       orderby p.Category
                       select p;

            return View(result.ToList());
        }
    }
}
