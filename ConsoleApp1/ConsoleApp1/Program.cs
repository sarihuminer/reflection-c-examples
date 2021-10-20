using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Name n = new Name();
            n.firstName = "Bill";
            n.lastName = "Gates";
            Person p = new Person();
            p.age = 55;
            p.name = n;

            
            //print simple class
            // PrintObjects.MyPrint(n);
            //print class that contain class 
            // PrintObjects.MyPrint(p);
        }
    }
}
