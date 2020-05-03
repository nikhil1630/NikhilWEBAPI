using IBO.Business.DTOs;
using IBO.Common.Mapper;
using IBO.IRepository;
using IBO.Repository.DBContextUtility;
using IBO.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IBO.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _dataContext;

        public StudentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<StudentDTOs>> GetAllStudentDetails()
        {
            var studentListFromDB = await _dataContext.Students.ToListAsync();
            if (studentListFromDB == null)
            {
                return null;
            }
            return EntityMapper<Student, StudentDTOs>.MapEntityCollection(studentListFromDB);
        }

        public async Task<IEnumerable> GetAllStudentName()
        {
            var listOfStudentFullName = new List<string>();

            var studentsFromDB = await _dataContext.Students.ToListAsync();
            if (studentsFromDB == null)
                return null;

            foreach (var studentFullName in studentsFromDB)
            {
                var student = studentFullName.FirstName + " " + studentFullName.LastName;

                listOfStudentFullName.Add(student);
            }
            return listOfStudentFullName;
        }

        public async Task<StudentDTOs> GetStudentByID(int? id)
        {
            var studentByIdFromDB = await _dataContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (studentByIdFromDB == null)
                return null;
            return EntityMapper<Student, StudentDTOs>.MapEntity(studentByIdFromDB);
        }

        public async Task<bool> Register(Student student)
        {
            await _dataContext.Students.AddAsync(student);
            await _dataContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateStudent(int id, Student student)
        {
            var studentByIdFromDB = await _dataContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (studentByIdFromDB == null)
            {
                return false;
            }
            else
            {
                studentByIdFromDB.FirstName = student.FirstName;
                studentByIdFromDB.LastName = student.LastName;
                studentByIdFromDB.MobileNumber = student.MobileNumber;
                studentByIdFromDB.DateOfBirth = student.DateOfBirth;
                studentByIdFromDB.Email = student.Email;

                await _dataContext.SaveChangesAsync();
            }
            return true;
        }
        public async Task<bool> DeleteStudentById(int? id)
        {
            var removeStudentFromDB = await _dataContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (removeStudentFromDB == null)
            {
                return false;
            }
            else
            {
                _dataContext.Remove(removeStudentFromDB);
                _dataContext.SaveChanges();
            }

            return true;
        }
    }
}
