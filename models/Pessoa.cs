using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_study_Csharp.models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {

        }
        private string _nome;
        private int _idade;

        public string Nome
        {
            get   // Poderiamos resumir o código em: get => _nome.ToUpper(); 
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

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }

                _idade = value;

            } 
        } // get => pega um valor / set => adiciona um valor

        public void Apresentar() // Método ou Função
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos."); // (parâmetro ou argumento)
        }
    }
}