using BLL;
using DAL;
using School_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace School_WebAPI.Controllers
{
    public class DeptController : ApiController
    {
        static Helper helper;
        static DeptController()
        {

            helper = new Helper();
        }
        public List<Department> Get()
        {
            var dept = helper.ShowAllDept();

            List<Department> deptlist = new List<Department>();

            foreach (var item in dept)
            {
                deptlist.Add(new Department { DeptCode=item.DeptCode, DeptName= item.DeptName });
            }
            return deptlist;
        }

        // GET api/emp/5
        public Department Get(int id)
        {
            var found = helper.ShowDeptById(id);
            Department got = new Department { DeptCode = found.DeptCode, DeptName = found.DeptName };
            return got;
        }

        // POST api/emp
        public void Post([FromBody] Department d)
        {
            DeptMaster e = new DeptMaster();
            e.DeptCode = d.DeptCode;
            e.DeptName = d.DeptName;
            
            helper.CreateDept(e);

        }

        // PUT api/emp/5
        public void Put(int id, [FromBody] Department upd)
        {
            DeptMaster e = new DeptMaster();
            e.DeptCode = upd.DeptCode;
            e.DeptName = upd.DeptName;

            helper.UpdateDept(id, e);

        }

        // DELETE api/emp/5
        public void Delete(int id)
        {

            helper.RemoveDept(id);
        }
    }
}