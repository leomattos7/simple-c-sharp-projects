namespace simple_c_sharp_projects
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public Triangulo getLados()
        {
            Console.WriteLine("Digite o lado A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o lado B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o lado C: ");
            C = Convert.ToDouble(Console.ReadLine());
            return this;
        }
        public double area()
        {
            double p = (A + B + C) / 2;
            double area = System.Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }
    }
}
