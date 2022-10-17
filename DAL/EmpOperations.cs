using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpOperations
    {
        static EmpManagementContext context;

        static EmpOperations()
        {
            context = new EmpManagementContext();
        }

        public List<EmpProfile> GetAllEmp()
        {

            return context.EmpProfiles.ToList();

        }

        public EmpProfile GetEmpById(int id)
        {

            var found = context.EmpProfiles.ToList().Find(e => e.EmpCode == id);
            return found;

        }

        public void PostEmp(EmpProfile e)
        {

            context.EmpProfiles.Add(e);
            context.SaveChanges();
        }
        public void PutEmp(int id, EmpProfile e)
        {
            var found = context.EmpProfiles.ToList().Find(a => a.EmpCode == id);
            context.EmpProfiles.Remove(found);
            context.EmpProfiles.Add(e);
            context.SaveChanges();
        }
        public void DelEmp(int id)
        {
            var found = context.EmpProfiles.ToList().Find(a => a.EmpCode == id);
            context.EmpProfiles.Remove(found);         
            context.SaveChanges();
        }

        //---------------Dept operations-----------
        public List<DeptMaster> GetAllDept()
        {

            return context.DeptMasters.ToList();

        }

        public DeptMaster GetDeptById(int id)
        {

            var found = context.DeptMasters.ToList().Find(e => e.DeptCode == id);
            return found;

        }

        public void PostDept(DeptMaster d)
        {

            context.DeptMasters.Add(d);
            context.SaveChanges();
        }

        public void PutDept(int id, DeptMaster d)
        {
            var found = context.DeptMasters.ToList().Find(a => a.DeptCode == id);
            context.DeptMasters.Remove(found);
            context.DeptMasters.Add(d); 
            context.SaveChanges();
        }

        public void DelDept(int id)
        {
            var found = context.DeptMasters.ToList().Find(a => a.DeptCode == id);
            context.DeptMasters.Remove(found);
            context.SaveChanges();
        }

    }
}
