﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static double Sum(double a, double b)
        {
            //funkce spocita soucet cisel a,b
            double result = a + b;
            return result;
        }
        static double Difference(double a, double b)
        {
            //funkce spocita rozdil cisel a,b
            double result = a - b;
            return result;
        }
        static double Product(double a, double b)
        {
            //funkce spocita soucin cisel a,b
            double result = a * b;
            return result;
        }
        static double Quotient(double a, double b)
        {
            //funkce spocita podil cisel a,b
            double result = a / b;
            return result;
        }
        static double Pover(double a, double b)
        {
            //funkce spocita a na b
            double result = Math.Pow(a, b);
            return result;
        }
        static void Main(string[] args)
        {
            /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */
            double a, b, result;
            string matematicalOperation;
            bool successA, successB;
            successA = false;
            successB = false;
            result = 0;
            a = 0;
            b = 0;

            //program se zepta na matematickou operaci kterou chce uzivatel spocitat a ulozi odpoved do promene matematicalOperation
            Console.WriteLine("Vyber jakou matematickou operaci budes chtit pocitat +, -, *, /, na (mocnina)");
            matematicalOperation = Console.ReadLine();

            if (matematicalOperation == "+" || matematicalOperation == "-" || matematicalOperation == "*" || matematicalOperation == "/" || matematicalOperation == "na")
            {
                /*pokud uzivatel zada nekterou z vyse uvedenych operaci (matematicke operace na kterou jsou potreba zadat dve cisla), program se ho opakovane pta
                na cisla a, b dokud je nezada spravne a pak cilsa ulozi do promenych*/
                Console.WriteLine("zadej cisla na kterych se bude provadet vypocet. Vypocet bude vypadat jako a " + matematicalOperation + " b");
                while (successA == false)
                {
                    Console.WriteLine("Cislu a zatim nebyla prirazena zadna ciselna hodnota.Napis cislo a.");
                    successA = double.TryParse(Console.ReadLine(), out a);
                }
                while (successB == false)
                {
                    Console.WriteLine("Cislu b zatim nebyla prirazena zadna ciselna hodnota.Napis cislo b.");
                    successB = double.TryParse(Console.ReadLine(), out b);
                }
            }

            switch (matematicalOperation)
            {
                case "+":
                    //spocita soucet pomoci funkce Sum
                    result = Sum(a, b);
                    break;
                case "-":
                    //spocita rozdil pomoci funkce Sum
                    result = Difference(a, b);
                    break;
                case "*":
                    //spocita soucin pomoci funkce Sum
                    result = Product(a, b);
                    break;
                case "/":
                    //spocita podil pomoci funkce Sum
                    result = Quotient(a, b);
                    break;
                case "na":
                    result = Pover(a, b);
                    break;
            }
            Console.WriteLine("Výsledek je " + result.ToString());
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
