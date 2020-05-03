using IBO.Business.DTOs;
using IBO.IBusiness;
using IBO.IRepository;
using IBO.Repository.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Business
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<List<StudentDTOs>> GetAllStudentDetails()
        {
            return await _studentRepository.GetAllStudentDetails();
        }

        public async Task<IEnumerable> GetAllStudentName()
        {
            var studentName = await _studentRepository.GetAllStudentName();
            return studentName;
        }

        public async Task<StudentDTOs> GetStudentByID(int? id)
        {
            return await _studentRepository.GetStudentByID(id);
        }
        public async Task<bool> Register(StudentDTOs studentDTOs)
        {
            var createStudent = new Student
            {
                FirstName = studentDTOs.FirstName,
                LastName = studentDTOs.LastName,
                MobileNumber = studentDTOs.MobileNumber,
                DateOfBirth = studentDTOs.DateOfBirth,
                Email = studentDTOs.Email
            };
            await _studentRepository.Register(createStudent);
            return true;
        }
        public async Task<bool> DeleteStudentById(int? id)
        {
          return await _studentRepository.DeleteStudentById(id);
        }

        public async Task<bool> Update( int id, StudentDTOs studentDTOs)
        {
            var createStudent = new Student
            {
                FirstName = studentDTOs.FirstName,
                LastName = studentDTOs.LastName,
                MobileNumber = studentDTOs.MobileNumber,
                DateOfBirth = studentDTOs.DateOfBirth,
                Email = studentDTOs.Email
            };
            await _studentRepository.UpdateStudent(id,createStudent);
            return true;
        }
    }
}
