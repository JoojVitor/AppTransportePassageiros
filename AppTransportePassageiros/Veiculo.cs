using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportePassageiros
{
    enum Combustivel
    {
        G,  // Gasolina
        A,  // Alcool
        D,  // Diesel
        F   // Flex
    }

    class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabric { get; set; }
        public int CapacidadePass { get; set; }
        public string Cor { get; set; }
        public string TipoCombust { get; set; }
        public int? PotenciaMotor { get; set; }
    }
}
