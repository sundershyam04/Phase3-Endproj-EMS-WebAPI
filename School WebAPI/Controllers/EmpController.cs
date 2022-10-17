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
    public class EmpController : ApiController
    {
        // GET api/emp
        static Helper helper;
        static EmpController()
        {

             helper = new Helper();
        }
        public List<Employee> Get()
            {
            var emp = helper.ShowAllEmp();

            List<Employee> emplist = new List<Employee>();

            foreach (var item in emp)
            {
                emplist.Add(new Employee { EmpCode = item.EmpCode, EmpName = item.EmpName, DateOfBirth = item.DateOfBirth, Email = item.Email, DeptCode = item.DeptCode });
            }
            return emplist;
        }

        // GET api/emp/5
        public Employee Get(int id)
        {
            var found = helper.ShowEmpById(id);
             Employee got = new Employee { EmpName=found.EmpName, EmpCode=found.EmpCode, DateOfBirth=found.DateOfBirth, Email=found.Email,DeptCode=found.DeptCode};
            return got;
        }

        // POST api/emp
        public void Post([FromBody] Employee emp)
        {
            EmpProfile e  = new EmpProfile();
            e.EmpName = emp.EmpName;
            e.EmpCode = emp.EmpCode;
            e.DateOfBirth = emp.DateOfBirth;
            e.Email = emp.Email;
            e.DeptCode = emp.DeptCode;

            helper.CreateEmp(e);

        }

        // PUT api/emp/5
        public void Put(int id, [FromBody] Employee upd)
        {
            EmpProfile e = new EmpProfile();
            e.EmpName = upd.EmpName;
            e.EmpCode = upd.EmpCode;
            e.DateOfBirth = upd.DateOfBirth;
            e.Email = upd.Email;
            e.DeptCode = upd.DeptCode;
           
            helper.UpdateEmp(id, e);

        }

        // DELETE api/emp/5
        public void Delete(int id)
        {

            helper.RemoveEmp(id);
        }
    }
}
