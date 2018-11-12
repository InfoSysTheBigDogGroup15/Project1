using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Contact
    {
        [DisplayName("First Name")]
        public string contactFName { get; set; }

        [DisplayName("Last Name")]
        public string contactLName { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email Address")]
        public string contactEmailAddress { get; set; }


        [Required]
        [EmailAddress]
        [Compare("contactEmailAddress")]
        [DisplayName("Verify Email Address")]
        public string contactVerifyEmailAddress { get; set; }

        [DisplayName("Subject")]
        public string ContactSubject { get; set; }

        [Required]
        [DisplayName("Message")]
        public string contactBody { get; set; }

    }
}