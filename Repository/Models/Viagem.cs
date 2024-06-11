namespace Repository.Models
{
    public enum Cancelamento
    {
        S,  // Sim
        N   // Não
    }

    public class Viagem
    {
        public Passageiro Passageiro { get; set; }
        public Motorista Motorista { get; set; }
        public Veiculo Veiculo { get; set; }
        public string LocalOrigem { get; set; }
        public string LocalDestino { get; set; }
        public System.DateTime DtHoraInicio { get; set; }
        public System.DateTime? DtHoraFim { get; set; }
        public int? QtdePass { get; set; }
        public TipoPagamento FormaPagto { get; set; }
        public decimal? ValorPagto { get; set; }
        public Cancelamento CancelamMotorista { get; set; }
        public Cancelamento CancelamPassageiro { get; set; }
    }
}
