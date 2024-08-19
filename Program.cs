// See https://aka.ms/new-console-template for more information

using my_study_Csharp.models;


Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 25;
pessoa1.Apresentar();

Console.WriteLine(pessoa1.Nome);
Console.WriteLine(pessoa1.Idade);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);