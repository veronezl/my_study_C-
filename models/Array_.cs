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
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"O valor do elemento na posição {i} é {arr[i]}");
            } // Fechar o for
        } // Fechar o método
    } // Fechar a classe
} // Fechar o namespace
