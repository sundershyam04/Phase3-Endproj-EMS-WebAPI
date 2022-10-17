using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School_WebAPI.Models
{
    public class Employee
    {
        [Required]

        public int EmpCode { get; set; }

        
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
         ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string EmpName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

       
        [Required]
        public int DeptCode { get; set; }
        public virtual Department Dept { get; set; }

    }
}