using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IBO.Business.DTOs
{
    public class BoardDTOs
    {
        [Required]
        public string BoardCode { get; set; }
        [Required]
        public string BoardName { get; set; }
     
        public List<SchoolDTOs> Schools { get; set; }
    }
}
