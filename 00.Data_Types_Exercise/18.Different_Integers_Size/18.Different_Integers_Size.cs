/* Задача 18: Different Integers Size
Given an input integer, you must determine which primitive data types are capable of properly storing that input.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main()
        {
            var givenInteger = Console.ReadLine();
            try
            {
                Type t = typeof(givenInteger); // I pass <T> in as a paramter, where myObj is of type T
                tagBuilder.Attributes.Add("class", t.Name);
                foreach (PropertyInfo prop in t.GetProperties())
                {
                    object propValue = prop.GetValue(myObj, null);
                    string stringValue = propValue != null ? propValue.ToString() : String.Empty;
                    tagBuilder.Attributes.Add(prop.Name, stringValue);
                }
                if (t.IsPrimitive || t == typeof(Decimal) || t == typeof(String) || ... )
                {
                }

{
    // Is Primitive, or Decimal, or String
}
            }
            catch (System.ArgumentOutOfRangeException)
            {
                
                throw;
            }
        }
    }
}
