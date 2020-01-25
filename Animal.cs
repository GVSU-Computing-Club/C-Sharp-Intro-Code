using System;

namespace HelloWorld {
    public class Animal
    {
        //Member Variables
        public String Name {get; set;}
        //Field
        private int _age;
        public int Age 
        {
            get {
                return _age;
            }
            private set{
                _age = value;
            }
        }

        //Constructor
        public Animal(String n, int a) {
            this.Name = n;
            this.Age = a;
        }

        public int GetYearOfBirth() {
            return 2020 - Age;
        }

        public override string ToString() {
            return Name + " is " + Age + " years old.";
        }
    }
}