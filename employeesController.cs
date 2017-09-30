using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class employeesController : ApiController
    {

        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities edb = new EmployeeDBEntities())
            {
                return edb.Employees.ToList();
            }
        }

        //public void put([FromUri]int id,[FromUri] Employee emp)
        //{
        //    using (EmployeeDBEntities edb= new EmployeeDBEntities())
        //    {
        //        Employee emplo =  edb.Employees.Single(x => x.ID == id);
        //        emplo.FirstName = emp.FirstName;
        //        emplo.LastName = emp.LastName;
        //        emplo.Gender = emp.Gender;
        //        emplo.Salary = emp.Salary;
        //        edb.SaveChanges();                 

        //    }
        //}
       
    }
}
