using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practice2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private List<Student> _studentList;
        public StudentsController()
        {
            _studentList = new List<Student>();
        }

        [HttpPost]
        public Student CreateStudent([FromBody] string studentID, string studentName, string studentCarrer)
        {
            Student student = new Student()
            {
                ID = studentID,
                Name = studentName,
                Career = studentCarrer
            };
            _studentList.Add(student);
            return student;
        }

    }
}
