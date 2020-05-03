using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Repository.Entities
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolCode { get; set; }
        public string SchoolName { get; set; }
        public string SchoolContact { get; set; }
        public string SchoolAddress { get; set; }
    }
}
