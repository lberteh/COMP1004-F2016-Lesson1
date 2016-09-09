using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_F2016_Lesson1
{
    public class Person
    {
        // private instance variables
        private string _name;
        private int _age;

        // public properties
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        // constructors 
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // public methods
        public void saysHello()
        {
            Console.WriteLine(this.Name + " says hello!");
        }
    }
}
