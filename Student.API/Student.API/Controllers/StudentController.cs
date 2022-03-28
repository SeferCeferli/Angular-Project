using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Student.API.DomainModels;
using Student.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepositories studentRepositories;
        private readonly IMapper mapper;
        public StudentController(IStudentRepositories studentRepositories,IMapper mapper)
        {
            this.studentRepositories = studentRepositories;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students=await studentRepositories.GetStudents();

            return Ok(mapper.Map<List<Student1>>(students));
        }
        [HttpGet]
        [Route("[controller]/{studentId:guid}")]
        public async Task<IActionResult> GetAllStudentAsync([FromRoute] Guid studentId)
        {
            var student = await studentRepositories.GetStudent(studentId);
            if (student==null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Student1>(student));
        }
    }
}
