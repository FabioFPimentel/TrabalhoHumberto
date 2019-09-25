using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeHumberto.Models;

namespace AtividadeHumberto.ICliente
{
    public interface InterCliente
    {
            void Insert(Cliente cCliente);
            void Update(Cliente cCliente);
            void Delete(int idCliente);
            Cliente Create(int idCliente);
    }

}
