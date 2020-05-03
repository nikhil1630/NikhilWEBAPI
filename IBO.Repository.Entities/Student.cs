using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Repository.Entities
{
   public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
