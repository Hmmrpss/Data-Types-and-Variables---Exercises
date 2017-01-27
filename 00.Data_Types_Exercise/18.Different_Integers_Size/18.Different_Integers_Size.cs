/* Задача 18: Different Integers Size
Given an input integer, you must determine which primitive data types are capable of properly storing that input.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _00.Data_Types_Exercise
{
    class Program
    {
        static void Main() // sbyte < byte < short < ushort < int < uint < long
        {
            BigInteger givenInteger = BigInteger.Parse(Console.ReadLine());

            if ((long.MinValue <= givenInteger) && (givenInteger <= long.MaxValue))
            {
                Console.WriteLine("{0} can fit in:", givenInteger);
                if ((sbyte.MinValue <= givenInteger) && (givenInteger <= sbyte.MaxValue))
                {
                    Console.WriteLine("* sbyte");
                }
                if ((byte.MinValue <= givenInteger) && (givenInteger <= byte.MaxValue))
                {
                    Console.WriteLine("* byte");
                }
                if ((short.MinValue <= givenInteger) && (givenInteger <= short.MaxValue))
                {
                    Console.WriteLine("* short");
                }
                if ((ushort.MinValue <= givenInteger) && (givenInteger <= ushort.MaxValue))
                {
                    Console.WriteLine("* ushort");
                }
                if ((int.MinValue <= givenInteger) && (givenInteger <= int.MaxValue))
                {
                    Console.WriteLine("* int");
                }
                if ((uint.MinValue <= givenInteger) && (givenInteger <= uint.MaxValue))
                {
                    Console.WriteLine("* uint");
                }
                if ((long.MinValue <= givenInteger) && (givenInteger <= long.MaxValue))
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", givenInteger);
            }
        }
    }
}

/*                      RESHENIE V KLAS (NAMERI KLIPA)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program                                   // sbyte < byte < short < ushort < int < uint < long
    {
        static void Main()
        {
            //var givenInteger = Console.ReadLine();
            try
            {
                var givenInteger = Console.ReadLine();
                Type givenIntegerType = typeof(givenInteger); // I pass <T> in as a paramter, where myObj is of type T
                tagBuilder.Attributes.Add("class", givenIntegerType.Name);
                foreach (PropertyInfo prop in givenIntegerType.GetProperties())
                {
                    object propValue = prop.GetValue(myObj, null);
                    string stringValue = propValue != null ? propValue.ToString() : String.Empty;
                    tagBuilder.Attributes.Add(prop.Name, stringValue);
                }
                if (givenIntegerType.IsPrimitive || givenIntegerType == typeof(Decimal) || givenIntegerType == typeof(Int) || ... )
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
*/