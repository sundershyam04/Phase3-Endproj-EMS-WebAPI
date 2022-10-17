using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School_WebAPI.Models
{
    public class Department
    {
        [Required]
        public int DeptCode { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string DeptName { get; set; }
        public virtual ICollection<Employee> EmpProfiles { get; set; }
    }
}