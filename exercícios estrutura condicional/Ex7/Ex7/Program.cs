using System;

namespace Ex7
{
    internal class Program {
        static void Main(string[] args) {
            double x, y;
            string resp;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0) {
               resp= "Origem.";
            }
            else if (x == 0) {
                resp = "Eixo X.";
            }
            else if (y == 0) {
                resp = "Eixo Y.";
            }
            else if (x > 0) {
                if (y > 0) {
                    resp = "Q1.";
                }
                else {
                    resp = "Q4.";
                }
            }
            else {
                if (y > 0) {
                    resp = "Q2.";
                }
                else {
                    resp = "Q3.";
                }
            }

            Console.WriteLine(resp);
        }
    }
}