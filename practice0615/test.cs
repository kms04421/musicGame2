using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0615
{
    public class test
    {
        public void TEST()
        {
            

               
                int sizeX = 40;
                int sizeY = 40;
                int playerX = sizeX/2;
                int playerY = sizeY/2;
                string[,] player = new string[sizeX, sizeY];

             

                for (int y = 0; y < sizeY; y++) // Y
                {
                    for (int x = 0; x < sizeX; x++) // X 
                    {
                        if (x == 0)
                        {
                            player[x, y] = "│";
                        }
                        else if (y == 0)
                        {
                            player[x, y] = "──";
                        }
                        else if (sizeX -1 == x)
                        {
                            player[x, y] = "│";
                        }
                        else if (sizeY -1 == y)
                        {
                            player[x, y] = "──";
                        }
                         else
                        {
                            player[x, y] = "  ";
                        }
                      
                        if(x== 0 && y ==0)
                        {
                            player[x, y] = "┌";
                            }
                        if(x== 0 && y ==sizeX-1)
                            {
                            player[x, y] = "└";
                        }
                        if (x== sizeX-1 && y ==0)
                        {
                            player[x, y] = "┐";
                        }
                        if (x== sizeX-1 && y ==sizeX-1)
                        {
                            player[x, y] = "┘";
                        }
                }
                }

                while (true)
                {
                    player[playerX, playerY] = "♡";
             
                   
                    for (int y = 0; y < sizeY; y++)
                    {
                        Console.SetCursorPosition(10, y+10);
                        for (int x = 0; x < sizeX; x++)
                            {

                            Console.Write("{0}", player[x,y]);
                            }
                            Console.WriteLine();
                    }

                    player[playerX, playerY] = "  ";
                    ConsoleKeyInfo user = Console.ReadKey(true);

                    

                    switch (user.Key)
                    {
                        case ConsoleKey.RightArrow:
                            playerX++;
                            break;
                        case ConsoleKey.LeftArrow:
                            playerX--;
                            break;
                        case ConsoleKey.UpArrow:
                            playerY--;
                            break;
                        case ConsoleKey.DownArrow:
                            playerY++;
                            break;
                      
                    }

                }
            





        }


    }
}
