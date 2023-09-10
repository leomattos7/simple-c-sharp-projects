using System;

namespace simple_c_sharp_projects
{
    class calculaSalário
    {
        public void calculaSalario()
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Inserir dados pessoa 1 ");
            p1 = p1.coletaDados();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Inserir dados pessoa 2 ");
            p2 = p2.coletaDados();
            double media = (p1.salario + p2.salario) / 2;
            Console.WriteLine("\nDados pessoa 1");
            p1.mostraDados();
            Console.WriteLine("\nDados pessoa 2");
            p2.mostraDados();
            Console.WriteLine("\nMédia salarial: " + media);
        }
    }
}
