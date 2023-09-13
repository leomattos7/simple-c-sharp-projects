using produtos;
using System;

namespace simple_c_sharp_projects
{
    class Program
    {
        static void exibeInformações(Produtos p1)
        {
            Console.WriteLine("Dados do produto: " + p1);
        }
        static void Main(string[] args)
        {
            /*TriangleArea areaTriangulo = new TriangleArea();
            areaTriangulo.calculaAreaTriangulo();
            calculaSalário informações = new calculaSalário();
            informações.calculaSalario*/
            int qtd;
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o preco ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Produtos p1 = new Produtos(nome, preco, quantidade);
            Console.WriteLine("Digite a quantidade de produtos que deseja adicionar: ");
            qtd = Convert.ToInt32(Console.ReadLine());
            p1.adicionarProdutos(quantidade);
            exibeInformações(p1);
            Console.WriteLine("Digite a quantidade de produtos que deseja remover");
            qtd = Convert.ToInt32(Console.ReadLine());
            p1.removerProdutos(quantidade);
            exibeInformações(p1);
        }
    }
}
