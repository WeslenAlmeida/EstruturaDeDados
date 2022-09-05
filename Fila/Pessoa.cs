using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa()
        {
            this.Proximo = null;
        }

        public override string ToString()
        {
            return $"\nDADOS DA PESSOA:\nNome: {Nome}\nTelefone: {Telefone}\nIdade: {Idade}";
        }

        //Método para ler os dados do livro inserido pelo usuário
        public Pessoa NewPessoa()
        {
            Pessoa pessoa = new Pessoa();  

            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();
            
            Console.Write("Digite o telefone: ");
            pessoa.Telefone = Console.ReadLine();

            Console.Write("Digite a idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            return pessoa;
        }
    }
}
