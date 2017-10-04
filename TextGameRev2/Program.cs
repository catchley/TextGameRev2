using System;
using System.Linq;
namespace TextGame
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Player player = new Player();

            

            Console.WriteLine("Text Game.  Your objective is to find and get into the party.");
            Console.WriteLine("Press enter to begin.");

            Console.ReadLine();




            while (player.location != 40)
            {
                playerTurn(player);
                int[] dirtyAreas = new int[] { 1, 6, 24, 28, 31, 32, 37, 48 };

                if (dirtyAreas.Contains(player.location))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("***You made a mess, now you're filthy.***");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.isDirty = true;
                    //showStatus(player);
                }
                if((player.location == 34) && (player.hasBooze == true))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("***Party Foul!  You tripped, breaking your alcohol bottle and splashing it all over yourself and your clothes.***");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.isDirty = true;
                    player.hasBooze = false;
                    player.freshClothes = false;
                }

                if ((player.location == 50) || (player.location == 53))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("***Standing to close to the heat, you burn holes in your clothes.***");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.freshClothes = false;
                    //showStatus(player);
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You have entered the party.");
            Console.WriteLine("GAME OVER");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();



            


        }


        //Methods

        private static void showStatus(Player player)
        {
            Console.WriteLine("location:" + player.location);
            Console.WriteLine("has booze:" + player.hasBooze);
            Console.WriteLine("has keys:" + player.hasKeys);
            Console.WriteLine("fresh clothes:" + player.freshClothes);
            Console.WriteLine("is dirty:" + player.isDirty);
            Console.WriteLine("has blanket:" + player.hasBlanket);
        }


        private static void playerTurn(Player player)
        {

         int[] ableToMoveUp = new int[] {7,8,10,11,12,13,14,15,16,18,19,21,23,25,26,27,28,29,30,
                                            33,37,38,39,43,44,45,49,50,51,52,53,54 };

        int[] ableToMoveDown = new int[] {1,2,4,5,6,7,8,9,10,12,13,15,17,19,20,21,22,23,24,27,31,
                                                32,33,37,38,39,43,44,45,46,47,48 };

        int[] ableToMoveLeft = new int[] { 2, 3, 5, 6, 8, 11, 12, 14, 15, 16, 21, 22, 23, 24, 29, 30, 32,
                                            33, 34, 35, 36, 38, 39, 44, 45, 46, 47, 48, 50, 51, 53, 54 };

        int[] ableToMoveRight = new int[] {1,2,4,5,7,10,11,13,14,15,20,21,22,23,28,29,31,32,33,
                                                34,35,37,38,43,44,45,46,47,49,50,52,53};

            Console.WriteLine("Press l, r, u, d, or s then enter to move left, right, up, down, or perform search/action.");
            string entry = Console.ReadLine();
            if (entry == "l")
            {
                if (ableToMoveLeft.Contains(player.location))
                {
                    player.moveLeft();
                }
                else
                {
                    Console.WriteLine("///Sorry, that direction in blocked.///");
                }

                //Console.WriteLine("moved left");
                //Console.WriteLine("your current location is "+ newLocation);
                //showStatus(player);
                //return newLocation;
            }
            else if (entry == "r")
            {
                if (player.location == 39)
                {
                    if (player.hasKeys == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("  ##  There is a sign that says PARTY HERE, but the door is locked.");
                    }
                    else if (player.hasBooze == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("  ##  You can't go to a party without some alcohol.");
                    }
                    else if (player.freshClothes == false)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("  ##  Are you kidding?  Nobody gets into this party with burnt up clothes.");
                    }
                    else if (player.isDirty)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("  ##  Dude, you're filthy.  Go get cleaned up!");
                    }
                    else
                    {
                        player.moveRight();
                    }

                }
                else if (ableToMoveRight.Contains(player.location))
                {
                    player.moveRight();
                }
                else
                {
                    Console.WriteLine("///Sorry, that direction in blocked.///");
                }
                //Console.WriteLine("moved right");
                //Console.WriteLine("your current location is " + newLocation);
                //showStatus(player);
                //return newLocation;
            }
            else if (entry == "u")
            {
                if (ableToMoveUp.Contains(player.location))
                {
                    player.moveUp();
                }
                else
                {
                    Console.WriteLine("///Sorry, that direction in blocked.///");
                }
                //int newLocation = moveUp(currentLocation);
                //Console.WriteLine("moved up");
                //Console.WriteLine("your current location is " + newLocation);
                //showStatus(player);
                //return newLocation;
            }
            else if (entry == "d")
            {
                if (ableToMoveDown.Contains(player.location))
                {
                    player.moveDown();
                }
                else
                {
                    Console.WriteLine("///Sorry, that direction in blocked.///");
                }
                //Console.WriteLine("moved down");
                //Console.WriteLine("your current location is " + newLocation);
                //showStatus(player);
                //return newLocation;
            }
            else if (entry == "s")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Searching");

                if (player.location == 20)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!You found some keys!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.hasKeys = true;

                }

                else if ((player.location == 3) || (player.location == 17) || (player.location == 18))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!You swapped for some fresh clothes, spiffy!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.freshClothes = true;
                }
                else if (player.location == 54)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!You grabbed yourself a case of beer!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.hasBooze = true;
                }
                else if (player.location == 9)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!You found a super cozy blanket!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.hasBlanket = true;
                }
                else if (player.location == 52)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!You find a bottle of liquor!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.hasBooze = true;
                }

                else if ((player.location == 25) || (player.location == 26))
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("!!!You got yourself all cleaned up!!!");
                    Console.WriteLine();
                    Console.WriteLine();
                    player.isDirty = false;
                }
                else if ((player.location == 7) || (player.location == 4) || (player.location == 5) || 
                         (player.location == 29) || (player.location == 30))
                {
                    if (player.hasBlanket == false) {
                        Console.WriteLine("This looks like a good place to sleep.");
                        for (int a = 30; a >= 0; a--)
                        {
                            Console.CursorLeft = 22;
                            Console.Write("Sleeping {0} ", a);
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("This looks like a good place to sleep...and my cozy blanket will make it much better.");
                        for (int a = 60; a >= 0; a--)
                        {
                            Console.CursorLeft = 22;
                            Console.Write("Sleeping {0} ", a);
                            System.Threading.Thread.Sleep(1000);
                            player.hasBlanket = false;
                        }
                    }
                }


                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("---You found nothing.---");
                    Console.WriteLine();
                    Console.WriteLine();
                }


                //return currentLocation;


            }
            else
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine();
                Console.WriteLine();
                //return currentLocation;
            }


        }

        



    }
}