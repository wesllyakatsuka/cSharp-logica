﻿using System;
using System.Globalization;
namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double pisoSalarial, vendas, comissao, salario;

            nome = Console.ReadLine();
            pisoSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = vendas * 0.15;
            salario = pisoSalarial + comissao;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
/*
 * Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
 * Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, 
 * com duas casas decimais.

Entrada
O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, 
representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

Saída
Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

Exemplos de Entrada	            Exemplos de Saída
JOAO
500.00                             TOTAL = R$ 684.54
1230.30

Exemplos de Entrada	             Exemplos de Saída
PEDRO
700.00                             TOTAL = R$ 700.00
0.00


Exemplos de Entrada	             Exemplos de Saída
MANGOJATA                           TOTAL = R$ 1884.58
1700.00
1230.50                             

*/
