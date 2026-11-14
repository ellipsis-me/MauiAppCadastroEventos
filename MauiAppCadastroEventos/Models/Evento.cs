namespace MauiAppCadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int PeriodoEvento
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }

        public Double ValorParticipante
        {
            get
            {
                double valor_total = NumeroParticipantes * CustoPorParticipante;
                return valor_total;
            }
        }
    }
}
