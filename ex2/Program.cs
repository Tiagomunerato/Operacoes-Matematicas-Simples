using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma, subtracao, multiplicacao;
            double divisao;

            Console.Write("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            //num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            subtracao = num1 - num2;
            multiplicacao = num1 * num2;
            divisao = (double) num1 / num2;

            Console.WriteLine("Valor da soma => " + soma);
            Console.WriteLine("Valor da subtração => " + subtracao);
            Console.WriteLine("Valor da multiplicação => " + multiplicacao);
            Console.WriteLine("Valor da divisao => " + divisao);
            Console.ReadKey();


        }
    }
}
