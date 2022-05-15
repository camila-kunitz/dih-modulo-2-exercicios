using System;
using System.Collections.Generic;

namespace Loja.API.Models
{
    public partial class Fabricante
    {
        public int Id { get; set; }
        public string Cnpj { get; set; } = null!;
        public string RazaoSocial { get; set; } = null!;

        public virtual Produto Produto { get; set; } = null!;
    }
}
