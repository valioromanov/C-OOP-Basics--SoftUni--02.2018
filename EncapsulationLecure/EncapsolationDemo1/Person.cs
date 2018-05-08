using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsolationDemo1
{
    public class Person
    {
        const decimal MIN_SALARY = 460;
        private int age;
        private string firstName;
        private string lastName;
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < MIN_SALARY)
                    throw new ArgumentException($"Salary cannot be less than {MIN_SALARY} leva!");
                salary = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                //Validating Field with Method
                //ValidateFieldLenght(value, "Last name");
                //-------------------------------------------
                if (value?.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols");
                lastName = value;
            }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0 )
                    throw new ArgumentException("Age cannot be zero or negative");
                age = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                //Validate with Method
                //ValidateFieldLenght(value, "First name");
                //------------------------------------------
                if (value?.Length < 3)                
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols");
                firstName = value;
            }
        }
        public override string ToString()
        {
            return $"{firstName} {lastName} receives {salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age > 30)
            {
                salary = salary + salary * (percentage / 100);
            }
            else
            {
                salary = salary + salary * (percentage / 200);
            }
        }


        //Method for validating FirstName and LastName
        //private void ValidateFieldLenght(string fieldValue, string fieldName)
        //{

        //    if (fieldValue?.Length < 3)
        //        throw new ArgumentException($"{fieldName} cannot contain fewer than 3 symbols");
        //}


        public Person(string firstName, string lastName, int age, decimal salary)
            :this(firstName, lastName, age)
        {
            this.Salary = salary;
        }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }


    }
}
