﻿using System;

namespace Ex8
{
    internal class Program {
        static void Main(string[] args) {
            double salario, imposto;

            Console.Write("Digite o salário: ");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 2000) {
                imposto = 0;
            }
            else if (salario <= 3000) {
                imposto = (salario - 2000) * 0.08;
            }
            else if(salario <= 4500) {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0) {
                Console.WriteLine("Isento.");
            }
            else {
                Console.WriteLine("R$ " +imposto.ToString("F2"));
            }
        }
    }
}