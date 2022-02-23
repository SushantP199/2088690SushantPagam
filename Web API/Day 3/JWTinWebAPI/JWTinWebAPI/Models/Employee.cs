using System;
using System.Collections.Generic;

namespace JWTinWebAPI.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public string Department { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
    }
}
