using System;

namespace produtos
{
    class Produtos
    {
        public string Nome { get; private set; } = "";
        public double Preco;
        public int Quantidade;

        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double valorTotalEmEstoque()
        {
            return (Preco * Quantidade);
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
            return Nome + 
                   ", R$ " 
                   + Preco 
                   + ", " 
                   + Quantidade 
                   + " unidades, Total: R$ " 
                   + valorTotalEmEstoque();
        }
    }
}
