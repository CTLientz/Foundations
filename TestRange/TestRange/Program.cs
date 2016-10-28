using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRange
{
    class TestRange
    {
        static void Main()
        {
            Console.WriteLine("byte.MinVal = {0} byte.MaxVal = {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte.Minval = {0} sbyte.MaxVal = {1}", sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("short.MinVal = {0} short.MaxVal = {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort.MinVal = {0} ushort.MaxVal = {1}", ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("int.MinVal = {0} int.MaxVal = {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint.MinVal = {0} uint.MaxVal = {1}", uint.MinValue, uint.MaxValue);

            Console.WriteLine("long.MinVal = {0} long.MaxVal = {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong.MinVal = {0} ulong.MaxVal = {1}", ulong.MinValue, ulong.MaxValue);



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
;