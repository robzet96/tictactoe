using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolko_i_krzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] tab = new char[3,3];            
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = '#';
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            gierka:
            Console.WriteLine("Wybierz X lub O");
            string wybor = Console.ReadLine();
            if (wybor == "x" | wybor == "X")
            {
                Console.WriteLine("Wybierz wiersz i kolumnę w której chcesz umieścić swój X");
                int wiersz = int.Parse(Console.ReadLine());
                int kolumna = int.Parse(Console.ReadLine());
                tab[wiersz, kolumna] = 'X';
            }
            else if (wybor == "o" | wybor == "O")
            {
                Console.WriteLine("Wybierz wiersz i kolumnę w której chcesz umieścić swój O");
                int wiersz = int.Parse(Console.ReadLine());
                int kolumna = int.Parse(Console.ReadLine());
                tab[wiersz, kolumna] = 'O';
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
            goto gierka;
            Console.ReadKey();
        }
    }
}
