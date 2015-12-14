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
        private string occupation;
        public string Occupation
        {
            get
            {
                return occupation;
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

        public Student(string firstName)
        {
            this.firstName = firstName;
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student(string firstName, string lastName, genderType gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }

        public Student(string firstName, string lastName, genderType gender, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
        }

        public Student(string firstName, string lastName, genderType gender, int age, string occupation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.occupation = occupation;
        }

        public Student(string firstName, string lastName, genderType gender, int age, string occupation, string profile)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.occupation = occupation;
            this.profile = profile;
        }
    }
}
