
using System;
namespace my_study_Csharp.models
{
    public class IfElse
    {
        static void VerificarNumero(int numero)
        {
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
    }
}