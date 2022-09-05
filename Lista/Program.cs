using System;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //ListaAluno lista = new ListaAluno();

            //lista.Push(new Aluno(123, "Weslen", 35, "ADS"));
            //lista.Push(new Aluno(123, "Weslen", 35, "ADS"));
            //lista.Push(new Aluno(456, "Davi", 35, "ADM"));
            //lista.Push(new Aluno(789, "Pedro", 35, "ENG MAN"));
            //lista.Push(new Aluno(1011, "Ana", 35, "ENG MEC"));

            //lista.Print();
            //lista.Length();
            //lista.Find("Weslen");
            //lista.Pop("Pedro");
            //lista.Print();
        }
        static void Menu()
        {
            int op;
            ListaAluno lista = new();
            do
            {
                Console.WriteLine("DIGITE AS OPÇÕES A SEGUIR:");
                Console.WriteLine("1) INSERIR ALUNO\n2) REMOVER ALUNO DA LISTA\n3) IMPRIMIR LISTA\n4) IMPRIMIR QUANTIDADE DE ALUNOS NA LISTA" +
                    "\n5) LOCALIZAR ALUNO NA LISTA\n0) SAIR\n");
                Console.Write("OPÇÃO: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Fim do programa!!!");
                        break;

                    case 1:
                        Console.Write("Digite o RA:");
                        int ra = int.Parse(Console.ReadLine());

                        Console.Write("Digite seu nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite sua idade:");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Digite seu curso: ");
                        string curso = Console.ReadLine();

                        lista.Push(new Aluno(ra, nome, idade, curso));
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Digite seu nome do aluno que deseja remover: ");
                        string nomeRemov = Console.ReadLine();
                        lista.Pop(nomeRemov);
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                    case 3:
                        lista.Print();
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                    case 4:
                        lista.Length();
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Digite o nome da pessoa: ");
                        lista.Find(Console.ReadLine());
                        Console.WriteLine("\nTecle Enter para continuar!");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
            } while (op != 0);

        }
    }
}

