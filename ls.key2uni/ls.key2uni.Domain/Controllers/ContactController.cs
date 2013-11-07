using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ls.key2uni.Domain.Models;
using ls.key2uni.Entities;

namespace ls.key2uni.Domain.Controllers
{
    public class ContactController : Controller
    {
        private readonly ICustomerServices _db;

        public ContactController(ICustomerServices db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Index(int customerId)
        {
            var model = new ContactResponseModel();
            model.CustomerId = customerId;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ContactResponseModel contactResponse)
        {
            if (ModelState.IsValid)
            {
                var customer = new Customer();
                customer.FirstName = contactResponse.FirstName;
                customer.LastName = contactResponse.Surname;
                customer.Email = contactResponse.Email;

                _db.Save();

                return RedirectToAction("Success", "contact", new { id = contactResponse.CustomerId });
                //return View("Success", contactResponse);
            }
            else
            {
                return View();
            }
        }
    }
}
