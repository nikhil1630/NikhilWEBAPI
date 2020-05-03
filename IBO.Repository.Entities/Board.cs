using System;
using System.Collections.Generic;
using System.Text;

namespace IBO.Repository.Entities
{
    public class Board
    {
        public int Id { get; set; }
        public string BoardCode { get; set; }
        public string BoardName { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}
