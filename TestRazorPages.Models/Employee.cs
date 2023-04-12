using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestRazorPages.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The name field cannot be null! Please, write the name")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please, enter a Valid Email (format: example@exem.com)")]
        public string Email { get; set; }
        public string PhotoPath { get; set; }

        public Dept? Department { get; set; }

    }
}
