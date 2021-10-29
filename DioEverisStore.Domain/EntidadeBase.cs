using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioEverisStore.Domain
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        protected bool Ativo { get; set; }
    }
}
