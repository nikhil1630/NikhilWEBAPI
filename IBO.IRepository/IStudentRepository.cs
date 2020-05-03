using IBO.Business.DTOs;
using IBO.Repository.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IBO.IRepository
{
    public interface IStudentRepository
    {
        Task<List<StudentDTOs>> GetAllStudentDetails();
        Task<IEnumerable> GetAllStudentName();
        Task<StudentDTOs> GetStudentByID(int? id);
        Task<bool> Register(Student student);
        Task<bool> UpdateStudent(int id,Student student);
        Task<bool> DeleteStudentById(int? id);
    }
}
