using System;

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
        private string profile;
        public string Profile
        {
            get
            {
                return profile;
            }
        }

        public Student(string firstName, string lastName, genderType gender, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
        }

        public Student(string firstName, string lastName, genderType gender, int age, string profile)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.profile = profile;
        }
    }
}
