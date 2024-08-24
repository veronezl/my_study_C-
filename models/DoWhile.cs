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
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            }while(numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        }
    }
}