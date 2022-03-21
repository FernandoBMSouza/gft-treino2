using System;
using System.Globalization;

namespace Project04
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o valor da compra: R$");
            double valorSemDesconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = valorSemDesconto;

            double desconto = 0;

            if(valor >= 300)
            {
                desconto = 0.01;
            }

            while (valor > 300 && desconto < 0.2)
            {
                valor -= 100;
                desconto += 0.01;
            }

            double valorFinal = valorSemDesconto - (valorSemDesconto * desconto);

            System.Console.WriteLine($"R${valorSemDesconto} - {desconto * 100}% - R${valorFinal}");
        }
    }
}