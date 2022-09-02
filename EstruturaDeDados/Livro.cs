using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { get; set; }

        public Livro()
        {
            this.Anterior = null;
        }

        public override string ToString()
        {
            return $"\nDADOS DO LIVRO:\nTitulo: {Titulo}\nAutor: {Autor}\nISBN: {ISBN}";
        }

        //Método para ler os dados do livro inserido pelo usuário
        public Livro NewLivro()
        {
            Livro livro = new Livro();  

            Console.Write("Digite o título do livro: ");
            livro.Titulo = Console.ReadLine();
            
            Console.Write("Digite o Autor do livro: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Digite o ISBN do livro: ");
            livro.ISBN = int.Parse(Console.ReadLine());

            return livro;
        }
    }
}
