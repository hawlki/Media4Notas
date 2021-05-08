using System;

namespace media4notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("        Media 4 notas        ");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite as 4 notas a seguir:");

            Console.Write("Primeira nota: ");
            bool nota1Valido = double.TryParse(Console.ReadLine(), out double nota1);
            Console.Write("Segunda nota: ");
            bool nota2Valido = double.TryParse(Console.ReadLine(), out double nota2);
            Console.Write("Terceira nota: ");
            bool nota3Valido = double.TryParse(Console.ReadLine(), out double nota3);
            Console.Write("Quarta nota: ");
            bool nota4Valido = double.TryParse(Console.ReadLine(), out double nota4);
            Console.WriteLine();

            if(!nota1Valido || !nota2Valido || !nota3Valido || !nota4Valido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite somente números");
                Console.ResetColor();
                Environment.Exit(1);
            }

            if(nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 ||
               nota3 < 0 || nota3 > 10 || nota4 < 0 || nota4 > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Favor digitar números entre 0 e 10");
            }
            else
            {
                Double media = (nota1 + nota2 + nota3 + nota4) / 4;

                if(media < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sua média é {media:N1}");
                    Console.WriteLine("Situação: reprovado");
                }
                else if(media >=5 && media <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Sua média é {media:N1}");
                    Console.WriteLine("Situação: recuperação");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Sua média é {media:N1}");
                    Console.WriteLine("Situação: aprovado");
                }
            }
            
            Console.ResetColor();
        }
    }
}
