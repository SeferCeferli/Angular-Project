using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.Repositories
{
    public  interface IStudentRepositories
    {
        Task<List<Student.API.DataModels.Student>> GetStudents();
        Task<Student.API.DataModels.Student> GetStudent(Guid studentId);
    }
}
