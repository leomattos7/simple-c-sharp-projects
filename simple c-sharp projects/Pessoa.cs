namespace simple_c_sharp_projects
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public double salario;

        public Pessoa coletaDados()
        {
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            return this;
        }
        public void mostraDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);
        }   
    }
}
