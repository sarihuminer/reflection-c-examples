using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PrintObjects
    {

        public static void MyPrint(object o)
        {
            if (o.GetType().IsArray ||o is IEnumerable)
            {
                foreach (var item in o as IEnumerable)
                {
                    MyPrint(item);
                }
            }

            FieldInfo[] fieldInfo = null;
            fieldInfo = o.GetType().GetFields();

            foreach (var item in fieldInfo)
            {
                var prop = item.GetValue(o);
                if (prop == null)
                {
                    Console.Write(item.Name + ": NULL");
                }
                else
                {
                    if (prop.GetType().Equals(typeof(string)) || prop.GetType().IsPrimitive)
                    {
                        Console.Write(item.Name + ": " + prop.ToString()+" ");
                    }
                    else
                    {
                        MyPrint(prop);
                    }

                }
            }
            Console.WriteLine();
      
        }

    }
}
