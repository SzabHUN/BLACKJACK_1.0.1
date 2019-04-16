using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * Console.ForegroundColor = ConsoleColor.Black;
 * Console.BackgroundColor = ConsoleColor.Blue;
 */

namespace BLACKJACK_1._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int plyrHndIndex = 1, dlrHndIndex = 1, pozx = 26;

            //-------------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------------------------PLAYER-STR-------------------------------//
            int[] hand = new int[8];

            for (int i = 0; i < hand.Length; i++)
            {
                hand[i] = 714;
            }
            string[] cardvalues =
            {
                "Ace:11",
                "2:2","3:3","4:4","5:5","6:6","7:7","8:8","9:9",
                "10:10","Jack:10","Queen:10","King:10"
            };
            string[] handcolors = new string[8];


            hand[0] = rnd.Next(0, 14);


            if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    handcolors[0] = hand[0] + ":♠"; //spade
                }
                else
                {
                    handcolors[0] = hand[0] + ":♣"; //club
                } //-------------------------------------------//type
            }
            else
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    handcolors[0] = hand[0] + ":♦"; //diamond
                }
                else
                {
                    handcolors[0] = hand[0] + ":♥"; //heart
                } //-------------------------------------------//type
            } //------------------------------------------------------------------------//color
            /*
            if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    handcolors[1] = hand[1] + ":♠"; //spade
                }
                else
                {
                    handcolors[1] = hand[1] + ":♣"; //club
                } //-------------------------------------------//type
            }
            else
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    handcolors[1] = hand[1] + ":♦"; //diamond
                }
                else
                {
                    handcolors[1] = hand[1] + ":♥"; //heart
                } //-------------------------------------------//type
            } //------------------------------------------------------------------------//color
            */
            //--------------------------------------------------------------------PLAYER-STR-------------------------------//
            //-------------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------------------------DEALER-STR-------------------------------//

            int[] dealershand = new int[8];
            for (int i = 0; i < hand.Length; i++)
            {
                dealershand[i] = 714;
            }

            string[] dealershandcolors = new string[8];


            dealershand[0] = rnd.Next(0, 14);
            dealershand[1] = rnd.Next(0, 14);

            if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    dealershandcolors[0] = $"{dealershand[0]}:♠"; //spade
                }
                else
                {
                    dealershandcolors[0] = $"{dealershand[0]}:♣"; //club
                } //-------------------------------------------//type
            }
            else
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    dealershandcolors[0] = $"{dealershand[0]}:♦"; //diamond
                }
                else
                {
                    dealershandcolors[0] = $"{dealershand[0]}:♥"; //heart
                } //-------------------------------------------//type
            } //------------------------------------------------------------------------//color
            /*
            if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    dealershandcolors[1] = $"{dealershand[1]}:♠"; //spade
                }
                else
                {
                    dealershandcolors[1] = $"{dealershand[1]}:♣"; //club
                } //-------------------------------------------//type
            }
            else
            {
                if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                {
                    dealershandcolors[1] = $"{dealershand[1]}:♦"; //diamond
                }
                else
                {
                    dealershandcolors[1] = $"{dealershand[1]}:♥"; //heart
                } //-------------------------------------------//type
            } //------------------------------------------------------------------------//color
            */
            //--------------------------------------------------------------------DEALER-STR-------------------------------//
            //-------------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------------------------COUNT--STR-------------------------------//

            int plyr = 0, dlr = 0; // sum

            //------------------------------//
            if (hand[0] == 0)
            {
                plyr += 11;
            }
            else if (hand[0] == 11 || hand[0] == 12 || hand[0] == 13)
            {
                plyr += 10;
            }
            else
            {
                plyr += hand[0];
            }

            //------------------------------//
            if (dealershand[0] == 0)
            {
                dlr += 11;
            }
            else if (dealershand[0] == 11 || dealershand[0] == 12 || dealershand[0] == 13)
            {
                dlr += 10;
            }
            else
            {
                dlr += dealershand[0];
            }

            //--------------------------------------------------------------------COUNT--STR-------------------------------//
            //-------------------------------------------------------------------------------------------------------------//
            //--------------------------------------------------------------------GAME-------------------------------------//

            Boolean GoForOne = true;
            String aa = String.Empty;

            while (GoForOne == true)
            {
                GoForOne = false;
                //----------------//
                Console.BackgroundColor = ConsoleColor.DarkGray;
                for (int i = 0; i < 96; i++)
                {
                    Console.SetCursorPosition(i + 10, 2);
                    Console.Write(' ');
                }
                for (int i = 0; i < 27; i++)
                {
                    Console.SetCursorPosition(10, i + 2);
                    Console.Write(' ');
                }
                for (int i = 0; i < 97; i++)
                {
                    Console.SetCursorPosition(i + 10, 2 + 26);
                    Console.Write(' ');
                }
                for (int i = 0; i < 26; i++)
                {
                    Console.SetCursorPosition(10 + 96, i + 2);
                    Console.Write(' ');
                }

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                for (int i = 0; i < 25; i++)
                {
                    for (int iq = 0; iq < 95; iq++)
                    {
                        Console.SetCursorPosition(iq + 11, i + 3);
                        Console.Write(' ');
                    }
                }

                //    Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.White;
                String drawornottodraw = "just fucking stop";
                // while (plyr < 21 || dlr < 21) //-------------------------------------------------------------//----FIX-THIS----//
                // {
                bool plyrdrw = true;
                int plyrfailgate = 0;
                while (plyrdrw == true && plyr < 22 && plyrHndIndex <= 5)
                {

                    if (plyr >= 21)
                    {
                        break;
                    }

                    if (drawornottodraw.ToUpper() == "STOP" || plyr >= 21)
                    {
                        drawornottodraw = String.Empty;
                        break;
                    }
                    else
                    {
                        if (plyrfailgate == 8)
                        {
                            break;
                        }
                        else
                        {
                            plyrfailgate++;
                        }
                        drawornottodraw = "just fucking stop already";
                        plyrdrw = false;

                        hand[plyrHndIndex] = rnd.Next(0, 14);
                        if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
                        {
                            if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                            {
                                handcolors[plyrHndIndex] = hand[plyrHndIndex] + ":♠"; //spade
                            }
                            else
                            {
                                handcolors[plyrHndIndex] = hand[plyrHndIndex] + ":♣"; //club
                            } //-------------------------------------------//type
                        }
                        else
                        {
                            if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                            {
                                handcolors[plyrHndIndex] = hand[plyrHndIndex] + ":♦"; //diamond
                            }
                            else
                            {
                                handcolors[plyrHndIndex] = hand[plyrHndIndex] + ":♥"; //heart
                            } //-------------------------------------------//type
                        }

                        if (hand[plyrHndIndex] == 0)
                        {
                            plyr += 11;
                        }
                        else if (hand[plyrHndIndex] == 11 || hand[plyrHndIndex] == 12 || hand[plyrHndIndex] == 13)
                        {
                            plyr += 10;
                        }
                        else
                        {
                            plyr += hand[plyrHndIndex];
                        }


                        Console.SetCursorPosition(15, 15);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(plyr);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.White;

                        if (handcolors[0].Split(':')[1] == "♥" || handcolors[0].Split(':')[1] == "♦")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        pozx = 26;
                        for (int i = 0; i < hand.Length; i++)
                        {

                            if (hand[i] != 714)
                            {

                                if (handcolors[i].Split(':')[1] == "♥" || handcolors[i].Split(':')[1] == "♦")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }

                                Console.SetCursorPosition(pozx, 22);
                                switch (handcolors[i].Split(':')[1])
                                {
                                    case "♥":
                                        Console.Write('H');
                                        break;
                                    case "♦":
                                        Console.Write('D');
                                        break;
                                    case "♣":
                                        Console.Write('C');
                                        break;
                                    case "♠":
                                        Console.Write('S');
                                        break;
                                    default:
                                        Console.Write('E');
                                        break;
                                }
                                Console.Write("  ");
                                Console.SetCursorPosition(pozx, 23);
                                switch (hand[i])
                                {
                                    case 0:
                                        Console.Write(" A ");
                                        break;
                                    case 11:
                                        Console.Write(" J ");
                                        break;
                                    case 12:
                                        Console.Write(" Q ");
                                        break;
                                    case 13:
                                        Console.Write(" K ");
                                        break;
                                    case 10:
                                        Console.Write($" {hand[i]}");
                                        break;
                                    default:
                                        Console.Write($" {hand[i]} ");
                                        break;
                                }
                                Console.SetCursorPosition(pozx, 24);
                                Console.Write("  ");
                                switch (handcolors[i].Split(':')[1])
                                {
                                    case "♥":
                                        Console.Write('H');
                                        break;
                                    case "♦":
                                        Console.Write('D');
                                        break;
                                    case "♣":
                                        Console.Write('C');
                                        break;
                                    case "♠":
                                        Console.Write('S');
                                        break;
                                    default:
                                        Console.Write('E');
                                        break;
                                }
                                pozx += 7;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(2, 25);
                        drawornottodraw = Console.ReadLine();
                        if (drawornottodraw.ToUpper() == "DRAW" || drawornottodraw.ToUpper() == "D")
                        {
                            plyrdrw = true;
                        }
                        else
                        {
                            plyrdrw = false;
                        }
                        if (drawornottodraw.ToUpper() == "STOP")
                        {
                            drawornottodraw = String.Empty;
                            break;
                        }
                        plyrHndIndex++;
                        Console.SetCursorPosition(2, 27);
                        Console.Write("        ");

                        if (plyr >= 21)
                        {
                            break;
                        }

                    }


                }

                pozx = 26;
                //--------------------------------------------------------------------PLAYER-----------------------------------//
                //-------------------------------------------------------------------------------------------------------------//
                //--------------------------------------------------------------------DEALER-----------------------------------//

                if (plyr < 22)
                {


                    double decing = 0;
                    int failgate = 0;
                    bool dlrdrw = true;
                    while (dlrdrw == true && dlrHndIndex <= 5 && dlr < 22)
                    {
                        if (dlr >= 21)
                        {
                            break;
                        }
                        if (dlrdrw == false)
                        {
                            break;
                        }
                        dlrdrw = false;
                        dealershand[dlrHndIndex] = rnd.Next(0, 14);
                        if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
                        {
                            if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♠"; //spade
                            }
                            else
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♣"; //club
                            } //-------------------------------------------//type
                        }
                        else
                        {
                            if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♦"; //diamond
                            }
                            else
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♥"; //heart
                            } //-------------------------------------------//type
                        }

                        if (dealershand[dlrHndIndex] == 0)
                        {
                            dlr += 11;
                        }
                        else if (dealershand[dlrHndIndex] == 11 || dealershand[dlrHndIndex] == 12 || dealershand[dlrHndIndex] == 13)
                        {
                            dlr += 10;
                        }
                        else
                        {
                            dlr += dealershand[dlrHndIndex];
                        }


                        Console.SetCursorPosition(15, 13);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(dlr);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.White;


                        pozx = 26;

                        for (int i = 0; i < dealershand.Length; i++)
                        {

                            if (dealershand[i] != 714)
                            {
                                if (dealershandcolors[i].Split(':')[1] == "♥" || dealershandcolors[i].Split(':')[1] == "♦")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }

                                Console.SetCursorPosition(pozx, 7);
                                switch (dealershandcolors[i].Split(':')[1])
                                {
                                    case "♥":
                                        Console.Write('H');
                                        break;
                                    case "♦":
                                        Console.Write('D');
                                        break;
                                    case "♣":
                                        Console.Write('C');
                                        break;
                                    case "♠":
                                        Console.Write('S');
                                        break;
                                    default:
                                        Console.Write('E');
                                        break;
                                }
                                Console.Write("  ");
                                Console.SetCursorPosition(pozx, 8);
                                switch (dealershand[i])
                                {
                                    case 0:
                                        Console.Write(" A ");
                                        break;
                                    case 11:
                                        Console.Write(" J ");
                                        break;
                                    case 12:
                                        Console.Write(" Q ");
                                        break;
                                    case 13:
                                        Console.Write(" K ");
                                        break;
                                    case 10:
                                        Console.Write($" {dealershand[i]}");
                                        break;
                                    default:
                                        Console.Write($" {dealershand[i]} ");
                                        break;
                                }
                                Console.SetCursorPosition(pozx, 9);
                                Console.Write("  ");
                                switch (dealershandcolors[i].Split(':')[1])
                                {
                                    case "♥":
                                        Console.Write('H');
                                        break;
                                    case "♦":
                                        Console.Write('D');
                                        break;
                                    case "♣":
                                        Console.Write('C');
                                        break;
                                    case "♠":
                                        Console.Write('S');
                                        break;
                                    default:
                                        Console.Write('E');
                                        break;
                                }

                                pozx += 7;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;

                        decing = rnd.Next(12, 90);

                        if (dlr < 10)
                        {
                            dlrdrw = true;
                        }
                        else if (dlr < 15)
                        {
                            if (decing < 70)
                            {
                                dlrdrw = true;
                            }
                            else
                            {
                                dlrdrw = false;
                                break;
                            }
                        }
                        else if (dlr < 18)
                        {
                            if (decing < 14)
                            {
                                dlrdrw = true;
                            }
                            else
                            {
                                dlrdrw = false;
                                break;
                            }
                        }
                        else
                        {
                            dlrdrw = false;
                            break;
                        }

                        dlrHndIndex++;

                        if (dlr >= 21)
                        {
                            break;
                        }

                        if (failgate == 5)
                        {
                            failgate = 0;
                            break;
                        }
                        else
                        {
                            failgate++;
                        }

                    }

                    //}
                    //---------------------------------------------------//
                    //---------------------------------------------------//
                    //---------------------------------------------------//
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(20, 14);
                    if (plyr == 21)
                    {
                        if (dlr == 21)
                        {
                            Console.Write("DRAW");
                        }
                        else
                        {
                            Console.Write("PLAYER WINS");
                        }
                    }
                    else if (plyr == dlr)
                    {
                        Console.Write("DRAW");
                    }
                    else if (dlr == 21)
                    {
                        Console.Write("DEALER WINS");
                    }
                    else if (dlr > 21 && plyr > 21)
                    {
                        if (dlr > plyr)
                        {
                            Console.Write("PLAYER WINS");
                        }
                        else
                        {
                            Console.Write("DEALER WINS");
                        }
                    }
                    else
                    {
                        if (21 - plyr > 21 - dlr)
                        {
                            Console.Write("DEALER WINS");
                        }
                        else
                        {
                            Console.Write("PLAYER WINS");
                        }
                    }

                }
                else
                {

                    double decing = 0;
                    int failgate = 0;
                    bool dlrdrw = true;
                    while (dlrdrw == true && dlrHndIndex <= 5 && dlr < 22)
                    {
                        if (dlr >= 21)
                        {
                            break;
                        }
                        if (dlrdrw == false)
                        {
                            break;
                        }
                        dlrdrw = false;
                        dealershand[dlrHndIndex] = rnd.Next(0, 14);
                        if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
                        {
                            if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♠"; //spade
                            }
                            else
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♣"; //club
                            } //-------------------------------------------//type
                        }
                        else
                        {
                            if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♦"; //diamond
                            }
                            else
                            {
                                dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♥"; //heart
                            } //-------------------------------------------//type
                        }

                        if (dealershand[dlrHndIndex] == 0)
                        {
                            dlr += 11;
                        }
                        else if (dealershand[dlrHndIndex] == 11 || dealershand[dlrHndIndex] == 12 || dealershand[dlrHndIndex] == 13)
                        {
                            dlr += 10;
                        }
                        else
                        {
                            dlr += dealershand[dlrHndIndex];
                        }


                        Console.SetCursorPosition(15, 13);
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(dlr);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.BackgroundColor = ConsoleColor.White;


                        pozx = 26;

                        for (int i = 0; i < dealershand.Length; i++)
                        {

                            if (dealershand[i] != 714)
                            {
                                if (dealershandcolors[i].Split(':')[1] == "♥" || dealershandcolors[i].Split(':')[1] == "♦")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }

                                Console.SetCursorPosition(pozx, 7);
                                switch (dealershandcolors[i].Split(':')[1])
                                {
                                    case "♥":
                                        Console.Write('H');
                                        break;
                                    case "♦":
                                        Console.Write('D');
                                        break;
                                    case "♣":
                                        Console.Write('C');
                                        break;
                                    case "♠":
                                        Console.Write('S');
                                        break;
                                    default:
                                        Console.Write('E');
                                        break;
                                }
                                Console.Write("  ");
                                Console.SetCursorPosition(pozx, 8);
                                switch (dealershand[i])
                                {
                                    case 0:
                                        Console.Write(" A ");
                                        break;
                                    case 11:
                                        Console.Write(" J ");
                                        break;
                                    case 12:
                                        Console.Write(" Q ");
                                        break;
                                    case 13:
                                        Console.Write(" K ");
                                        break;
                                    case 10:
                                        Console.Write($" {dealershand[i]}");
                                        break;
                                    default:
                                        Console.Write($" {dealershand[i]} ");
                                        break;
                                }
                                Console.SetCursorPosition(pozx, 9);
                                Console.Write("  ");
                                switch (dealershandcolors[i].Split(':')[1])
                                {
                                    case "♥":
                                        Console.Write('H');
                                        break;
                                    case "♦":
                                        Console.Write('D');
                                        break;
                                    case "♣":
                                        Console.Write('C');
                                        break;
                                    case "♠":
                                        Console.Write('S');
                                        break;
                                    default:
                                        Console.Write('E');
                                        break;
                                }

                                pozx += 7;
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.White;

                        decing = rnd.Next(12, 90);

                        if (dlr < 10)
                        {
                            dlrdrw = true;
                        }
                        else if (dlr < 15)
                        {
                            if (decing < 70)
                            {
                                dlrdrw = true;
                            }
                            else
                            {
                                dlrdrw = false;
                                break;
                            }
                        }
                        else if (dlr < 18)
                        {
                            if (decing < 14)
                            {
                                dlrdrw = true;
                            }
                            else
                            {
                                dlrdrw = false;
                                break;
                            }
                        }
                        else
                        {
                            dlrdrw = false;
                            break;
                        }

                        dlrHndIndex++;

                        if (dlr >= 21)
                        {
                            break;
                        }

                        if (failgate == 2)
                        {
                            failgate = 0;
                            break;
                        }
                        else
                        {
                            failgate++;
                        }

                    }

                    //}
                    //---------------------------------------------------//
                    //---------------------------------------------------//
                    //---------------------------------------------------//
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(20, 14);
                    if (plyr == 21)
                    {
                        if (dlr == 21)
                        {
                            Console.Write("DRAW");
                        }
                        else
                        {
                            Console.Write("PLAYER WINS");
                        }
                    }
                    else if (plyr == dlr)
                    {
                        Console.Write("DRAW");
                    }
                    else if (dlr == 21)
                    {
                        Console.Write("DEALER WINS");
                    }
                    else if (dlr > 21 && plyr > 21)
                    {
                        if (dlr > plyr)
                        {
                            Console.Write("DEALER WINS");
                        }
                        else
                        {
                            Console.Write("DEALER WINS");
                        }
                    }
                    else
                    {
                        if (21 - plyr > 21 - dlr)
                        {
                            Console.Write("DEALER WINS");
                        }
                        else
                        {
                            Console.Write("DEALER WINS");
                        }
                    }
                }

                //---------------------------------------------------//
                //---------------------------------------------------//
                /*
                 * 1st card pos plry
                 * 26,22
                 * 26,23
                 * 26,24
                 */
                //Console.SetCursorPosition(27,23);
                //----------------//
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(0, 28);
                Console.Write("again?-");
                aa = Console.Read().ToString();
                if (aa.ToUpper() == "YES" || aa.ToUpper() == "Y")
                {
                    GoForOne = true;
                }
                else
                {
                    GoForOne = false;
                }
            }

            //--------------------------------------------------------------------GAME-------------------------------------//
            //-------------------------------------------------------------------------------------------------------------//

        }
        /* public DealersTurn
        public static void DealersTurn (int dlrHndIndex,int[] dealershand,string[] dealershandcolors,int dlr)
        {
            Random rnd = new Random();
            String drawornottodraw = String.Empty;
            int decing = 0;
            bool dlrdrw = true;
            do
            {
                dealershand[dlrHndIndex] = rnd.Next(0, 14);
                if (rnd.Next(0, 101) % 2 == 0) //-------------------------------------------//color
                {
                    if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                    {
                        dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♠"; //spade
                    }
                    else
                    {
                        dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♣"; //club
                    } //-------------------------------------------//type
                }
                else
                {
                    if (rnd.Next(0, 101) % 2 == 0) //--------------//type
                    {
                        dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♦"; //diamond
                    }
                    else
                    {
                        dealershandcolors[dlrHndIndex] = dealershand[dlrHndIndex] + ":♥"; //heart
                    } //-------------------------------------------//type
                }


                Console.SetCursorPosition(15, 15);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(dlr);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.White;

                if (dealershandcolors[0].Split(':')[1] == "♥" || dealershandcolors[0].Split(':')[1] == "♦")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                for (int i = 0; i < 5; i++)
                {
                    if (dealershand[i] != 714)
                    {
                        Console.SetCursorPosition(26, 22);
                        switch (dealershandcolors[0].Split(':')[1])
                        {
                            case "♥":
                                Console.Write('H');
                                break;
                            case "♦":
                                Console.Write('D');
                                break;
                            case "♣":
                                Console.Write('C');
                                break;
                            case "♠":
                                Console.Write('S');
                                break;
                            default:
                                Console.Write('E');
                                break;
                        }
                        Console.Write("  ");
                        Console.SetCursorPosition(26, 23);
                        switch (dealershand[0])
                        {
                            case 0:
                                Console.Write(" A ");
                                break;
                            case 11:
                                Console.Write(" J ");
                                break;
                            case 12:
                                Console.Write(" Q ");
                                break;
                            case 13:
                                Console.Write(" K ");
                                break;
                            case 10:
                                Console.Write($" {dealershand[0]}");
                                break;
                            default:
                                Console.Write($" {dealershand[0]} ");
                                break;
                        }
                        Console.SetCursorPosition(26, 24);
                        Console.Write("  ");
                        switch (dealershandcolors[0].Split(':')[1])
                        {
                            case "♥":
                                Console.Write('H');
                                break;
                            case "♦":
                                Console.Write('D');
                                break;
                            case "♣":
                                Console.Write('C');
                                break;
                            case "♠":
                                Console.Write('S');
                                break;
                            default:
                                Console.Write('E');
                                break;
                        }
                    }
                }

               
                dlrHndIndex++;

            } while (dlrdrw == true);
        }
        */
    }
}
/* plyr card 1
 * Console.SetCursorPosition(26,22);
                switch (handcolors[0].Split(':')[1] )
                {
                    case "♥":
                        Console.Write('H');
                        break;
                    case "♦":
                        Console.Write('D');
                        break;
                    case "♣":
                        Console.Write('C');
                        break;
                    case "♠":
                        Console.Write('S');
                        break;
                    default:
                        Console.Write('E');
                        break;
                }
                Console.Write("  ");
                Console.SetCursorPosition(26,23);
                switch (hand[0])
                {
                    case 0:
                        Console.Write(" A ");
                        break;
                    case 11:
                        Console.Write(" J ");
                        break;
                    case 12:
                        Console.Write(" Q ");
                        break;
                    case 13:
                        Console.Write(" K ");
                        break;
                    case 10:
                        Console.Write($" {hand[0]}");
                        break;
                    default:
                        Console.Write($" {hand[0]} ");
                        break;
                }
                Console.SetCursorPosition(26,24);
                Console.Write("  ");
                switch (handcolors[0].Split(':')[1])
                {
                    case "♥":
                        Console.Write('H');
                        break;
                    case "♦":
                        Console.Write('D');
                        break;
                    case "♣":
                        Console.Write('C');
                        break;
                    case "♠":
                        Console.Write('S');
                        break;
                    default:
                        Console.Write('E');
                        break;
                }
 * */
/* dlyr 
 *  decing = rnd.Next(0, 101);

               if (drawornottodraw.ToUpper() == "DRAW" || drawornottodraw.ToUpper() == "D")
               {
                   dlrdrw = true;
               }

 * */
