using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    internal class Program
    {
        static char[,] CreateMyShipsBoard()
        {
            //vytvoří tabulku, ve které budou umístěny moje lodě
            char[,] myShipsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return myShipsBoard;
        }
        static char[,] CreateComputersShipsBoard()
        {
            //vytvoří tabulku, ve které budou umístěny lodě počítače
            char[,] computerShipsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return computerShipsBoard;
        }
        static char[,] CreateComputersShotsBoard()
        {
            //vytvoří tabulku, kam se budou zaznamenávat moje střeli
            char[,] myShotsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return myShotsBoard;
        }
        static char[,] CreateMyShotsBoard()
        {
            //vytvoří tabulku, kam se budou zaznamenávat střeli počítače
            char[,] computerShotsBoard = new char[10, 10] {
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
                {'-','-','-','-','-','-','-','-','-','-'},
            };
            return computerShotsBoard;
        }
        static void WriteBoard(char[,] board)
        {
            //vypíše zadanou herní tabulku do konzole 
            Console.WriteLine("X A B C D E F G H I J");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Introduction()
        {
            //vypíše na začátku pravidla
            Console.WriteLine("Hrou postupuj dle pokynů. Jména sloupců zadávej" +
                "malými písmeny. Pokud střílíš jsou zásahy značené písmenem X a trefy" +
                "mimo písmenem O");
        }
        static int ColumnNumber(string columnLetter)
        {
            //převede písmeno sloupce na číslo, které se dá použít jako index v poli
            int column;
            List<string> columns = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};
            column = columns.IndexOf(columnLetter);
            return column;
        }
        static char[,] MyShips(char[,] myShipsBoard)
        {
            //na každou loď zavolá funkci MyShipPosition, pomocí které hráč umístí svou loď
            Console.WriteLine("Nyní umísti jednu letadlovou loď (1*5)");
            myShipsBoard = MyShipPosition(myShipsBoard, 5, 'L');
            WriteBoard(myShipsBoard);
            Console.WriteLine("Nyní umísti jednu bitevní loď (1*4)");
            myShipsBoard = MyShipPosition(myShipsBoard, 4, 'B');
            WriteBoard(myShipsBoard);
            Console.WriteLine("Nyní umísti jeden křižník (1*3)");
            myShipsBoard = MyShipPosition(myShipsBoard, 3, 'K');
            WriteBoard(myShipsBoard);
            Console.WriteLine("Nyní umísti jednu ponorku (1*3)");
            myShipsBoard = MyShipPosition(myShipsBoard, 3, 'P');
            WriteBoard(myShipsBoard);
            Console.WriteLine("Nyní umísti jeden torpédoborec (1*2)");
            myShipsBoard = MyShipPosition(myShipsBoard, 2, 'T');
            WriteBoard(myShipsBoard);
            return myShipsBoard;  
        }
        static char[,] MyShipPosition(char[,] myShipsBoard,int lenghtOfShip, char tipeOfShip)
        {
            //funkce pomůže hráči umístit svou loď
            bool successRow, successColumn, successOrientation, successShip;
            int row, columnNumber, squareSucces;
            string orientation, columnLetter;
            successColumn = false;
            successRow = false;
            successOrientation = false;
            successShip = false;
            row = 0; 
            columnNumber = 0; 
            squareSucces = 0;
            //opakuje se umisťování lodi dokud ji hráč neumístí zprávně
            while(successShip == false)
            {
                //program se ptá na vertikální nebo horizontální umístění lodi, dokud není zadán validní směr
                Console.WriteLine("Jako první napiš jestli chceš loď umístit do řádku nebo do sloupce." +
                "Pokud do řádku napiš r, pokud do sloupce napiš s");
                orientation = Console.ReadLine();
                while (successOrientation == false)
                {
                    if (orientation == "r" || orientation == "s")
                    {
                        successOrientation = true;
                    }
                    else
                    {
                        Console.WriteLine("Toto neznačí žádnou orientaci lodě. Zadej prosím " +
                                "orientaci lodě znovu");
                        orientation = Console.ReadLine();
                    }
                }
                //program se ptá na začáteční pole lodi od kterého dál bude umístěna
                Console.WriteLine("Nyní napiš začáteční pole lodi. Pokud má být loď úmístěná do sloupce," +
                   "umístí se od tohoto pole dolů, jinak se úmístí od tohoto sloupce do prava. Jako " +
                   "první napiš číslo řádku, ve kterém bude začáteční pole.");
                //umístění lodě, pokud má být umístěna do řádku
                if(orientation == "r")
                {
                    //program se ptá na řádek do kterého bude umístěna loď, dokud nedostane validní odpověď
                    while(successRow == false)
                    {
                        successRow = int.TryParse(Console.ReadLine(), out row);
                        if (successRow == true)
                        {
                            if (row < 0 || row > 9)
                            {
                                successRow = false;
                                Console.WriteLine("Zatím nebylo napsáno žádné existující číslo" +
                                    " řádku. Zkus to znovu");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Zatím nebylo napsáno žádné existující číslo řádku." +
                                " Zkus to znovu");
                        }
                    }
                    //program se ptá na písmeno počátečního sloupce dokud není zadaný takový sloupec aby se tam loď vešla
                    Console.WriteLine("Nyní napiš písmeno sloupce ve kterém bude počáteční pole");
                    while(successColumn == false)
                    {
                        columnLetter = Console.ReadLine();
                        columnNumber = ColumnNumber(columnLetter);
                        if(columnNumber > -1 && columnNumber < 11 - lenghtOfShip)
                        {
                            successColumn = true;
                        }
                        else
                        {
                            Console.WriteLine("Buď neexistuje sloupec s tímto označením, nebo by" +
                                "se loď do tabulky nevešla kdyby v tomto sloupci začínala. Zkus" +
                                "zadat jiný sloupec.");
                        }
                    }
                    //program kontroluje, zda pokud bude loď umístěna podle obdržených instrukcí, se nebude křížit s jinou lodí
                    for (int i = 0; i < lenghtOfShip; i++)
                    {
                        if (myShipsBoard[row, columnNumber + i] == '-')
                        {
                            squareSucces += 1;
                        }
                    }
                    //pokud je možné umístit loď, program ji úmístí, jinak požaduje nově zadat kam bude umístěna
                    if (squareSucces == lenghtOfShip)
                    {
                        for (int i = 0; i < lenghtOfShip; i++)
                        {
                            myShipsBoard[row, columnNumber + i] = tipeOfShip;
                        }
                        successShip = true;
                    }
                    else
                    {
                        successColumn = false;
                        successRow = false;
                        successOrientation = false;
                        row = 0;
                        columnNumber = 0;
                        squareSucces = 0;
                        Console.WriteLine("Umístitit tuto loď na toto místo bohužel " +
                            "není možné. Zkus to znovu.");
                    }
                }
                //umístění lodě, pokud má být umístěna do sloupce
                if(orientation == "s")
                {
                    //program se ptá na počáteční řádek, dokud není zadán tak, aby se tam loď vešla
                    while (successRow == false)
                    {
                        successRow = int.TryParse(Console.ReadLine(), out row);
                        if (successRow == true)
                        {
                            if (row < 0 || row > 10 - lenghtOfShip)
                            {
                                successRow = false;
                                Console.WriteLine("Zatím nebylo napsáno žádné existující číslo" +
                                    " řádku, nebo by se loď do tabulky nevešla. Zkus to znovu");
                            }
                        }
                        else
                        {
                            successRow = false;

                            Console.WriteLine("Zatím nebylo napsáno žádné existující číslo řádku." +
                                " Zkus to znovu");
                        }
                    }
                    //program se ptá na sloupec ve kterém leží loď dokud není zadán správný vstup
                    Console.WriteLine("Nyní napiš písmeno sloupce ve kterém bude počáteční pole");
                    while (successColumn == false)
                    {
                        columnLetter = Console.ReadLine();
                        columnNumber = ColumnNumber(columnLetter);
                        if (columnNumber > -1 && columnNumber < 10)
                        {
                            successColumn = true;
                        }
                        else
                        {
                            Console.WriteLine("Sloupec s tímto označením neexistuje");
                        }
                    }
                    //program kontroluje zda je možné loď umístit na tuto pozici, aniž by se křížila s jinou lodí
                    for (int i = 0; i < lenghtOfShip; i++)
                    {
                        if (myShipsBoard[row + i, columnNumber] == '-')
                        {
                            squareSucces += 1;
                        }
                    }
                    //pokud je to možné, umistí se loď, jinak požaduje nové zadání pozice lodi
                    if (squareSucces == lenghtOfShip)
                    {
                        for (int i = 0; i < lenghtOfShip; i++)
                        {
                            myShipsBoard[row + i, columnNumber] = tipeOfShip;
                        }
                        successShip = true;
                    }
                    else
                    {
                        Console.WriteLine("Umístitit tuto loď na toto místo bohužel " +
                            "není možné. Zkus to znovu.");
                        successColumn = false;
                        successRow = false;
                        successOrientation = false;
                        row = 0;
                        columnNumber = 0;
                        squareSucces = 0;
                    }
                }
            }
            return myShipsBoard;
        }
        static char[,] ComputersShips(char[,] computersShipsBoard)
        {
            //program zavolá na každou loď počítače funkci ComputerShipPosition
            computersShipsBoard = ComputersShipPosition(computersShipsBoard, 5, 'L');
            computersShipsBoard = ComputersShipPosition(computersShipsBoard, 4, 'B');
            computersShipsBoard = ComputersShipPosition(computersShipsBoard, 3, 'K');
            computersShipsBoard = ComputersShipPosition(computersShipsBoard, 3, 'T');
            computersShipsBoard = ComputersShipPosition(computersShipsBoard, 2, 'P');
            return computersShipsBoard;
        }
        static char[,] ComputersShipPosition(char[,] computersShipsBoard, int lenghtOfShip, char tipeOfShip)
        {
            //počítač umístí danou loď
            Random rnd = new Random();
            bool successShip;
            int row, column, squareSucces, orientation;
            successShip = false;
            squareSucces = 0;
            row = 0;
            column = 0;

            while(successShip == false)
            {
                //náhodně se vygeneruje orientace lodi
                orientation = rnd.Next(0, 2);
                //umístění lodi do řádku
                if (orientation == 0)
                {
                    //náhodně se vygeneruje řádek ve kterém loď leží a počáteční sloupec tak, aby se loď do tabulky vešla
                    row = rnd.Next(0, 10);
                    column = rnd.Next(0, 10 - lenghtOfShip);
                    //kontrola zda může být loď na toto místo umístěna
                    for (int i = 0; i < lenghtOfShip; i++)
                    {
                        if (computersShipsBoard[row, column + i] == '-')
                        {
                            squareSucces += 1;
                        }
                    }
                    //pokuď může být loď umístěná bude, jinak se umístění lodi zopakuje od začátku
                    if (squareSucces == lenghtOfShip)
                    {
                        for (int i = 0; i < lenghtOfShip; i++)
                        {
                            computersShipsBoard[row, column + i] = tipeOfShip;
                        }
                        successShip = true;
                    }
                    else
                    {
                        squareSucces = 0;
                    }
                }
                //umístění lodě do sloupce
                if (orientation == 1)
                {
                    //náhodně se vygeneruje sloupec ve kterém loď leží a počáteční řádek tak, aby se loď do tabulky vešla
                    column = rnd.Next(0, 10);
                    row = rnd.Next(0, 10 - lenghtOfShip);
                    //kontrola zda může být loď na toto místo umístěna
                    for (int i = 0; i < lenghtOfShip; i++)
                    {
                        if (computersShipsBoard[row + i, column] == '-')
                        {
                            squareSucces += 1;
                        }
                    }
                    //pokuď může být loď umístěná bude, jinak se umístění lodi zopakuje od začátku
                    if (squareSucces == lenghtOfShip)
                    {
                        for (int i = 0; i < lenghtOfShip; i++)
                        {
                            computersShipsBoard[row + i, column] = tipeOfShip;
                        }
                        successShip = true;
                    }
                    else
                    {
                        squareSucces = 0;
                    }
                }
            }
            return computersShipsBoard;
        }
        static int[] MyShotPosition()
        {
            //funkce zjistí na jaké pole chce hráč střílet
            bool successColumn, successRow;
            int row, columnNumber;
            string columnLetter;
            row = 0;
            columnNumber = 0;
            successColumn = false;
            successRow = false;
            //ptá se na řádek kamse bude střílet dokud není zadána možná hodnota
            Console.WriteLine("Jsi na řadě. Vyber políčko, na které chceš střílet. Jako" +
                "první zadej řádek na kterém políčko leží");
            while (successRow == false)
            {
                successRow = int.TryParse(Console.ReadLine(), out row);
                if (successRow == true)
                {
                    if (row < 0 || row > 9)
                    {
                        successRow = false;
                        Console.WriteLine("Zatím nebylo napsáno žádné existující číslo" +
                            " řádku. Zkus to znovu");
                    }
                }
                else
                {
                    Console.WriteLine("Zatím nebylo napsáno žádné existující číslo řádku." +
                        " Zkus to znovu");
                }
            }
            //ptá se na sloupec kamse bude střílet dokud není zadána možná hodnota
            Console.WriteLine("Nyní yadej sloupec ve kterém leží políčko");
            while (successColumn == false)
            {
                columnLetter = Console.ReadLine();
                columnNumber = ColumnNumber(columnLetter);
                if (columnNumber > -1 && columnNumber < 10)
                {
                    successColumn = true;
                }
                else
                {
                    Console.WriteLine("Sloupec s tímto označením neexistuje. Zkus to znovu.");
                }
            }
            //funkce vrátí pole, kde na indexu 0 je index řádku střeli a na indexu 1 je index sloupce střeli
            int[] myShotPosition = new int[2] {row, columnNumber};
            return myShotPosition;
        }
        static int[] ComputersShotPosition(char[,] computersShotsBoard, int ifHit,int hitRow,int hitColumn)
        {
            //určuje na jaké pole bude střílet počítač
            int row, column;
            bool successShot;
            row = 0;
            column = 0;
            successShot = false;
            Random rnd = new Random();
            while(successShot == false)
            {
                //pokud byl v nějakém z nedávno minulých tahů počítače zásah, je proměná ifHit
                //nastavená na 4 a postupně se zmenšuje a na základě toho jsou zkoušeny okolní pole
                //minulého zásahu
                if(ifHit == 4)
                {
                    if(hitRow > 0)
                    {
                        row = hitRow - 1;
                        column = hitColumn;
                        successShot = true;
                    }
                    else
                    {
                        ifHit -= 1;
                    }
                }
                else if(ifHit == 3)
                {
                    if (hitColumn < 9)
                    {
                        row = hitRow;
                        column = hitColumn + 1;
                        successShot = true;
                    }
                    else
                    {
                        ifHit -= 1;
                    }
                }
                else if (ifHit == 2)
                {
                    if (hitRow < 9)
                    {
                        row = hitRow + 1;
                        column = hitColumn;
                        successShot = true;
                    }
                    else
                    {
                        ifHit -= 1;
                    }
                }
                else if (ifHit == 1)
                {
                    if (hitColumn > 0)
                    {
                        row = hitRow;
                        column = hitColumn - 1;
                        successShot = true;
                    }
                    else
                    {
                        ifHit -= 1;
                    }
                }
                else
                {
                    //pokud už byli vyzkoušeny políčka kolem poslední trefy a žádná
                    //další část lodi nebyla nalezena je náhodně vygenerován sloupec
                    //a řádek střeli a zjištění zda
                    //už tam nebylo stříleno. Pokud ano, políčko se vybere znovu
                    row = rnd.Next(0, 10);
                    column = rnd.Next(0, 10);
                    successShot = true;
                }
                if (successShot == true)
                {
                    if (computersShotsBoard[row, column] == 'X')
                    {
                        successShot = false;
                    }
                }
            }
            int[] computersShotPosition = new int[3] { row, column, ifHit};
            return computersShotPosition;
        }
        static void MyGameSituation(char[,] myShotsBoard, char[,] computersShotsBoard)
        {
            //vypíše jak vypadají střeli hráče a počítače
            Console.WriteLine("Takto vypadají tvé zásahy");
            WriteBoard(myShotsBoard);
            Console.WriteLine("Takto vypadají zásahy počítače");
            WriteBoard(computersShotsBoard);
        }
        static int[] MyHit(char shot, int computersAircraftCarrier, int computersBattleship,
            int computersCruiser, int computersSubmarine, int computersDestroyer)
        {
            //kontrola zda nebyla v tomto tahu potopená nějaká loď počítače. Pokud ano, napíše která
            switch (shot)
            {
                case 'L':
                    computersAircraftCarrier -= 1;
                    if (computersAircraftCarrier == 0)
                    {
                        Console.WriteLine("Potopil jsi letadlovou loď");
                    }
                    break;
                case 'B':
                    computersBattleship -= 1;
                    if (computersBattleship == 0)
                    {
                        Console.WriteLine("Potopil jsi bitevní loď");
                    }
                    break;
                case 'K':
                    computersCruiser -= 1;
                    if (computersAircraftCarrier == 0)
                    {
                        Console.WriteLine("Potopil jsi křižník");
                    }
                    break;
                case 'P':
                    computersSubmarine -= 1;
                    if (computersSubmarine == 0)
                    {
                        Console.WriteLine("Potopil jsi ponorku");
                    }
                    break;
                case 'T':
                    computersDestroyer -= 1;
                    if (computersDestroyer == 0)
                    {
                        Console.WriteLine("Potopil jsi torpédoborec");
                    }
                    break;
            }
            int[] numbersOfShips = new int[5] {computersAircraftCarrier, computersBattleship,
                computersCruiser, computersSubmarine, computersDestroyer };
            return numbersOfShips;
        }
        static int[] ComputersHit(char shot, int myAircraftCarrier, int myBattleship,
            int myCruiser, int mySubmarine, int myDestroyer)
        {
            //kontrola zda nebyla v tomto tahu potopená nějaká loď počítače. Pokud ano, napíše která
            switch (shot)
            {
                case 'L':
                    myAircraftCarrier -= 1;
                    if (myAircraftCarrier == 0)
                    {
                        Console.WriteLine("Počítač ti potopil letadlovou loď");
                    }
                    break;
                case 'B':
                    myBattleship -= 1;
                    if (myBattleship == 0)
                    {
                        Console.WriteLine("Počítač ti potopil bitevní loď");
                    }
                    break;
                case 'K':
                    myCruiser -= 1;
                    if (myAircraftCarrier == 0)
                    {
                        Console.WriteLine("Počítač ti potopil křižník");
                    }
                    break;
                case 'P':
                    mySubmarine -= 1;
                    if (mySubmarine == 0)
                    {
                        Console.WriteLine("Počítač ti potopil ponorku");
                    }
                    break;
                case 'T':
                    myDestroyer -= 1;
                    if (myDestroyer == 0)
                    {
                        Console.WriteLine("Počítač ti potopil torpédoborec");
                    }
                    break;
            }
            int[] numbersOfShips = new int[5] {myAircraftCarrier, myBattleship,
                myCruiser, mySubmarine, myDestroyer };
            return numbersOfShips;
        }
        static void Main(string[] args)
        {
            int myShips, computersShips, myAircraftCarrier, myBattleship, 
                myCruiser, mySubmarine, myDestroyer, computersAircraftCarrier, 
                computersBattleship, computersCruiser, computersSubmarine, computersDestroyer, ifHit,
                hitRow, hitColumn;
            char shot;
            myAircraftCarrier = 5;
            myBattleship = 4;
            myCruiser = 3;
            mySubmarine = 3;
            myDestroyer = 2;
            computersAircraftCarrier = 5;
            computersBattleship = 4;
            computersCruiser = 3; 
            computersSubmarine = 3; 
            computersDestroyer = 2;
            myShips = 17;
            computersShips = 17;
            ifHit = 0;
            hitColumn = 0;
            hitRow = 0;

            //vytvoří se tabulky kde budou loďe počítače a hráče a střeli
            char[,] myShipsBoard = CreateMyShipsBoard();
            char[,] computersShipsBoard = CreateComputersShipsBoard();
            char[,] myShotsBoard = CreateMyShotsBoard();
            char[,] computersShotsBoard = CreateComputersShotsBoard();
            Introduction();//vypíše se úvod
            WriteBoard(myShipsBoard);//vypsání tabulky s loďemi hráče
            myShipsBoard = MyShips(myShipsBoard);//naplní tabulku loďemi hráče
            computersShipsBoard = ComputersShips(computersShipsBoard);//vyplní tabulku loděmi počítače
            //hráč a počítač se střídaji v tazích dokud jeden z nich nepotopí tomu druhému všechny lodě
            while (computersShips > 0 && myShips > 0)
            {
                MyGameSituation(myShotsBoard, computersShotsBoard);//vypíše tabulku se střelami hráče a počítače
                int[] myShotPosition = MyShotPosition();//zjistí kam střílí hráč
                shot = computersShipsBoard[myShotPosition[0], myShotPosition[1]];
                if (shot == '-')
                {
                    //pokud hráč střelil mimo, program to zaznamená
                    Console.WriteLine("Bohužel jsi zasáhl pouze vodu");
                    myShotsBoard[myShotPosition[0], myShotPosition[1]] = 'O';
                }
                else
                {
                    if(myShotsBoard[myShotPosition[0], myShotPosition[1]] == 'X')
                    {
                        //pokud hráč střílí na místo kam už střílel počítač ho na to upozorní a nepočítá to jako zásah 
                        Console.WriteLine("Zasáhl jsi sice loď, ale na toto místo už jsi střílel," +
                            "příště to zkus jinam.");
                    }
                    else
                    {
                        //pokud hráč zasáhne loď, program mu to napíše 
                        Console.WriteLine("Výborně, zasáhl jsi loď");
                        myShotsBoard[myShotPosition[0], myShotPosition[1]] = 'X';
                        computersShips -= 1;
                        int[] numbersOfShips = MyHit(shot, computersAircraftCarrier, computersBattleship, computersCruiser, computersSubmarine, computersDestroyer);
                        computersAircraftCarrier = numbersOfShips[0];
                        computersBattleship = numbersOfShips[1];
                        computersCruiser = numbersOfShips[2];
                        computersSubmarine = numbersOfShips[3];
                        computersDestroyer = numbersOfShips[4];
                    }
                }
                if (computersShips == 0)
                {
                    //pokud hráč potopil všechny lodě, počítač již nepokračuje svým tahem
                    break;
                }
                //počítač střílí
                int[] computersShotPosition = ComputersShotPosition(computersShotsBoard, ifHit, hitRow, hitColumn);
                ifHit = computersShotPosition[2];
                shot = myShipsBoard[computersShotPosition[0], computersShotPosition[1]];
                if (shot == '-')
                {
                    //pokud počítač trefí mimo bude to zaznamenáno
                    Console.WriteLine("Počítač zasáhl poze vodu");
                    computersShotsBoard[computersShotPosition[0], computersShotPosition[1]] = 'O';
                    ifHit -= 1;
                }
                else
                {
                    //pokud počítač zasáhne loˇ, zaznamená se to jako zásah
                    Console.WriteLine("Počítač zasáhl loď");
                    computersShotsBoard[computersShotPosition[0], computersShotPosition[1]] = 'X';
                    myShips -= 1;
                    ifHit = 4;
                    hitColumn = computersShotPosition[1];
                    hitRow = computersShotPosition[0];
                    int[] numbersOfShips = ComputersHit(shot, myAircraftCarrier, myBattleship, myCruiser, mySubmarine, myDestroyer);
                    myAircraftCarrier = numbersOfShips[0];
                    myBattleship = numbersOfShips[1];
                    myCruiser = numbersOfShips[2];
                    mySubmarine = numbersOfShips[3];
                    myDestroyer = numbersOfShips[4];
                }
            }
            if(computersShips ==  0)
            {
                //pokud hráč potopí všechny lodě, vyhrál
                Console.WriteLine("Potopil jsi již všechny lodě. Gratuluji, hru jsi vyhrál.");
            }
            if(myShips == 0)
            {
                //pokud počítač potopí všechny lodě, počítač vyhrál                 
                Console.WriteLine("Počítač ti již potopil všechny lodě. Hru jsi bohužel prohrál.");
            }

            Console.ReadKey();
        }
    }
}
