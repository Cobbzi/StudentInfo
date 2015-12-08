using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Student
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
        }
        public enum genderType { Male, Female };
        private genderType gender;
        public genderType Gender
        {
            get
            {
                return gender;
            }
        }
        private Uri imageLink;
        public Uri ImageLink
        {
            get
            {
                return imageLink;
            }
        }

        public Student(string firstName, string lastName, genderType gender, int age, Uri imageLink)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.imageLink = imageLink;
        }
    }
}
