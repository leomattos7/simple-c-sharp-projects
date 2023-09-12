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
            Produtos p1 = new Produtos();
            int quantidade;
            p1 = p1.cadastrarProdutos();
            Console.WriteLine("Digite a quantidade de produtos que deseja adicionar: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            p1.adicionarProdutos(quantidade);
            exibeInformações(p1);
            Console.WriteLine("Digite a quantidade de produtos que deseja remover");
            quantidade = Convert.ToInt32(Console.ReadLine());
            p1.removerProdutos(quantidade);
            exibeInformações(p1);
        }
    }
}
