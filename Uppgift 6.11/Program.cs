using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("       RITA KVADRAT");
        Console.WriteLine("Hur lång ska ena sidan vara?");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Vilket tecken vill du rita med?");
        char c = char.Parse(Console.ReadLine());
        Console.WriteLine("Hur stort mellan rum ska det vara?");
        int y = int.Parse(Console.ReadLine());
        RitaKvadrat(x, c, y);
        
    }

    static void RitaKvadrat(int sida, char c, int mellanrum)
    {
        for (int i = 0; i < sida; i++)
        {
            for (int j = 0; j < sida; j++)
            {
                Console.Write(c);
                for (int k = 0; k < mellanrum; k++)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            for (int a = 0; a < mellanrum; a++)
            {
                Console.WriteLine();
            }
        }
    }
}