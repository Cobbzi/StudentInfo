using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class StudentList
    {
        List<Student> students = new List<Student>();

        public void AddStudent(string firstName, string lastName, Student.genderType gender, int age, Uri imageLink)
        {
            students.Add(new Student(firstName, lastName, gender, age, imageLink));
        }
    }
}
