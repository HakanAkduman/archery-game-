using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace archery_game_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Burası A B ve C nin yerleştirilmesi içindir!!!!!!!!!!!!!!!


            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            System.Media.SoundPlayer ses1 = new System.Media.SoundPlayer();

            ses1.SoundLocation = "Epic-Celtic-Music-Archers-Dance.wav";
            ses1.Play();

            Console.Write("Please enter a X for A between (-10,10):  ");
            int Ax = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a Y for A between (-10,10):  ");
            int Ay = Convert.ToInt32(Console.ReadLine());
            if (Ax <= 10 && Ay <= 10 && Ax >= -10 && Ay >= -10)
            {
                Random rnd = new Random();
                int Bx = rnd.Next(-10, 11);
                int By = rnd.Next(-10, 11);
                int Cx = rnd.Next(-10, 11);
                int Cy = rnd.Next(-10, 11);
                if (Bx == Cx && By == Cy || Ax == Bx && Ay == By || Ax == Cx && Ay == Cy)
                {
                    Console.WriteLine("Please restart the game");
                    Console.ReadLine();
                    int z = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(" ");

                //Burası setleri dağıtmak içindir!!!!!!!!!!!!!!!!!!!!!!!


                int v = rnd.Next(0, 6);
                string seta, setb, setc;

                if (v == 0)
                {
                    seta = "Set 2";
                    setb = "Set 1";
                    setc = "Set 3";

                }

                else if (v == 1)
                {
                    seta = "Set 3";
                    setb = "Set 1";
                    setc = "Set 2";
                }

                else if (v == 2)
                {
                    seta = "Set 2";
                    setb = "Set 3";
                    setc = "Set 1";
                }

                else if (v == 3)
                {
                    seta = "Set 1";
                    setb = "Set 2";
                    setc = "Set 3";
                }

                else if (v == 4)
                {
                    seta = "Set 3";
                    setb = "Set 2";
                    setc = "Set 1";

                }

                else
                {
                    seta = "Set 1";
                    setb = "Set 3";
                    setc = "Set 2";
                }


                //Burada canları dağıtıyoruz!!!!!!!!!!!

                int healthA, healthB, healthC;
                int m = rnd.Next(0, 6);
                if (m == 0)
                {
                    healthA = 100;
                    healthB = 80;
                    healthC = 60;
                }
                else if (m == 1)
                {
                    healthA = 100;
                    healthB = 60;
                    healthC = 80;
                }
                else if (m == 2)
                {
                    healthA = 80;
                    healthB = 100;
                    healthC = 60;
                }
                else if (m == 3)
                {
                    healthA = 60;
                    healthB = 80;
                    healthC = 100;
                }
                else if (m == 4)
                {
                    healthA = 80;
                    healthB = 60;
                    healthC = 100;
                }
                else
                {
                    healthA = 60;
                    healthB = 100;
                    healthC = 80;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A: (" + Ax + "," + Ay + ")  Set:" + seta + "  Health: " + healthA);
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("B: (" + Bx + "," + By + ")  Set:" + setb + "  Health: " + healthB);
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("C: (" + Cx + "," + Cy + ")  Set:" + setc + "  Health: " + healthC);
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Set 1: Iron-head arrow and Celtic shield");
                Console.WriteLine("Set 2: Poison arrow and Wankel shield");
                Console.WriteLine("Set 3: Fire arrow and Heater shield");
                Console.ReadLine();

                double AB = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2));
                double BC = Math.Sqrt(Math.Pow(Bx - Cx, 2) + Math.Pow(By - Cy, 2));
                double AC = Math.Sqrt(Math.Pow(Ax - Cx, 2) + Math.Pow(Ay - Cy, 2));
                int ab = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
                int ac = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);
                int bc = Math.Abs(Bx - Cx) + Math.Abs(By - Cy);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +");
                Console.WriteLine(" 10| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  9| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  8| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  7| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  6| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  5| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  4| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  3| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  2| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  1| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("  0< - - - - - - - - - - + - - - - - - - - - - +");
                Console.WriteLine(" -1| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -2| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -3| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -4| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -5| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -6| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -7| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -8| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine(" -9| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("-10| . . . . . . . . . . | . . . . . . . . . . |");
                Console.WriteLine("   + - - - - - - - - - - ^ - - - - - - - - - - +");
                Console.WriteLine("    10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10 ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.SetCursorPosition(25, 24);
                Console.SetCursorPosition(25 + 2 * Ax, 24 - Ay);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("A");
                Console.SetCursorPosition(25 + 2 * Bx, 24 - By);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("B");
                Console.SetCursorPosition(25 + 2 * Cx, 24 - Cy);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("C");
                Console.ReadLine();
                Console.SetCursorPosition(0, 39);
                int puana = 0;
                int puanb = 0;
                int puanc = 0;

                Console.ForegroundColor = ConsoleColor.White;


                if (BC < AC && BC < AB && BC <= 15)
                {
                    Console.WriteLine("Round 1: B-C");
                    Console.WriteLine("");
                    if (setb == "Set 3" && setc == "Set 2" || setb == "Set 2" && setc == "Set 1" || setb == "Set 1" && setc == "Set 3")
                    {
                        ses.SoundLocation = "Die Sound Effect.wav";
                        ses.Play();
                        Console.WriteLine("B won");
                        Console.WriteLine(" ");
                        healthB = healthB - 25;
                        healthC = 0;
                        puanb = 10 * bc + (100 - healthB);
                        Console.WriteLine("A: Non-fighter   Health:" + healthA + "    Score:" + puana);
                        Console.WriteLine("B: Survivor      Health:" + healthB + "    Score:" + puanb);
                        Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);
                        Console.ReadLine();


                        if (AB <= 15)
                        {
                            Console.WriteLine("Round 2: A-B");
                            Console.WriteLine("");
                            if (seta == "Set 3" && setb == "Set 2" || seta == "Set 2" && setb == "Set 1" || seta == "Set 1" && setb == "Set 3")
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("A won");
                                healthB = 0;
                                healthA = healthA - 25;
                                puana = 10 * ab + (100 - healthA);
                                Console.WriteLine("A: Survivor      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);


                            }
                            else
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("B won");
                                healthA = 0;
                                healthB = healthB - 25;
                                puanb = (10 * ab + (100 - healthB)) + puanb;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Survivor      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);

                            }

                        }
                        else

                        {
                           
                            Console.WriteLine("Too distant, no attack");

                        }
                    }
                    else
                    {
                        ses.SoundLocation = "Die Sound Effect.wav";
                        ses.Play();
                        Console.WriteLine("C won");
                        Console.WriteLine(" ");
                        healthC = healthC - 25;
                        healthB = 0;
                        puanc = 10 * bc + (100 - healthC);
                        Console.WriteLine("A: Non-fighter   Health:" + healthA + "    Score:" + puana);
                        Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                        Console.WriteLine("C: Survivor      Health:" + healthC + "    Score:" + puanc);
                        Console.ReadLine();
                        if (AC <= 15)
                        {
                            Console.WriteLine("Round 2: A-C");
                            Console.WriteLine("");
                            if (seta == "Set 3" && setc == "Set 2" || seta == "Set 2" && setc == "Set 1" || seta == "Set 1" && setc == "Set 3")
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("A won");
                                Console.WriteLine(" ");
                                healthC = 0;
                                healthA = healthA - 25;
                                puana = 10 * ac + (100 - healthA);
                                Console.WriteLine("A: Survivor      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);


                            }
                            else
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("C won");
                                Console.WriteLine(" ");
                                healthA = 0;
                                healthC = healthC - 25;
                                puanc = (10 * ac + (100 - healthC)) + puanc;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Survivor      Health:" + healthC + "    Score:" + puanc);

                            }

                        }
                        else
                        {
                            
                            Console.WriteLine("Too distant, no attack");

                        }
                    }
                }


                //ab başlangıç

                else if (AB < AC && AB < BC && AB <= 15)
                {
                    Console.WriteLine("Round 1 : A-B");
                    Console.WriteLine("");
                    if (seta == "Set 3" && setb == "Set 2" || seta == "Set 2" && setb == "Set 1" || seta == "Set 1" && setb == "Set 3")
                    {
                        ses.SoundLocation = "Die Sound Effect.wav";
                        ses.Play();
                        Console.WriteLine("A won");
                        Console.WriteLine(" ");
                        healthA = healthA - 25;
                        healthB = 0;
                        puana = 10 * ab + (100 - healthA);
                        Console.WriteLine("A: Survivor      Health:" + healthA + "    Score:" + puana);
                        Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                        Console.WriteLine("C: Non-fighter   Health:" + healthC + "    Score:" + puanc);
                        Console.ReadLine();
                        if (AC <= 15)
                        {
                            Console.WriteLine("Round 2: A-C");
                            Console.WriteLine("");
                            if (seta == "Set 3" && setc == "Set 2" || seta == "Set 2" && setc == "Set 1" || seta == "Set 1" && setc == "Set 3")
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("A won");
                                Console.WriteLine(" ");
                                healthC = 0;
                                healthA = healthA - 25;
                                puana = 10 * ac + (100 - healthA)+puana;
                                Console.WriteLine("A: Survivor      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);


                            }
                            else
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("C won");
                                Console.WriteLine(" ");
                                healthA = 0;
                                healthC = healthC - 25;
                                puanc = (10 * ac + (100 - healthC)) + puanc;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Survivor      Health:" + healthC + "    Score:" + puanc);

                            }

                        }
                        else
                        {
                            
                            Console.WriteLine("Too distant, no attack");

                        }

                    }
                    else
                    {
                        ses.SoundLocation = "Die Sound Effect.wav";
                        ses.Play();
                        Console.WriteLine("B won");
                        Console.WriteLine(" ");
                        healthB = healthB - 25;
                        healthA = 0;
                        puanb = 10 * ab + (100 - healthB);
                        Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                        Console.WriteLine("B: Survivor      Health:" + healthB + "    Score:" + puanb);
                        Console.WriteLine("C: Non-fighter   Health:" + healthC + "    Score:" + puanc);
                        Console.ReadLine();
                        if (BC <= 15)
                        {
                            Console.WriteLine("Round 2: B-C");
                            Console.WriteLine("");
                            if (setb == "Set 3" && setc == "Set 2" || setb == "Set 2" && setc == "Set 1" || setb == "Set 1" && setc == "Set 3")
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("B won");
                                Console.WriteLine(" ");
                                healthC = 0;
                                healthB = healthB - 25;
                                puanb = 10 * bc + (100 - healthB) + puanb;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Survivor      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);


                            }
                            else
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("C won");
                                Console.WriteLine(" ");
                                healthB = 0;
                                healthC = healthC - 25;
                                puanc = (10 * bc + (100 - healthC)) + puanc;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Survivor      Health:" + healthC + "    Score:" + puanc);

                            }

                        }
                        else
                        {

                            
                            Console.WriteLine("Too distant, no attack");

                        }
                    }
                }
                //ac başlangıç

                else if (AC < AB && AC < BC && AC <= 15)
                {
                    Console.WriteLine("Round 1 : A-C");
                    Console.WriteLine("");
                    if (seta == "Set 3" && setc == "Set 2" || seta == "Set 2" && setc == "Set 1" || seta == "Set 1" && setc == "Set 3")
                    {
                        ses.SoundLocation = "Die Sound Effect.wav";
                        ses.Play();
                        Console.WriteLine("A won");
                        Console.WriteLine(" ");
                        healthA = healthA - 25;
                        healthC = 0;
                        puana = 10 * ac + (100 - healthA);
                        Console.WriteLine("A: Survivor      Health:" + healthA + "    Score:" + puana);
                        Console.WriteLine("B: Non-fighter   Health:" + healthB + "    Score:" + puanb);
                        Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);
                        Console.ReadLine();
                        if (AB <= 15)
                        {
                            Console.WriteLine("Round 2: A-B");
                            Console.WriteLine("");
                            if (seta == "Set 3" && setb == "Set 2" || seta == "Set 2" && setb == "Set 1" || seta == "Set 1" && setb == "Set 3")
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("A won");
                                healthB = 0;
                                healthA = healthA - 25;
                                puana = 10 * ab + (100 - healthA)+puana;
                                Console.WriteLine("A: Survivor      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);


                            }
                            else
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("B won");
                                healthA = 0;
                                healthB = healthB - 25;
                                puanb = (10 * ab + (100 - healthB)) + puanb;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Survivor      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);

                            }

                        }
                        else
                        {
                           
                            Console.WriteLine("Too distant, no attack");

                        }
                    }
                    else
                    {
                        ses.SoundLocation = "Die Sound Effect.wav";
                        ses.Play();
                        Console.WriteLine("C won");
                        Console.WriteLine(" ");
                        healthC = healthC - 25;
                        healthA = 0;
                        puanc = 10 * ac + (100 - healthC);
                        Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                        Console.WriteLine("B: Non-fighter   Health:" + healthB + "    Score:" + puanb);
                        Console.WriteLine("C: Survivor      Health:" + healthC + "    Score:" + puanc);
                        Console.ReadLine();
                        if (BC <= 15)
                        {
                            Console.WriteLine("Round 2: B-C");
                            Console.WriteLine("");
                            if (setb == "Set 3" && setc == "Set 2" || setb == "Set 2" && setc == "Set 1" || setb == "Set 1" && setc == "Set 3")
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("B won");
                                Console.WriteLine(" ");
                                healthC = 0;
                                healthB = healthB - 25;
                                puanb = 10 * bc + (100 - healthB) + puanb;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Survivor      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Defeated      Health:" + healthC + "    Score:" + puanc);


                            }
                            else
                            {
                                ses.SoundLocation = "Die Sound Effect.wav";
                                ses.Play();
                                Console.WriteLine("C won");
                                Console.WriteLine(" ");
                                healthB = 0;
                                healthC = healthC - 25;
                                puanc = (10 * bc + (100 - healthC)) + puanc;
                                Console.WriteLine("A: Defeated      Health:" + healthA + "    Score:" + puana);
                                Console.WriteLine("B: Defeated      Health:" + healthB + "    Score:" + puanb);
                                Console.WriteLine("C: Survivor      Health:" + healthC + "    Score:" + puanc);

                            }

                        }
                        else
                        {
                            
                            Console.WriteLine("Too distant, no attack");

                        }

                    }
                }

                else
                {
                    Console.WriteLine("There is no fight");
                    Console.WriteLine("TIE");
                }
                Console.WriteLine("");


                Console.ReadLine();
                ses.SoundLocation = "Victory-Sound-Effect.wav";
                ses.Play();
                if (puana > puanb && puana > puanc)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A has the maximum score: " + "(" + puana + ")");
                }
                else if (puanb > puanc && puanb > puana)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("B has the maximum score: " + "(" + puanb + ")");
                }
                else if (puanc > puana && puanc > puanb)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("C has the maximum score: " + "(" + puanc + ")");
                }
                else if (puana == puanb || puana == puanc || puanb == puanc)
                {
                    Console.WriteLine("There is a tie situaiton");
                    Console.WriteLine("TİE");
                }

                Console.ReadLine();
            }
            else
            {
                ses.SoundLocation = "Error-Sound-Effect-_HD_.wav";
                ses.Play();
                Console.WriteLine("!!ERROR!!");
                Console.WriteLine("Please enter values between (-10,10)");
                Console.ReadLine();
            }
        }
    }
}
