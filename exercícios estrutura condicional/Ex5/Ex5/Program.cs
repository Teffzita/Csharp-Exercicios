using System;

namespace Ex5
{
    internal class Program {
        static void Main(string[] args) {
            int cod, qtd;
            double total;

            Console.Write("Digite o código do produto: ");
            cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            qtd = int.Parse(Console.ReadLine());

            if (cod == 1) {
                total = qtd * 4;
            }
            else if (cod == 2) {
                total = qtd * 4.5;
            }
            else if (cod == 3) {
                total = qtd * 5;
            }
            else if (cod == 4) {
                total = qtd * 2;
            }
            else {
                total = qtd * 1.5;
            }

            Console.WriteLine("Total: R$" + total.ToString("F2"));
        }
    }
}