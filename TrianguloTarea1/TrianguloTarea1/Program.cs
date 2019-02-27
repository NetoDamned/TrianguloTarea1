using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloTarea1
{
    class Program
    {
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

            valor1 = Math.Pow(ladoA, 2);
            valor2 = Math.Pow(ladoB, 2);

            radianes = (Math.PI / 180) * angulo;
            coseno = Math.Cos(radianes);

            resultado = valor1 + valor2 - 2 * ladoA * ladoB * coseno;

            Console.WriteLine("El tercer lado de tu triángulo mide: ");
            Console.WriteLine(Math.Sqrt(resultado));
            Console.ReadKey();
                       

        }
    }
}
