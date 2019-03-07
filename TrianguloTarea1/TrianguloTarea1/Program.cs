using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloTarea1
{
    class Program {

        static double potencia(double lA, double lB, double ang)
        {
            double v1, v2;

            v1 = Math.Pow(lA, 2);
            v2 = Math.Pow(lB, 2);


            double radianes, coseno, resultado;

            radianes = (Math.PI / 180) * ang;
            coseno = Math.Cos(radianes);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(coseno);

            resultado = Math.Sqrt(v1 + v2 - 2 * lA * lB * coseno);

            return resultado;
        }
        
    
        static void Main(string[] args)
        {

            double ladoA, ladoB, valor1, valor2, angulo, coseno, resultado, radianes;
            string linea;

            Console.WriteLine("Ingresa el 1er lado del triángulo");
            linea = Console.ReadLine();
            ladoA = double.Parse(linea);
            Console.WriteLine("Ingresa el 2do lado del triángulo");
            linea = Console.ReadLine();
            ladoB = double.Parse(linea);
            Console.WriteLine("Ingresa el ángulo que dibujan ambos lados");
            linea = Console.ReadLine();
            angulo = double.Parse(linea);
                                 
            resultado = potencia(ladoA, ladoB, angulo);

            Console.WriteLine("El tercer lado de tu triángulo mide: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
                       

        }
    }
}
