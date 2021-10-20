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
            Name n = new Name("Bill", "Gates");
            Person p = new Person(55,n);

            Name n2 = new Name("DR", "Rotshild");
            Person p2 = new Person(88, n2);

            Person[] personArray = new Person[2];

            personArray[0] = p;
            personArray[1] = p2;

            //print simple class
            // PrintObjects.MyPrint(n);

            //print class that contain class 
            // PrintObjects.MyPrint(p);

            //print array object
            PrintObjects.MyPrint(personArray);
        }
    }
}
