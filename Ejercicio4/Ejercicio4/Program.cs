using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if(n1 % n2 == 0)
            {
                Console.WriteLine("El primer numero {0}, es multiplo del segundo numero {1}",n1,n2);
            }
            else
            {
                Console.WriteLine("El primer numero {0}, no es multiplo del segundo numero {1}", n1, n2);
            }
            Console.ReadKey();

        }
    }
}
