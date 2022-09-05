using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
        public Aluno Proximo { get; set; }

        public Aluno(int ra, string nome, int idade, string curso)
        {
            this.RA = ra;
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
            this.Proximo = null; 
        }

        public override string ToString()
        {
            return $"\nDados do aluno:\nRa = {RA}\nNome: {Nome}\nIdade: {Idade}\nCurso: {Curso}\n";
        }
    }
}
