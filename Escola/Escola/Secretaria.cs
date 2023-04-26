using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public interface ISecretaria
    {
        void Add(Aluno a);
        void Remove(Aluno a);
        List<Aluno> List();
        void Edit(Aluno a, string nome, string matricula, Curso c, List<Nota> n);
    }

    public class Secretaria : ISecretaria
    {
        private List<Aluno> alunos;

        public Secretaria()
        {
            this.alunos = new List<Aluno>();
        }

        public void Add(Aluno a)
        {
            this.alunos.Add(a);
        }

        public void Remove(Aluno a)
        {
            this.alunos.Remove(a);
        }

        public List<Aluno> List()
        {
            return this.alunos;
        }

        public void Edit(Aluno a, string nome, string matricula, Curso c, List<Nota> n)
        {
            a.Nome = nome;
            a.Matricula = matricula;
            a.Curso = c;
            a.Notas = n;
        }

        // Método para calcular a média de um aluno
        public static double CalcularMedia(Aluno a)
        {
            double np1 = 0, np2 = 0, pim = 0;

            // Obtém as notas NP1, NP2 e PIM do aluno
            foreach (Nota nota in a.Notas)
            {
                switch (nota.Nome)
                {
                    case "NP1":
                        np1 = nota.Valor;
                        break;
                    case "NP2":
                        np2 = nota.Valor;
                        break;
                    case "PIM":
                        pim = nota.Valor;
                        break;
                }
            }

            // Calcula a média do aluno
            double media = (np1 * 4 + pim * 2 + np2 * 4) / 10;

            return media;
        }
    }
}