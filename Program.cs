﻿// See https://aka.ms/new-console-template for more information

using my_study_Csharp.models;
using System;

class Program
{
    static void Main(string[] args)
    {
       
        //Exemplo de uso da classe Pessoa
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João";
        pessoa1.Idade = 25;
        pessoa1.Apresentar();

        Console.WriteLine(pessoa1.Nome);
        Console.WriteLine(pessoa1.Idade);

        Console.WriteLine();

        //Exemplo de uso da classe Aluno    
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual);
        
        Console.WriteLine();

        Calculadora calculadora = new Calculadora();
        calculadora.Somar(10,3);
        calculadora.Subtrair(10,3);
        calculadora.Multiplicar(10,3);
        calculadora.Dividir(10,3);

        Console.WriteLine();

        For_ for_ = new For_(); // Criando um objeto da classee For_
        for_.ImprimirTabuada(); // Chamando um método da classe For_

        Console.WriteLine();

        While_ while_ = new While_();
        while_.ExecutarTabuada();

        Console.WriteLine();

        DoWhile dowhile = new DoWhile();
        dowhile.SomarNumeros();

        Console.WriteLine();

        Array_ array_ = new Array_(); // Cria uma instância da classe Array_
        array_.ArrayInt();            // Chama o método ArrayInt na instância criada

    }
}