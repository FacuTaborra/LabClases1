using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A InsA = new A();
            B InsB = new B();

            InsA.M1();
            InsA.M2();
            InsA.M3();
            InsB.M1();
            InsB.M2();
            InsB.M3();
            InsB.M4();

            Console.ReadKey();
        }
    }
}
