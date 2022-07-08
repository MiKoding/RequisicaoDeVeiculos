namespace RequisicaoDeVeiculos.Models
{
    public class Requisicao
    {
        public int Id { get; set; }
        public string Solicitante { get; set; }
        public string Local { get; set; }
                                            
        public string Veiculo { get; set; }

        public string SituacaoRequisicao { get; set; }
        public DateTime DataSaida { get; set; }   
        public DateTime DataEntrada { get; set; }
    }
}
