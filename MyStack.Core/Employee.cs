using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack.Core
{
    public class Employee
    {
        private readonly string firstName;
        private readonly string lastName;

        public Employee(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
        }

        public int Age { get; }
    }
}
