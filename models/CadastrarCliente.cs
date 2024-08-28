namespace my_study_Csharp.models
{
    public class CadastrarCliente
    {
        public void Cadastrar()
        {
            string opcao = string.Empty;  // Inicializando opcao com uma string vazia
            bool exibirMenu = true;

            while(exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine() ?? string.Empty; // Verificando se a entrada é nula

                switch(opcao)
                {
                    case "1":
                    Console.WriteLine("Cadastro de cliente");
                    break;

                    case "2":
                    Console.WriteLine("Buscar cliente");
                    break;

                    case "3":
                    Console.WriteLine("Apagar cliente");
                    break;

                    case "4":
                    Console.WriteLine("Encerrando...");
                    exibirMenu = false;
                    break;

                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }
            }
        }
    }
}
