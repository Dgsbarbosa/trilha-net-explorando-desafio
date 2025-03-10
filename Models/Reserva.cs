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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            int capacidade = Suite.Capacidade;
            int hospede = hospedes.Count;


            if (capacidade >= hospede)
            {
                Hospedes = hospedes;
                //Console.WriteLine($"Capacidade: {Suite.Capacidade}");

                //Console.WriteLine($"Hospedes: {hospedes.Count}");

            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                try
                {
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("A quantidade de hospedes não pode ser maior que a capacidade da suite" + ex.Message);
                    
                }


            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;

        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            int hospedes = Hospedes.Count;
            return hospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            //Console.WriteLine(valor);

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10 )
            {
                valor *= 0.90m ;
            }

            return valor;
        }
    }
}