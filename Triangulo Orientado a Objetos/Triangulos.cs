using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo_Orientado_a_Objetos
{
    internal class Triangulos
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public int CalculoTriangulos()
        {
            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                Console.WriteLine("Os 3 lados formam um triangulo!\n");
                if (ladoA == ladoB && ladoA == ladoC)
                    Console.WriteLine("Equilatero\n");
                else
                    if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    Console.WriteLine("Isosceles\n");
                else
                    Console.WriteLine("Escaleno\n");
            }
            else
                Console.WriteLine("Triangulo invalido!\n");

            return 0;
        }
    }
}

