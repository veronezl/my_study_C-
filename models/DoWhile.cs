namespace my_study_Csharp.models
{
    public class DoWhile
    {
        public void SomarNumeros()
        {
            int soma = 0;
            int numero = 0;

            do
            {
                Console.WriteLine("Digite um número ou zero para encerrar");

                // Verifica se a entrada é um número válido
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out numero))
                {
                    soma += numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                }

            } while (numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        }
    }
}
