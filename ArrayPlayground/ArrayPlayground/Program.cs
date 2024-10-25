using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.
            int[] array = { 2, 6, 3, 7, 5 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            Console.WriteLine("Vypsani pomoci for");
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Vypsani pomoci foreach");
            foreach (int number in array)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum;
            sum = 0;

            for(int i = 0;i < array.Length;i++) 
            { 
                sum += array[i];
            }
            Console.WriteLine("Soucet prvku je " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            double average;

            average = (double)sum / array.Length;
            Console.WriteLine("Prumer je " + average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max;
            max = array[0];
            
            for(int i = 1; i < array.Length;i++) 
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Maximum je " + max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min;
            min = array[0];

            for(int i = 1; i < array.Length;i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Minimum je " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index, numberToFind;
            numberToFind = int.Parse(Console.ReadLine());
            index = -1;
            
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] == numberToFind)
                {
                    index = i;
                    Console.WriteLine("Cislo nalezeno na indexu " + index);
                }
            }

            if (index == -1) 
            {
                Console.WriteLine("Toto cislo v poli neni");
            }

            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
            Random rng = new Random();

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
