using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VoTanLe_5951071048.Models;

namespace VoTanLe_5951071048.Controllers
{

    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInfList = new List<StudentInfo>();
            for (int i = 0; i < 100; i++)
            {
                var StudentInfo = new StudentInfo
                {
                    Name = $"Name {i}",
                    Age = i,
                    Student_code = $"CODE {i}"
                };
                StudentInfList.Add(StudentInfo);
            }
            return StudentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Name = $"Name {id}",
                Age = id,
                Student_code = $"CODE {id}"
            }; ;
        }
     
    }
}
