using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDprojekt.Data
{
    public class StudentService : IStudentService
    {

        List<Student> _students;

        public StudentService(){
            _students=new List<Student>{
                new Student{
                    Name="jan",
                    LastName="zxy",
                    ID=1,
                    BirthDate=new System.DateTime(2001,12,12),
                    Studies="ble",
                    Avatar="https://image.shutterstock.com/image-vector/people-person-icon-modern-flat-260nw-1691909635.jpg"
                },
                new Student{
                    Name="fernando",
                    LastName="alonso",
                    ID=2,
                    BirthDate=new System.DateTime(2001,12,12),
                    Studies="ble",
                    Avatar="https://image.shutterstock.com/image-vector/people-person-icon-modern-flat-260nw-1691909635.jpg"
                },
                new Student{
                    Name="george",
                    LastName="russell",
                    ID=3,
                    BirthDate=new System.DateTime(2001,12,12),
                    Studies="ble",
                    Avatar="https://image.shutterstock.com/image-vector/people-person-icon-modern-flat-260nw-1691909635.jpg"
                },
                new Student{
                    Name="lando",
                    LastName="norris",
                    ID=4,
                    BirthDate=new System.DateTime(2001,12,12),
                    Studies="ble",
                    Avatar="https://image.shutterstock.com/image-vector/people-person-icon-modern-flat-260nw-1691909635.jpg"
                }
            };
        }
        public List<Student> GetStudents(){
                return _students;
          }
        public Student GetStudent(int id){
            return _students.FirstOrDefault(e=> e.ID==id);
        }
        public bool Remove(int id){
                return _students.Remove(_students.FirstOrDefault(e=>e.ID==id));
        }
    }
}