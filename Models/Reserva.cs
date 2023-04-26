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
            int NumeroDeHospedes = hospedes.Count;
            int CapacidadeSuite = Suite.Capacidade;

            if (CapacidadeSuite >= NumeroDeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {

                throw new System.ArgumentOutOfRangeException("Número de hóspedes supera a capacidade da suite escolhida");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int NumeroDeHospedes = Hospedes.Count;

            return NumeroDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valorDiariaSuite = Suite.ValorDiaria;
            int diasReservados = DiasReservados;

            decimal valor = valorDiariaSuite * diasReservados;

            if (diasReservados >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}