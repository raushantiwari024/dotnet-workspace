using System;

namespace ClassAndObject
{
    class Student
    {
        // Private fields
        private int roll;
        private string? name;
        private int age;
        private string? city;

        // Public property for Roll
        public int Roll
        {
            get { return roll; } // Getter returns the value of the private field
            set { roll = value; } // Setter sets the value of the private field
        }

        // Public property for Name
        public string Name
        {
            get { return name??""; } // Getter returns the value of the private field
            set { name = value; } // Setter sets the value of the private field
        }

        // Public property for Age
        public int Age
        {
            get { return age; } // Getter returns the value of the private field
            set { age = value; } // Setter sets the value of the private field
        }

        // Public property for City
        public string City
        {
            get { return city??""; } // Getter returns the value of the private field
            set { city = value; } // Setter sets the value of the private field
        }
    }
}
