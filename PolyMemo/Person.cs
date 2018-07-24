using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolyMemo
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public void Display()
        {
            Console.WriteLine("Person Display");
        }
        public virtual void Display1()
        {
            Console.WriteLine("Person1 Display");
        }

     public    class Student:Person
        {
            public new void Display()
            {
                Console.WriteLine("Student Display");
            }
            public override void Display1()
            {
                Console.WriteLine("Student1 Display");
            }
        }

    }
}
