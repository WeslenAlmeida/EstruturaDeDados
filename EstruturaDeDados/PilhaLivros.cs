using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    internal class PilhaLivros
    {
        public Livro Topo { get; set; }

        public PilhaLivros()
        {
            this.Topo = null;
            Console.WriteLine("Pilha criada com sucesso!!!");
        }

        //Insere o objeto no topo da pilha
        public void Push(Livro aux)
        {
            if (Vazia())
                this .Topo = aux;
            else
            {
                aux.Anterior = Topo;
                this.Topo = aux;
            }
            Console.WriteLine("Livro inserido na pilha com sucesso!");
        }

        //Verifica se a pilha está vazia
        private bool Vazia()
        {
            if (this.Topo == null)
                return true;
            else
                return false;   
        }

        //Mostra na tela os objetos existentes na pilha
        public void Print()
        {
            if(Vazia())
                Console.WriteLine("Pilha vazia!");
            else
            {
                Livro aux = Topo;

                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;

                }while (aux != null);
                

            }
        }

        //Remove o objeto no topo da  pilha 
        public void Pop()
        {
            if (Vazia())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("Livro no topo da pilha removido com sucesso!");
            }
                
        }

        //Mostra quantos objetos tem na pilha
        public void LengthPilha()
        {
            int cont = 0;
            if (Vazia())
                Console.WriteLine("Pilha vazia!");
            else
            {
                Livro aux = Topo;

                do
                {
                    aux = aux.Anterior;
                    cont++;

                } while (aux != null);
                Console.WriteLine($"A pilha de livros possui {cont} livro(s)!");
            }
        }

        //Procura um livro especifico solicitado usuário
        public void FindLivro(string titulo)
        {
            int cont = 0;
            if (Vazia())
                Console.WriteLine("Pilha vazia!");
            else
            {
                Livro aux = Topo;

                do
                {
                    if(titulo == aux.Titulo)
                        cont++;
                    aux = aux.Anterior;

                } while (aux != null);

                if(cont > 0)    
                    Console.WriteLine($"{cont} livro(s) encontrados com esse título");
                else
                    Console.WriteLine("Nenhum livro encontrado com esse título");
            }
        }
    }
}
