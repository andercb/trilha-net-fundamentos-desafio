namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // ok - TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // ok - *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // ok - Pedir para o usuário digitar a placa e armazenar na variável placa
            // ok - *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();
            //Console.Write(placa);

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 
                
                // ok - TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                // ok - TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // ok - *IMPLEMENTE AQUI*
                valorTotal = (precoInicial + (precoPorHora * horas));


                // ok - TODO: Remover a placa digitada da lista de veículos
                // ok - *IMPLEMENTE AQUI*
                veiculos.Remove(placa);


                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // ok -  TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // ok - *IMPLEMENTE AQUI*
                int cont = 0;
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"Veiculo {cont + 1} - Placa {item}");
                    cont++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
