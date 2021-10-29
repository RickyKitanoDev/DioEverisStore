using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioEverisStore.Domain
{
    public class Perfil
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Regra { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }



    }
}
