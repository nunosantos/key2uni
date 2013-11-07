using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ls.key2uni.Domain.Models
{
    public class ContactResponseModel
    {
        [HiddenInput(DisplayValue = false)]
        public int CustomerId { get; set; }

        [Required (ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Please enter your Last Name")]
        public string Surname { get; set; }

        [Required (ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Please enter your comment into the subject field")]
        public string Subject { get; set; }
    }
}