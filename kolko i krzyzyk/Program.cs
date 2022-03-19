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
            int control = 0;
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
            Console.WriteLine("Kto zaczyna? O/X");
            char choice = ' ';
            char secondChoice = ' ';
            while (choice != 'X' & choice != 'O')
            {
                if (choice != ' ')
                {
                    Console.WriteLine("Wpisałeś zły znak. Wybierz między O/X");
                }
                choice = char.Parse(Console.ReadLine());
                secondChoice = ' ';
                if (choice == 'X')
                {
                    secondChoice = 'O';
                }
                else if (choice == 'O')
                {
                    secondChoice = 'X';
                }
            }
            while (true)
            {
                if (control % 2 == 0)
                {
                    Console.WriteLine("Wybierz wiersz i kolumnę w której chcesz umieścić swój {0}", choice);
                    int wiersz = int.Parse(Console.ReadLine());
                    int kolumna = int.Parse(Console.ReadLine());
                    tab[wiersz - 1, kolumna - 1] = choice;
                }
                else if (control % 2 != 0)
                {
                    Console.WriteLine("Wybierz wiersz i kolumnę w której chcesz umieścić swój {0}", secondChoice);
                    int wiersz = int.Parse(Console.ReadLine());
                    int kolumna = int.Parse(Console.ReadLine());
                    tab[wiersz - 1, kolumna - 1] = secondChoice;
                };
                Console.Clear();
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        Console.Write(tab[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                control++;
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (tab[0,j] == tab[0,i])
                        {
                            break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
