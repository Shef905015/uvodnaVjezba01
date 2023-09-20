using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableIspisPodataka
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a = 100;
            int b = 3;
            int x = a / b;
            int y = a % b;


            Console.WriteLine(a + " dijeljeno sa " + b + " je " + x + " s ostatkom " + y);

            Console.ReadKey();
        }
    }
}
