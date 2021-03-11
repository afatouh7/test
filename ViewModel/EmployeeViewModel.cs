using EmpApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.ViewModel
{
    public class EmployeeViewModel
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        //[RegularExpression("^[a-zA-Z]$")]
        public string Name { get; set; }
        //[MaxLength(14)]
        //[MinLength(14)]
        //[RegularExpression("[^0-9]", ErrorMessage = "your national id is 14 number")]
        public string NationalId { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        //[Required(ErrorMessage = "Age is required")]
        //[Range(typeof(int), "18", "60", ErrorMessage = "Age can only be between 18 and 60")]
        public int Age { get; set; }
        public List<Account> Account { get; set; }
        public int AccountId { get; set; }

        public List<LineofBusiness> LineofBusiness { get; set; }
        public int LineofBusinessId { get; set; }   

    }
}
