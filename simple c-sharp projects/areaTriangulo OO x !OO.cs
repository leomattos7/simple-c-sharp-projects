using System;
    
namespace Calculator
{
    class Program
    {
        static Triangulo getLados(Triangulo t)
        {
            t.A = Convert.ToDouble(Console.ReadLine());
            t.B = Convert.ToDouble(Console.ReadLine());
            t.C = Convert.ToDouble(Console.ReadLine());
            return t;
        }
        static double calculaArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo();
            Console.WriteLine("Digite os lados do triângulo A: ");
            t1 = getLados(t1);
            Console.WriteLine("Digite os lados do triângulo B: ");
            t2 = getLados(t2);
            double area1 = calculaArea(t1.A, t1.B, t1.C);
            Console.WriteLine("Area t1 = " +area1);
            double area2 = calculaArea(t2.A, t2.B, t2.C);
            Console.WriteLine("Area t2 = " +area2);
            if (area1 > area2)
            {
                Console.WriteLine("Triângulo A tem a maior área.");
            }
            else
            {
                Console.WriteLine("Triângulo B tem a maior área.");
            }
        }
    }
}
