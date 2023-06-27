using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshap
{
    public class musicMap
    {



        public void GameMap(ref string[,] strArray)
        {

            Console.CursorVisible = false;

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 22; j++)
                {

                    if (j %5 == 0)
                    {
                        strArray[i, j] = "│ ";
                    }
                    else
                    {
                        strArray[i, j] = "  ";
                    }

                    if (i == 30)
                    {
                        strArray[i, j] = "─ ";
                    }

                }
            }



        }

        public void GameView(ref string[,] strArray)
        {


            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(4, i+2);
                for (int j = 0; j < 21; j++)
                {
                    if (j % 5 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{strArray[i, j]}");

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{strArray[i, j]}");

                    }


                }
                //Console.WriteLine();
            }




        }


        public void Demap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│──────────────────────────────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│        Q         W          E         R                                                  │");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────┘");

            
            //Console.CursorVisible = true;
            Console.ResetColor();
        }

        public void DrawScoreLine()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorVisible = false;
          
            Console.SetCursorPosition(6, 29);
            Console.Write("──────────────────────────────────────");

            Console.ResetColor();
        }




        public void Anim()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("________        ____.    _____                 ");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("\\______ \\      |    |   /     \\ _____  ___  ___");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine(" |    |  \\     |    |  /  \\ /  \\\\__  \\ \\  \\/  /");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine(" |    `   \\/\\__|    | /    Y    \\/ __ \\_>    < ");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("/_______  /\\________| \\___| |__  (____  /__/\\_ \\");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("        \\/                    \\/     \\/      \\/");
            Console.ResetColor();


        }


        public void musicMaunu()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                      ▲                                  │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                      ┌───────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│                      │                                                                 ┌─│");
            Console.WriteLine("│                      │                                                               ┌─┘ │");
            Console.WriteLine("│                      │                                                             ┌─┘   │");
            Console.WriteLine("│                      │                                                           ┌─┘     │");
            Console.WriteLine("│                      └───────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                  ┌───────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  └───────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                      ┌───────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                      │                                                           └─┐     │");
            Console.WriteLine("│                      │                                                             └─┐   │");
            Console.WriteLine("│                      │                                                               └─┐ │");
            Console.WriteLine("│                      │                                                                 └─│");
            Console.WriteLine("│                      └───────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                     ▼                                   │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────┘");
        }

        public void musicMaunuStart()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                      ▲                                  │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                        ┌─│");
            Console.WriteLine("│                                                                                      ┌─┘ │");
            Console.WriteLine("│                                                                                    ┌─┘   │");
            Console.WriteLine("│                                                                                  ┌─┘     │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                  ┌───────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  └───────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                      ┌───────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                      │                                                           └─┐     │");
            Console.WriteLine("│                      │                                                             └─┐   │");
            Console.WriteLine("│                      │                                                               └─┐ │");
            Console.WriteLine("│                      │                                                                 └─│");
            Console.WriteLine("│                      └───────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                     ▼                                   │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────┘");
        }
        public void musicMaunuLast()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                      ▲                                  │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                      ┌───────────────────────────────────────────────────────────────────│");
            Console.WriteLine("│                      │                                                                 ┌─│");
            Console.WriteLine("│                      │                                                               ┌─┘ │");
            Console.WriteLine("│                      │                                                             ┌─┘   │");
            Console.WriteLine("│                      │                                                           ┌─┘     │");
            Console.WriteLine("│                      └───────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                  ┌───────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  │                                                               │       │");
            Console.WriteLine("│                  └───────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                                                                                  │       │");
            Console.WriteLine("│                                                                                  └─┐     │");
            Console.WriteLine("│                                                                                    └─┐   │");
            Console.WriteLine("│                                                                                      └─┐ │");
            Console.WriteLine("│                                                                                        └─│");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                     ▼                                   │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("│                                                                                          │");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────┘");
        }

        public void catDance()
        {

        }

    }
}