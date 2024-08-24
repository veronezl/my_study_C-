namespace my_study_Csharp.models
{
    public class For_
    {
        public void ImprimirTabuada()
        {
            int numero = 10;

            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
