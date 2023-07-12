using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUDLibrary;

namespace CRUDWebAPI.Controllers
{
    public class StudentsController : ApiController
    {
        CollegeEntities OE = new CollegeEntities();
        // ..api/students/
        public IQueryable<student> Get()
        {
            return OE.students;
        }
        // ..api/students/1
        public student Get(int id)
        {
            student student = OE.students.Find(id);
            return student;
        }
        // ..api/department
        public void Put(int id, student student)
        {
            OE.Entry(student).State = System.Data.Entity.EntityState.Modified;
            OE.SaveChanges();
        }
        // ..api/students/
        public void Post(student student)
        {
            OE.students.Add(student);
            OE.SaveChanges();
        }
    }
}
