using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IBO.Business.DTOs
{
    public class SchoolDTOs
    {
        [Required]
        public string SchoolCode { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string SchoolContact { get; set; }
        [Required]
        public string SchoolAddress { get; set; }
    }
}
