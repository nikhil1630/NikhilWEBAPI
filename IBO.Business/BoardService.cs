using IBO.Business.DTOs;
using IBO.IBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Business
{
    public class BoardService : IBoardService
    {
        public Task<List<BoardDTOs>> GetSchoolByboard(int id)
        {
            return null;
        }
    }
}
