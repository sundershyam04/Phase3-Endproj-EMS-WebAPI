using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Helper
    {
        static EmpOperations opr;

        static Helper()
        {

            opr = new EmpOperations();
        }
        public List<EmpProfile> ShowAllEmp()
        {

           return  opr.GetAllEmp();

        }

        public EmpProfile ShowEmpById(int id)
        {

           var fnd = opr.GetEmpById(id);
            return fnd;

        }

        public void CreateEmp(EmpProfile e)
        {

            opr.PostEmp(e);
     
        }

        public void UpdateEmp(int id, EmpProfile e)
        {

            opr.PutEmp(id, e);

        }

        public void RemoveEmp(int id)
        {

            opr.DelEmp(id);

        }
        //-----------------------------DEPARTMENT HELPER---------------

        public List<DeptMaster> ShowAllDept()
        {

            return opr.GetAllDept();

        }

        public DeptMaster ShowDeptById(int id)
        {

            var fnd = opr.GetDeptById(id);
            return fnd;

        }
        public void CreateDept(DeptMaster d)
        {

            opr.PostDept(d);

        }
        public void UpdateDept(int id, DeptMaster e)
        {

            opr.PutDept(id, e);

        }
        public void RemoveDept(int id)
        {

            opr.DelDept(id);

        }



    }
}
