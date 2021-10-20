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

            FieldInfo[] fieldInfo = null;
            fieldInfo = o.GetType().GetFields();

            foreach (var item in fieldInfo)
            {
                var prop = item.GetValue(o);
                if (prop == null)
                {
                    Console.WriteLine(item.Name + ": NULL");
                }
                else
                {
                    if (prop.GetType().Equals(typeof(string)) || prop.GetType().IsPrimitive)
                    {
                        Console.WriteLine(item.Name + ": " + prop.ToString());
                    }
                    else
                    {
                        MyPrint(prop);
                    }

                }
            }


            //if (prop is IEnumerable)
            //{
            //    foreach (var listitem in prop as IEnumerable)
            //    {
            //        Console.WriteLine("Item: " + listitem.ToString());
            //    }
            //}
        }

    }
}
