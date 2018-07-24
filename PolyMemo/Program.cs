using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PolyMemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new PolyMemo.Person.Student();

            p.Display();
            p.Display1();
            Console.ReadLine();
        }
    }
}
