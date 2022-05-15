using System;
using System.Collections.Generic;

namespace Escola.API.Models
{
    public partial class Nota
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = null!;
        public decimal ValorNota { get; set; }
        public int AlunoId { get; set; }

        public virtual Aluno Aluno { get; set; } = null!;
    }
}
