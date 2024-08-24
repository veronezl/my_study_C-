namespace my_study_Csharp.models
{
    public class While_
    {
        public void ExecutarTabuada()
        {
            int numero = 10;
            int i = 0;

            while(i <= 10)
            {
                Console.WriteLine($"{i + 1} Execução: {numero} x {i} = {numero * i}");
                i++;

                if(i == 6)
                {
                    break; // Finaliza o programa no i = 5
                }
            }
        }
    }
}