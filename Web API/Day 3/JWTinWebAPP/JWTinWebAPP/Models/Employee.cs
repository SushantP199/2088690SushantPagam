using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JWTinWebAPP.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public string Department { get; set; } = null!;

        [Display(Name="Date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
