using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class ListaAluno
    {
        public Aluno HEAD { get; set; }
        public Aluno TAIL { get; set; }

        public ListaAluno()
        {
            HEAD = TAIL = null;
        }

        private bool Vazia()
        {
            if(HEAD == null && TAIL == null)
                return true;
            else
                return false;
        }

        public void Print()
        {
            if(Vazia())
                Console.WriteLine("Lista Vazia!");
            else
            {
                Aluno aux = HEAD;
                do
                {
                    Console.WriteLine(aux.ToString()+"\n");
                    aux = aux.Proximo;
                }while(aux != null);
                Console.WriteLine("Fim da Impressão!!!");
            }
            Console.WriteLine("\nPressione Enter para continuar!!\n");
        }

        public void Push(Aluno aux)
        {
            if (Vazia())
                HEAD = TAIL = aux;
            else
            {
                //Ordenação pelo nome do aluno
                //Inserção na TAIL
                if (aux.Nome.ToLower().CompareTo(TAIL.Nome.ToLower()) >= 0 )
                {
                    TAIL.Proximo = aux;
                    TAIL = aux;
                }
                else
                {
                    //Inserção na HEAD
                    if(aux.Nome.ToLower().CompareTo(HEAD.Nome.ToLower()) < 0)
                    {
                        aux.Proximo = HEAD;
                        HEAD = aux;
                    }
                    else
                    {
                        Aluno aux1, aux2;
                        aux1 = HEAD;
                        aux2 = HEAD;
                        do
                        {
                            //Percorre a lista procurando a posição para inserir
                            if (aux.Nome.ToLower().CompareTo(aux1.Nome.ToLower()) >= 0)
                            {
                                aux2 = aux1;
                                aux1 = aux1.Proximo;
                            }
                            //Insere o objeto na lista
                            else
                            {
                                aux2.Proximo = aux;
                                aux.Proximo = aux1;
                                break;
                            }
                        } while (true);
                    }
                }
            }
        }
        public void Length()
        {
            int cont = 0;
            if (Vazia())
                Console.WriteLine("Lista vazia!");
            else
            {
                Aluno aux = HEAD;

                do
                {
                    cont++;
                    aux = aux.Proximo;

                } while (aux != null);
                Console.WriteLine($"A Lista possui {cont} aluno(s)!");
            }
        }

        public void Pop(string nome)
        {

            if (Vazia())
                Console.WriteLine("impossivel remover pois a lista está vazia!");
            else
            {
                //Caso tenha só um nome na lista.
                if(nome == HEAD.Nome && nome == TAIL.Nome)
                {
                    HEAD = null;
                    TAIL = null;
                    Console.WriteLine("Aluno removido da lista com sucesso");
                }
                //Caso seja removido na head
                else if(nome == HEAD.Nome)
                {
                    HEAD = HEAD.Proximo;
                    Console.WriteLine("Aluno removido da lista com sucesso");
                }
                else
                {
                    Aluno aux = HEAD;
                    Aluno aux1 = HEAD.Proximo;
                    do
                    {
                        //Caso não tenha o nome na lista
                        if(aux1 == null)
                        {
                            Console.WriteLine("Não há esse nome na lista!!");
                            return;
                        }
                        //Caso encontre o nome na lista
                        if (nome == aux1.Nome)
                        {
                            aux.Proximo = aux1.Proximo;
                        }
                        //Pula para o próximo
                        aux = aux.Proximo;
                        aux1= aux1.Proximo;

                    } while (aux1 != null);
                    
                    Console.WriteLine("Aluno removido da lista com sucesso");
                       
                }
            }
        }
        public void Find(string nome)
        {
            int cont = 0;
            if (Vazia())
                Console.WriteLine("Lista vazia!");
            else
            {
                Aluno aux = HEAD;

                do
                {
                    if (nome == aux.Nome)
                        cont++;
                    aux = aux.Proximo;

                } while (aux != null);

                if (cont > 0)
                    Console.WriteLine($"{cont} pessoa(s) encontrado(s) com esse nome ({nome})");
                else
                    Console.WriteLine("Nenhuma pessoa encontrado com esse nome");
            }
        }
    }
}
