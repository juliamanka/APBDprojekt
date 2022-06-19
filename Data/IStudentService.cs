using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDprojekt.Data
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public bool Remove(int id);
        
    }
}