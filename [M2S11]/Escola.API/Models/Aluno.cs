using System;
using System.Collections.Generic;

namespace Escola.API.Models
{
    public partial class Aluno
    {
        public Aluno()
        {
            Nota = new HashSet<Nota>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Ano { get; set; } = null!;

        public virtual ICollection<Nota> Nota { get; set; }
    }
}
