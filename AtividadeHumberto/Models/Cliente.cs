using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeHumberto.Models
{
    public class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string estado { get; set; }
    }
}
