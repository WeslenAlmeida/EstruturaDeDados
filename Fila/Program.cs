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
            Fila pilha = new Fila();
            Pessoa livro = new();
            do
            {
                Console.WriteLine("DIGITE AS OPÇÕES A SEGUIR:");
                Console.WriteLine("1) INSERIR PESSOA\n2) REMOVER PESSOA DA FILA\n3) IMPRIMIR FILA\n4) IMPRIMIR QUANTIDADE DE PESSOAS NA FILA" +
                    "\n5) LOCALIZAR PESSOA NA FILA\n0) SAIR\n");
                Console.Write("OPÇÃO: ");
                op = int.Parse(Console.ReadLine());
               
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Fim do programa!!!");
                        break;

                    case 1:
                        livro = livro.NewPessoa();
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
                        pilha.LengthFila();
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Digite o nome da pessoa: ");
                        pilha.FindPessoa(Console.ReadLine());
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            } while (op != 0);
                
        }
    }
}
