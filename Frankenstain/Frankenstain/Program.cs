using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Frankenstain
{
    internal class Program
    {
        static void Justine()
        {
            Console.WriteLine("Rozhodl ses obvinit JUstine. Ta byla za vraždu Williama odsouzená " +
                "k trestu smrti oběšením. Ona však vrahem nebyla. Williamův starší bratr " +
                "Viktor Frankenstain ve snaze objevit tajemství života oživil člověka" +
                " sešitého z ostatků oběšených to se teď rozhodlo Viktorovi mstít za svůj těžký " +
                "osud, že ho všichni chápou jako nestvůru a nejprve omylem zavraždilo jednoho vesničana " +
                "a poté naschvál Williama. Nakkonec přijdou oživot i otec, Elizabeth a Viktorův" +
                "přítel Henry, ktrerý se v této detektivce nevyskytoval a nakonec i samotný Viktor. Viktor se stvořením se spolu" +
                " usmíří až těsně před Viktorovou smrtí.");
        }
        static void Creation()
        {
            Console.WriteLine("Rozhodl ses neobvinit Justine, protože si dospěl k názoru, že skutečným " +
                "pachatelem bude opravdu záhadné stvoření o kterém všichni mluví. Nevíš jak budeš před soudem" +
                " tuto hypotézu obhajovat, ale Justine je neviná. Zatím co přemýšlíš uslyšíš za sebou " +
                "kroky. Když se otočíš, uvidíš něco jako člověka, ale větší a mrtvolně bledou " +
                "kůží. Než se stihneš vzpamatovat, stvoření už tě drží a i ty skončíš udušen v jeho náruči.");
            Console.WriteLine();
            Console.WriteLine("Tento příběh je inspirován příběhem stvoření, jež vytvořil Viktor Frankenstain." +
                "V realitě sice skončí odsouzením Justine, nicméně většina hlavnich postav je uškrcena " +
                "v silném obětí stvořením, jako zde.");
        }
        static void Main(string[] args)
        {
            int level;
            bool decisionSuccess, offenderSucces;
            string decision, offender;
            Player player = new Player();
            Garden garden = new Garden();
            Hall hall = new Hall();
            WilliamRoom williameRoom = new WilliamRoom();
            ViktorRoom viktorRoom = new ViktorRoom();
            JustineRoom justineRoom = new JustineRoom();
            ElizabethRoom elizabethRoom = new ElizabethRoom();
            FatherRoom fatherRoom = new FatherRoom();
            Forest forest = new Forest();
            Village village = new Village();
            Father father = new Father();
            Villager villager = new Villager();
            Justine justine = new Justine();
            Elizabeth elizabeth = new Elizabeth();
            offenderSucces = false;
            level = 1;
            player.Introduction();

            while (level == 1)
            {
                decisionSuccess = false;
                switch (player.position)
                {
                    case "zahrada":
                        if (garden.visited == false)
                        {
                            garden.Introduction();
                            garden.visited = true;
                        }
                        break;
                    case "hala":
                        if (hall.visited == false)
                        {
                            hall.Introduction();
                            hall.visited = true;
                        }
                        break;
                    case "WilliamPokoj":
                        if (williameRoom.visited == false)
                        {
                            williameRoom.Introduction();
                            williameRoom.visited = true;
                        }
                        break;
                    case "ViktorPokoj":
                        break;
                    case "JustinePokoj":
                        justineRoom.Introduction();
                        break;
                    case "ElizabethPokoj":
                        elizabethRoom.Introduction();
                        break;
                    case "otecPokoj":
                        if (fatherRoom.visited == false)
                        {
                            fatherRoom.Introduction();
                            fatherRoom.visited = true;
                        }
                        break;
                    case "les":
                        forest.Introduction();
                        break;
                    case "vesnice":
                        if (village.visited == false)
                        {
                            village.Introduction();
                            village.visited = true;
                        }
                        break;
                }
                while (decisionSuccess == false)
                {
                    switch (player.position)
                    {
                        case "zahrada":
                            decisionSuccess = true;
                            garden.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "p":
                                    garden.Search();
                                    break;
                                case "d":
                                    player.position = "hala";
                                    break;
                                case "v":
                                    player.position = "vesnice";
                                    break;
                                case "l":
                                    player.position = "les";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "hala":
                            decisionSuccess = true;
                            hall.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "w":
                                    player.position = "WilliamPokoj";
                                    break;
                                case "v":
                                    player.position = "ViktorPokoj";
                                    break;
                                case "e":
                                    player.position = "ElizabethPokoj";
                                    break;
                                case "j":
                                    player.position = "JustinePokoj";
                                    break;
                                case "o":
                                    player.position = "otecPokoj";
                                    break;
                                case "z":
                                    player.position = "zahrada";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "WilliamPokoj":
                            decisionSuccess = true;
                            williameRoom.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "h":
                                    player.position = "hala";
                                    break;
                                case "j":
                                    justine.Interrogation();
                                    player.position = "hala";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "ViktorPokoj":
                            decisionSuccess = true;
                            viktorRoom.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "p":
                                    player.position = "hala";
                                    break;
                                case "s":
                                    level = 2;
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "JustinePokoj":
                            decisionSuccess = true;
                            justineRoom.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "h":
                                    player.position = "hala";
                                    break;
                                case "p":
                                    if (player.locket == false)
                                    {
                                        justineRoom.Search();
                                        player.locket = true;
                                    }
                                    else
                                    {
                                        justineRoom.Search2();
                                    }
                                    player.position = "hala";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "ElizabethPokoj":
                            decisionSuccess = true;
                            elizabethRoom.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "h":
                                    player.position = "hala";
                                    break;
                                case "e":
                                    elizabeth.Interrogation();
                                    player.position = "hala";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "otecPokoj":
                            decisionSuccess = true;
                            fatherRoom.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "h":
                                    player.position = "hala";
                                    break;
                                case "v":
                                    father.Interrogation();
                                    player.position = "hala";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "les":
                            decisionSuccess = true;
                            forest.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "v":
                                    player.position = "vesnice";
                                    break;
                                case "z":
                                    player.position = "zahrada";
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                        case "vesnice":
                            decisionSuccess = true;
                            village.Decision();
                            decision = Console.ReadLine();
                            switch (decision)
                            {
                                case "l":
                                    player.position = "les";
                                    break;
                                case "z":
                                    player.position = "zahrada";
                                    break;
                                case "v":
                                    villager.Interrogation();
                                    break;
                                default:
                                    Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                                    decisionSuccess = false;
                                    break;
                            }
                            break;
                    }
                }

            }
            Console.WriteLine("Podle výpovědí svědků a oběvených důkazů to vypadá, že William byl " +
                "zavražděn buď svou chůvou Justine a nebo nějakým neznámým stvořením. Kdo to udělal" +
                "podle tebe? Justine (klávesa j) nebo stvoření (klávesa s)");
            offender = Console.ReadLine();
            while (offenderSucces == false)
            {
                switch (offender)
                {
                    case "j":
                        Justine();
                        offenderSucces = true;
                        break;
                    case "s":
                        Creation();
                        offenderSucces = true;
                        break;
                    default:
                        Console.WriteLine("Napsal si neexistující variantu, zkuz to znovu");
                        break;

                }
            }
            Console.WriteLine("KONEC HRY");
            Console.ReadKey();
        }
    }
}
