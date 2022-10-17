using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class EmpManagementInitializer : DropCreateDatabaseIfModelChanges<EmpManagementContext>
    {
        protected override void Seed(EmpManagementContext context)
        {
            // adding values to deptmaster table

            List<DeptMaster> deptMasterList = new List<DeptMaster>();

            deptMasterList.Add(new DeptMaster() { DeptCode = 1, DeptName = "HR" });
            deptMasterList.Add(new DeptMaster() { DeptCode = 2, DeptName = "Marketing" });
            deptMasterList.Add(new DeptMaster() { DeptCode = 3, DeptName = "Product Management" });

            context.DeptMasters.AddRange(deptMasterList);

            List<EmpProfile> empProfileList = new List<EmpProfile>();

            empProfileList.Add(new EmpProfile() { DeptCode = 1, EmpName = "Ganesh", DateOfBirth = new DateTime(2000, 01, 10), Email = "ganesh@gmail.com", EmpCode = 1000 });
            empProfileList.Add(new EmpProfile() { DeptCode = 2, EmpName = "Siva", DateOfBirth = new DateTime(1999, 02, 15), Email = "siva21@gmail.com", EmpCode = 1001 });
            empProfileList.Add(new EmpProfile() { DeptCode = 3, EmpName = "Ram", DateOfBirth = new DateTime(2002, 07, 01), Email = "ram34@gmail.com", EmpCode = 1002 });


            context.EmpProfiles.AddRange(empProfileList);

            context.SaveChanges();

            base.Seed(context);
        }

}
    
}
