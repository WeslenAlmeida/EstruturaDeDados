using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados
{
    internal class Fila
    {
        public Pessoa HEAD { get; set; }
        public Pessoa TAIL { get; set; }

        public Fila()
        {
            this.HEAD = null;
            this.TAIL = null;
        }

        
        public void Push(Pessoa aux)
        {
            if (Vazia())
            {
                this.HEAD = aux;
                this.TAIL = aux;
            }
            else
            {
                TAIL.Proximo = aux;
                TAIL = aux;

            }
            Console.WriteLine("Inserido com sucesso!");
        }

        private bool Vazia()
        {
            if (this.HEAD == null && this.TAIL == null)
                return true;
            else
                return false;   
        }

        public void Print()
        {
            if(Vazia())
                Console.WriteLine("Fila vazia!");
            else
            {
                Pessoa aux = HEAD;

                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;

                }while (aux != null);
                

            }
        }

        public void Pop()
        {
            if (Vazia())
                Console.WriteLine("Fila Vazia");
            else
            {
                HEAD = HEAD.Proximo;
                if (HEAD == null)
                    TAIL = null;
                Console.WriteLine("Removido com sucesso!");
            }
                
        }

        public void LengthFila()
        {
            int cont = 0;
            if (Vazia())
                Console.WriteLine("Fila vazia!");
            else
            {
                Pessoa aux = HEAD;

                do
                {
                    cont++;
                    aux = aux.Proximo;

                } while (aux != null);
                Console.WriteLine($"A fila possui {cont} pessoa(s)!");
            }
        }

        public void FindPessoa(string nome)
        {
            int cont = 0;
            if (Vazia())
                Console.WriteLine("Fila vazia!");
            else
            {
                Pessoa aux = HEAD;

                do
                {
                    if(nome == aux.Nome)
                        cont++;
                    aux = aux.Proximo;

                } while (aux != null);

                if(cont > 0)    
                    Console.WriteLine($"{cont} pessoa(s) encontrado(s) com esse nome {aux.Nome}");
                else
                    Console.WriteLine("Nenhuma pessoa encontrado com esse nome");
            }
        }
    }
}
