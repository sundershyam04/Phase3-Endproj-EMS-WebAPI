using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeptMaster
    {
        //Dept table each entry template

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int DeptCode { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum 50 Characters only")]
        public string DeptName { get; set; }
        public virtual ICollection<EmpProfile> EmpProfiles { get; set; }
    }
}
