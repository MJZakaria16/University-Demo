﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json;

namespace UniversityCourseAndResultManagementSystem.Models
{
    public class Teacher
    {
        [Key]
        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }

        [Display(Name = "Teacher Name")]
        [Required(ErrorMessage = "Enter Teacher Name")]
        public string TeacherName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Enter The Address of Teacher")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email")]
        [Remote("TeacherEmailExits", "Teachers", ErrorMessage = "Email already exits.Try with another email.")]
        public string Email { get; set; }

        [Display(Name = "Contact No")]
        [Required(ErrorMessage = "Enter Contact Number of Teacher")]
        public string ContactNo { get; set; }

        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Please select designation")]
        public int DesignationId { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Please select department")]
        public int DeptId { get; set; }

        [Range(0.5,double.MaxValue,ErrorMessage = "Creadit can not be less than 0.5")]
        [Display(Name = "Creadit To Be Taken")]
        [Required(ErrorMessage = "Creadit to be taken by teacher?")]
        public double CreaditToBeTaken { set; get; }

        [DefaultValue(0.0)]
        public double RemaingCreadit { get; set; }

        [ForeignKey("DesignationId")]
       public virtual Designation Designation { get; set; }

        [ForeignKey("DeptId")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Course> Courses { get; set; } 

        
    }
}