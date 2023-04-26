using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Aluno : IComparable<Aluno>
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public Curso Curso { get; set; }
        public List<Nota> Notas { get; set; }

        // Implementação do método CompareTo da interface IComparable<Aluno>
        public int CompareTo(Aluno other)
        {
            return this.Nome.CompareTo(other.Nome);
        }
    }


}
