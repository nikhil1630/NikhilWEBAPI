using IBO.Business.DTOs;
using IBO.Repository.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IBO.IBusiness
{
    public interface IStudentService
    {
        Task<List<StudentDTOs>> GetAllStudentDetails();
        Task<IEnumerable> GetAllStudentName();
        Task<StudentDTOs> GetStudentByID(int? id);
        Task<bool> Register(StudentDTOs studentDTOs);
        Task<bool> Update(int id,StudentDTOs studentDTOs);
        Task<bool> DeleteStudentById(int? id);
    }
}
