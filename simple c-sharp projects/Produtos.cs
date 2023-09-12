using System;

namespace produtos
{
    class Produtos
    {
        public string Nome { get; private set; } = "";
        public double Preco;
        public int Quantidade;

        public double valorTotalEmEstoque()
        {
            return (Preco * Quantidade);
        }
        public Produtos cadastrarProdutos()
        {
            Console.WriteLine("Digite o nome do produto");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o preco ");
            Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade");
            Quantidade = Convert.ToInt32(Console.ReadLine());
            return this;
        }
        public void adicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void removerProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", R$ " + Preco + ", " + Quantidade + " unidades, Total: R$ " + valorTotalEmEstoque();
        }
    }
}
