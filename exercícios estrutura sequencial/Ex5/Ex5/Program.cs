using System;

namespace Ex5
{
    internal class Program {
        static void Main(string[] args) {
            double cd1, cd2, np1, np2, vl1, vl2, total;

            Console.Write("Digite o codigo da peça 1: ");
            cd1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade da peça 1: ");
            np1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da peça 1: R$");
            vl1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o codigo da peça 2: ");
            cd2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade da peça 2: ");
            np2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da peça 2: R$");
            vl2 = double.Parse(Console.ReadLine());

            total=(np1*vl1) + (np2*vl2);

            Console.WriteLine("Valor total a pagar: R$" + total.ToString("F2"));
        }
    }
}