using Microsoft.EntityFrameworkCore;
using Student.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.Repositories
{
    public class SqlStudentRepository : IStudentRepositories
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }



        public async Task<List<DataModels.Student>> GetStudents()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

        public async Task<DataModels.Student> GetStudent(Guid studentId)
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).FirstOrDefaultAsync(x=>x.Id==studentId);
        }
    }
}
