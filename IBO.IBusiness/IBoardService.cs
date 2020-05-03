using IBO.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IBO.IBusiness
{
    public interface IBoardService
    {
        Task<List<BoardDTOs>> GetSchoolByboard(int id);
    }
}
