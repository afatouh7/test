using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee>  Employees { get; set; }
        public List<LineofBusiness> LineofBusinesses { get; set; }
    }
}
