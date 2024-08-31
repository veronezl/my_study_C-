using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_study_Csharp.models // Namespace começa aqui
{
    public class Array_
    {
        public void ArrayInt()
        {
            int[] arr = new int[4] { 10, 20, 30, 40 }; 

            Console.WriteLine("Percorrendo o Array com FOR");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"O valor do elemento na posição {i} é {arr[i]}");
            } // Fechar o for

            Console.WriteLine("\nPercorrendo o Array com FOREACH\n");

            int contadorForeach = 0;
            foreach(int valor in arr)
            {
                Console.WriteLine($"Posição N {contadorForeach} - {valor}");
                contadorForeach++;
            }
        } // Fechar o método
    } // Fechar a classe
} // Fechar o namespace
