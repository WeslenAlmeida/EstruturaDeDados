using System;

namespace EstruturaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        //Menu para interagir com o usuário
        static void Menu()
        {
            int op;
            PilhaLivros pilha = new PilhaLivros();
            Livro livro = new();
            do
            {
                Console.WriteLine("DIGITE AS OPÇÕES A SEGUIR:");
                Console.WriteLine("1) INSERIR LIVRO\n2) REMOVER LIVRO DA PILHA\n3) IMPRIMIR PILHA\n4) IMPRIMIR QUANTIDADE DE LIVROS NA PILHA" +
                    "\n5) LOCALIZAR LIVRO NA PILHA\n0) SAIR\n");
                Console.Write("OPÇÃO: ");
                op = int.Parse(Console.ReadLine());
               
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Fim do programa!!!");
                        break;

                    case 1:
                        livro = livro.NewLivro();
                        pilha.Push(livro);
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                    case 2:
                        pilha.Pop();
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                    case 3:
                        pilha.Print();
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                    case 4:
                        pilha.LengthPilha();
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Digite o título do livro: ");
                        pilha.FindLivro(Console.ReadLine());
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            } while (op != 0);
                
        }
    }
}
