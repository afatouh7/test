using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public class LineofBusiness
    {      
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees  { get; set; }
        public Account  Account { get; set; } 
       
    }
}
