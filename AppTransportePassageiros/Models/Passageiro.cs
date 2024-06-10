using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Passageiro
    {
        public long Cpf { get; set; }
        public string CartaoCred { get; set; }
        public string BandeiraCartao { get; set; }
        public string CidadeOrig { get; set; }
    }
}
