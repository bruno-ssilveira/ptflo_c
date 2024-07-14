using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("oi");

            // Entrada de dados
            string frase = Console.ReadLine();
            Console.WriteLine(frase);

            // Palavras separadas por espaço ' ' serão cortadas e inseridas no valor 0, 1, 2, 3.... do vetor.
            string[] vetor = Console.ReadLine().Split(' ');
            string palavra01 = vetor[0];
            string palavra02 = vetor[1];
            string palavra03 = vetor[2];

            Console.WriteLine(palavra01);
            Console.WriteLine(palavra02);
            Console.WriteLine(palavra03);

            // Para ler números inteiros é preciso explicitar que está lendo int com 'int.Parse()'
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);

            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(n2);

            char x = char.Parse(Console.ReadLine());
            Console.WriteLine(x);*/

            // Chamando função Maior
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Maior(num1, num2, num3);

            int resultMaior = Maior(num1, num2, num3);
            Console.WriteLine("O maior número é: " + resultMaior);

        }

        static int Maior(int um, int dois, int tres)
        {
            int maior;

            if(um > dois && um > tres)
            {
                maior = um;
                Console.WriteLine("O maior número é: " + um);
            } else if(dois > tres)
            {
                maior = dois;
                Console.WriteLine("O maior número é: " + dois);
            } else
            {
                maior = tres;
                Console.WriteLine("O maior número é: " + tres);
            }

            return maior;
        }
    }
}