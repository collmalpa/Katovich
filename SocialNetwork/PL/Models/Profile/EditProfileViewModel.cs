﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PL.Models.Profile
{
    public class EditProfileViewModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "First name:")]
        public string FirstName { get; set; }

        [Display(Name = "Last name:")]
        public string LastName { get; set; }

        [Display(Name = "Gender:")]
        public bool Gender { get; set; }

        [Display(Name = "Date of birth:")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "City:")]
        public string City { get; set; }

        [Display(Name = "Contact phone:")]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhone { get; set; }

        [Display(Name = "About me:")]
        [DataType(DataType.MultilineText)]
        public string AboutMe { get; set; }

    }
}