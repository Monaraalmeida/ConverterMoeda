using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices;

public class Program
{
    enum Moeda
    {
        Dolar,
        Euro,
        Iene,
        Libra,
    }

    public static void Main(string[] args)
    {

        double resultado = 0;
        //resultado.Show(resultado.ToString("C"));


        //string resultadoFinal2 = resultadoFinal.ToString("F3");


        string boasVindas = "Bem vindo ao processo de conversão de moedas.";
        Console.WriteLine(boasVindas);

        Thread.Sleep(2000);

        Dictionary<string, double> moedasRegistradas = new Dictionary<string, double>();
        moedasRegistradas["Dolar"] = 4.50;
        moedasRegistradas["Euro"] = 6.20;
        moedasRegistradas["Iene"] = 0.052;
        moedasRegistradas["Libra"] = 6.95;


        foreach (KeyValuePair<string, double> par in moedasRegistradas)
        {
            string chave = par.Key;
            double valor = par.Value;
            Console.WriteLine($"\nA cotação do {chave} é $: {valor}");
        }

        Thread.Sleep(2000);

        Converter();


        void Converter()
        {
            Console.WriteLine("\nTecle Enter para realizar a conversão.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nDigite o valor que em REAL que deseja converter: ");
            string valorDigitado = Console.ReadLine()!;
            double valorInserido = double.Parse(valorDigitado);

            Console.Clear();

            Console.WriteLine("Para qual moeda você deseja converter: ");

            Console.WriteLine($" Digite 0: Dolar");
            Console.WriteLine($" Digite 1: Euro");
            Console.WriteLine($" Digite 2: Iene");
            Console.WriteLine($" Digite 3: Libra");

            Console.Write("Digite sua opção: ");
            string moeda = Console.ReadLine()!;
            int moedaSelecionada = int.Parse(moeda);

            Thread.Sleep(2000);

            Console.WriteLine("\nProcessando a conversão.");

            Thread.Sleep(1000);


            switch (moedaSelecionada)
            {

                case 0:
                    resultado = valorInserido / moedasRegistradas["Dolar"];
                    Console.WriteLine("O valor da conversão é: $ " + resultado.ToString("N3") + ".");
                    break;

                case 1:
                    resultado = valorInserido / moedasRegistradas["Euro"];
                    Console.WriteLine("O valor da conversão é: € " + resultado.ToString("N3") + ".");
                    break;

                case 2:
                    resultado = valorInserido / moedasRegistradas["Iene"];
                    Console.WriteLine("O valor da conversão é: ¥ " + resultado.ToString("N3") + ".");
                    break;

                case 3:
                    resultado = valorInserido / moedasRegistradas["Libra"];
                    Console.WriteLine("O valor da conversão é: £ " + resultado.ToString("N3") + ".");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("\nDeseja retornar ao Menu e fazer uma nova conversão?");
            Thread.Sleep(500);
            Console.WriteLine("1: SIM");
            Thread.Sleep(500);
            Console.WriteLine("2: NÃO");
            Thread.Sleep(500);

            Console.Write("\nDigite sua opção: ");
            string opcao = Console.ReadLine()!;
            int opcaoMenu = int.Parse(opcao);

            if (opcaoMenu == 1)
            {
                Converter();
            }

            else
            {
                Console.WriteLine("\nTecle ENTER para sair.");
            }
        }
    }
}