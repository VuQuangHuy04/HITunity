using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public string Address { get; set; }
        public Person() { }
        public Person(string name , int age , string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public override string ToString()
        {
            return " Name: " + Name + " Age: "+ Age + " Address: " + Address ;
        }
    }
}
