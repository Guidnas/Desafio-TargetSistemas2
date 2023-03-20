using System;

/*
 * 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
 * (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número,
 * ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.



IMPORTANTE:

Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
Usado a sequencia de acordo com o exemplo.
*/

class Program
{
    static void Main(string[] args)
    {
        int num, a = 0, b = 1, c = 0;
        bool pertence = false;

        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());

        
        if (num == 0 || num == 1)
        {
            pertence = true;
        }
        else
        {
            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;

                if (c == num)
                {
                    pertence = true;
                    break;
                }
            }
        }

        if (pertence)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci", num);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci", num);
        }

        Console.ReadKey();
    }
}
