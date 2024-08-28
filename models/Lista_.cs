using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_study_Csharp.models
{
    public class Lista_
    {
        public void ExibirLista()
        {
           List<string> listaString = new List<string>(); 
           listaString.Add("SP");
           listaString.Add("BA");
           listaString.Add("MG");
           listaString.Add("RJ");

           for(int contador = 0; contador < listaString.Count; contador++)
           {
            Console.WriteLine(listaString[contador]);
           }
        }
    }
}