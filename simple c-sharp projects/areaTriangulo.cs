using System;

namespace simple_c_sharp_projects
{
    class TriangleArea
    {
        public void calculaAreaTriangulo()
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo();
            Console.WriteLine("Digite os lados do triângulo A: ");
            t1 = t1.getLados();
            Console.WriteLine("Digite os lados do triângulo B: ");
            t2 = t2.getLados();
            double area1 = t1.area();
            Console.WriteLine("Area t1 = " + area1);
            double area2 = t2.area();
            Console.WriteLine("Area t2 = " + area2);
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
