using digital.Interfaces;
using digital.Models;
using System.Collections.Generic;
using System.Linq;

namespace digital.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Student GetStudentById(int id)
        {
            return _context.Student.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<object> GetAllStudentsWithCategoryAndSubCategory()
        {
            return _context.Student
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    CategoryName = _context.Categories.FirstOrDefault(c => c.Id == s.CategoryId).Name,
                    SubCategoryName = _context.SubCategories.FirstOrDefault(sc => sc.Id == s.SubCategoryId).Name,
                    s.DOB,
                    s.Gender,
                    s.MobileNumber,
                    s.Address,
                    s.Email,
                    s.Password
                }).ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
        }
    }
}
