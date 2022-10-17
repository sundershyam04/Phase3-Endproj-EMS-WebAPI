using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpProfile
    {

        // Employee table each entry template

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpCode { get; set; }

        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string EmpName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("DeptMaster")]
        [Required]
        public int DeptCode { get; set; }
        public virtual DeptMaster DeptMaster { get; set; }

    }
}
