using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_study_Csharp.models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper(); // toUpper retorma todas as letras em maísculo 
            }

            set
            {

                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;

            }

        } // get => pega um valor / set => adiciona um valor
        public int Idade { get; set; } // get => pega um valor / set => adiciona um valor

        public void Apresentar() // Método ou Função
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos."); // (parâmetro ou argumento)
        }
    }
}