using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignedUnsigned
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(b);

            uint c = uint.MaxValue;
            int d = int.MinValue;
            Console.WriteLine($"Max = {c}, Min = {d}");
        }
    }
}
