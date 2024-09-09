using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_study_Csharp.models
{
    public class Pilhas
    {
        // Método para gerenciar pilhas
        public void GerenciarPilha()
        {
            // Criação da pilha usando o tipo genérico Stack<T>
            Stack<string> pilha = new Stack<string>();

            // Adicionando elementos à pilha (Push)
            pilha.Push("Elemento 1");
            pilha.Push("Elemento 2");
            pilha.Push("Elemento 3");

             // Mostrando elementos da pilha
            Console.WriteLine($"\nElementos da pilha:\n");
            foreach (string item in pilha)
            {
                Console.WriteLine(item);
            }
        }
    }
}