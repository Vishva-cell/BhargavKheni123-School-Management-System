using digital.Models;
using System.Collections.Generic;

namespace digital.Interfaces
{
    public interface IStudentRepository
    {
        Student GetStudentById(int id);
        IEnumerable<object> GetAllStudentsWithCategoryAndSubCategory();
        void AddStudent(Student student);
    }
}
