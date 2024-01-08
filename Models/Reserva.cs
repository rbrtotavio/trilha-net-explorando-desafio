namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // OK
            bool temCapacidade = hospedes.Count >= Suite.Capacidade;
            if (temCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // OK
                throw new Exception("Capacidade de hospedes excedida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // OK
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // OK
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: OK
            if (DiasReservados >= 10)
            {
                valor = decimal.Multiply(valor, 0.9M);
            }

            return valor;
        }
    }
}