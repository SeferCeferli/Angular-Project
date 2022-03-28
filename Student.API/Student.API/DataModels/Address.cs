using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.API.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAdress { get; set; }
        public string PostalAdress { get; set; }
        public Guid StudentId { get; set; }
    }
}
