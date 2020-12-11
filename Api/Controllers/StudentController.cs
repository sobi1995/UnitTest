using Api.Model;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class StudentController : ControllerBase
    {
        List<Student> Students;
        private readonly ILogFileServises _logFileServises;
        public StudentController(ILogFileServises logFileServises)
        {
            _logFileServises = logFileServises;
            Students = new List<Student>() { 
            
            new Student(){Id=1,Name="Sobhan",Age=25},
            new Student(){ Id=2,Name="Baran",Age=3 },
            new Student(){ Id=3,Name="Amir",Age=27} 
            
            };

        }
        public  IActionResult Add(Student student)
        {
            if(Students.Any(x=> x.Id==student.Id))
            {
                _logFileServises.WriteLog("The Item Is Exist");
                return BadRequest();
            }
            _logFileServises.WriteLog("The Item Added");
            Students.Add(student);
            return Ok();
        }
    }
}
