using System;

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
                    if (strArray[i, j] == "│ ")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{strArray[i, j]}");

                    }
                    else if (strArray[i, j] == "==")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{strArray[i, j]}");

                    }
                    else
                    {
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

            Console.SetCursorPosition(6, 28);
            Console.Write("──────────────────────────────────────");

            Console.ResetColor();
        }




        public void Anim()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine(@"________        ____.    _____                 ");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine(@"╲______ ╲      |    |   /     ╲ _____   ___  ___");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine(@" |    |  ╲     |    |  /  ╲ /  ╲╲__  ╲  ╲  ╲/  /");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine(@" |    `   ╲/╲__|    | /    Y    ╲/ __ ╲_ >    < ");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine(@"/_______  /╲________| ╲___| |__  (____  /__/╲_ ╲");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine(@"        ╲/                     ╲/     ╲/      ╲/");
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
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────────────┘");
        }
        public void cursor()
        {
            Console.SetCursorPosition(55, 5);
            Console.WriteLine("▲");
            Console.SetCursorPosition(55, 30);
            Console.WriteLine("▼");
        }
        public void selectmenu()
        {
            int Y = 22;
            Console.SetCursorPosition(23, 30-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────");
            Console.SetCursorPosition(23, 31-Y);
            Console.WriteLine("│                                                                 ┌─");
            Console.SetCursorPosition(23, 32-Y);
            Console.WriteLine("│                                                               ┌─┘ ");
            Console.SetCursorPosition(23, 33-Y);
            Console.WriteLine("│                                                             ┌─┘   ");
            Console.SetCursorPosition(23, 34-Y);
            Console.WriteLine("│                                                           ┌─┘     ");
            Console.SetCursorPosition(23, 35-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(83, 36-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(19, 37-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(19, 38-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 39-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 40-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 41-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 42-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(83, 43-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(23, 44-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(23, 45-Y);
            Console.WriteLine("│                                                           └─┐     ");
            Console.SetCursorPosition(23, 46-Y);
            Console.WriteLine("│                                                             └─┐   ");
            Console.SetCursorPosition(23, 47-Y);
            Console.WriteLine("│                                                               └─┐ ");
            Console.SetCursorPosition(23, 48-Y);
            Console.WriteLine("│                                                                 └─");
            Console.SetCursorPosition(23, 49-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────────────");
        }
        public void musicMaunuStart()
        {
            int Y = 22;

            Console.SetCursorPosition(89, 31-Y);
            Console.WriteLine("┌─");
            Console.SetCursorPosition(86, 32-Y);
            Console.WriteLine(" ┌─┘ ");
            Console.SetCursorPosition(85, 33-Y);
            Console.WriteLine("┌─┘   ");
            Console.SetCursorPosition(83, 34-Y);
            Console.WriteLine("┌─┘     ");
            Console.SetCursorPosition(83, 35-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(83, 36-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(19, 37-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(19, 38-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 39-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 40-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 41-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 42-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(83, 43-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(23, 44-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(23, 45-Y);
            Console.WriteLine("│                                                           └─┐     ");
            Console.SetCursorPosition(23, 46-Y);
            Console.WriteLine("│                                                             └─┐   ");
            Console.SetCursorPosition(23, 47-Y);
            Console.WriteLine("│                                                               └─┐ ");
            Console.SetCursorPosition(23, 48-Y);
            Console.WriteLine("│                                                                 └─");
            Console.SetCursorPosition(23, 49-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────────────");
        }
        public void musicMaunuLast()
        {
            int Y = 22;
            Console.SetCursorPosition(23, 30-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────");
            Console.SetCursorPosition(23, 31-Y);
            Console.WriteLine("│                                                                 ┌─");
            Console.SetCursorPosition(23, 32-Y);
            Console.WriteLine("│                                                               ┌─┘ ");
            Console.SetCursorPosition(23, 33-Y);
            Console.WriteLine("│                                                             ┌─┘   ");
            Console.SetCursorPosition(23, 34-Y);
            Console.WriteLine("│                                                           ┌─┘     ");
            Console.SetCursorPosition(23, 35-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(83, 36-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(19, 37-Y);
            Console.WriteLine("┌───────────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(19, 38-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 39-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 40-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 41-Y);
            Console.WriteLine("│                                                               │       ");
            Console.SetCursorPosition(19, 42-Y);
            Console.WriteLine("└───────────────────────────────────────────────────────────────│       ");
            Console.SetCursorPosition(83, 43-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(83, 44-Y);
            Console.WriteLine("│       ");
            Console.SetCursorPosition(83, 45-Y);
            Console.WriteLine("└─┐     ");
            Console.SetCursorPosition(85, 46-Y);
            Console.WriteLine("└─┐   ");
            Console.SetCursorPosition(87, 47-Y);
            Console.WriteLine("└─┐ ");
            Console.SetCursorPosition(89, 48-Y);
            Console.WriteLine("└─");

        }

        public void musicMaunuSwap()
        {

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
            Console.WriteLine("│                   ┌──────────────────────────────────────────────────────────────┌─┘     │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   └──────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                   ┌──────────────────────────────────────────────────────────────│       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   │                                                              │       │");
            Console.WriteLine("│                   └──────────────────────────────────────────────────────────────└─┐     │");
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

        public void CoookTime()
        {
            int Y = 29;
            int x = 2;
            Console.SetCursorPosition(x, 30-Y);
            Console.WriteLine("            ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 31-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠡⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠀⠀⠀⠀⠀⢠⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         ");
            Console.SetCursorPosition(x, 32-Y);
            Console.WriteLine("⣷⢿⣽⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⠀⠀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        ");
            Console.SetCursorPosition(x, 33-Y);
            Console.WriteLine("⣿⣿⠛⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⢀⠐⠁⠀⠀⠀⠀⠊⠁⠀⠂⠀⠠⠀⠀⠀⠄⠄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       ");
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⣿⣧⣀⣤⣤⣬⡀⢀⣤⣾⣿⣧⣶⣦⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠠⣤⣄⣀⠀⠀⠀⠀⠀⠀⠀⠒⠀⠀⣠⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣅⣠⣿⣻⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⡋⠸⣿⣿⣿⡄⠀⠀⠀⠀⠀⣀⣤⣾⣿⣿⣿⣷⣦⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣻⣿⣶⣿⣿⣿⢿⣿⣿⣦⡀⢀⠰⣴⣶⣾⣾⣦⣰⠛⢶⣯⠉⠀⠁⢀⣀⢀⣤⣿⣿⠿⢿⣿⣿⣿⣿⠿⠗⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠿⠿⢶⣿⣿⣿⣿⣯⣽⣿⣿⣿⣿⣿⣿⠎⣿⣿⠃⠀⢠⣏⣻⣿⣿⡿⠋⠟⠛⠟⣿⣿⣿⡄⡀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣾⣿⡵⠂⠀⡀⢈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣿⣿⣧⣿⣿⣿⢿⣿⣤⣦⣂⣠⣤⢬⣽⣿⣷⣿⣷⣦⣤⠀⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⣿⣽⣿⣿⣿⣿⣿⠿⠙⠃⠀⠈⠓⣴⣿⣿⣿⣿⣿⣿⣿⣷⣾⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⡄⡀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣯⡄⠀⠀⠀⠀⠀⠙⣻⠿⠿⠿⢿⣿⣿⣿⣿⡯⡀⣿⣿⣿⣿⣿⣿⣿⣿⣯⠟⠁⣠⡲⠡⣼⣿⣼⣿⣿⣿⣿⣥⢻⣿⣿⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣷⣿⠈⠆⠀⠀⠠⠀⠈⢀⣀⣀⣀⡀⠀⠙⣿⣿⣧⡅⣤⣀⣸⣿⣿⣿⣿⣿⣏⣀⣿⣿⣤⢶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡷⡀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣟⠛⣸⣾⣷⣴⣶⣿⣿⣿⣿⣿⣷⢐⣘⣿⣷⣖⡟⡿⠿⣿⣿⣿⣿⢿⣏⠼⠺⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⣿⣛⡙⠛⣷⣄⣀⠀");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⠛⣿⣿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⡿⠅⣹⣿⠟⠉⠁⠀⠀⠀⢣⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣾⣿⣿⣶⣷⣾⣿⣿⣿⣿⣿⣶⣿⣷⣿⣧ ");
            Console.SetCursorPosition(x, 44-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣇⠈⠻⢿⣿⣽⣿⣠⣿⣿⣿⣿⣿⡟⢻⣿⣋⡀⣺⠇⠈⠠⠀⠈⣿⣏⠻⣯⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⠿⠿⠟");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⡿⡿⣷⣄⠀⠙⠿⠋⢙⣿⣿⣿⡿⣿⣿⣷⣿⣿⣿⣧⣀⣀⣀⣠⣼⣿⢿⣿⣿⣿⣿⣿⣿⣧⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢟⣼⣂⠀⠀ ");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣄⣙⣿⣷⣤⠀⠈⠻⣿⣿⠏⠀⢨⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣈⠻⣿⣿⣿⣿⣿⣿⣿⣯⣾⡿⠐⠀⠀ ");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⠇⠀⠸⣿⣿⣿⣦⣄⠈⠁⠀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡃⣹⣿⣿⣿⣿⣿⠿⠛⣷⣌⠻⣿⣿⣿⢿⣿⣿⣿⡿⠄⠀⠀ ");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⡄⠀⢀⠘⣿⣿⣿⣿⣷⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣂⣛⢿⣿⣿⣿⣿⡀⠄⠘⣿⣶⡈⠛⠁⡀⠛⢿⠿⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⡿⣦⠀⠀⣿⣿⣿⣿⣿⣿⠛⠛⠛⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⡾⢿⣿⣿⣿⣿⣬⠀⣿⣿⣷⡇⢰⡷⣦⡈⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⡟⠑⣴⣼⣿⣿⠟⠋⠁⠀⠀⠈⣿⣿⠿⠍⡉⠉⡉⠟⠿⣿⣿⣿⣿⣿⠿⢿⠷⣿⣿⣿⣿⣿⡝⣷⣿⣷⣿⡄⠆⠀⠙⠂⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣥⣤⣽⣿⣿⣿⣯⠀⠄⠀⠀⠀⠀⠙⠋⠳⠉⢁⠀⠀⣿⣀⢸⣿⣿⣿⣿⣿⣾⣾⣿⣿⣿⣿⣿⣿⣿⣿⠁⠙⠃⠠⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⣿⣷⡆⠀⠀⠀⠀⠛⢿⡀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⣿⣷⣿⡭⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠙⠋⠀⠀⠀⠀⠠⠀⢻⡇⠼⣿⡿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣖⣶⣦⢀⡀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣨⡏⠀⣬⡧⣿⠈⢹⣿⣿⣿⣿⣿⣿⣿⣿⠛⠙⠀⠘⠛⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⢽⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠺⡇⠈⠛⠉⡿⠀⢷⣿⣿⣿⣿⣿⡿⣿⣿⡇⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⣯⣿⣿⠿⢇⠿⣭⣅⣿⣿⣿⡿⠷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠙⠉⠹⠋⢠⣾⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 57-Y);
            Console.WriteLine("⠻⡄⠹⡆⠈⠀⠸⠟⠁⠛⠛⠧⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        ");

        }

        public void Rinneinfinite()
        {
            int Y = 31;
            int x = 1;


            Console.SetCursorPosition(x, 32-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⣲⣾⣿⣿⣷⣶⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       ");
            Console.SetCursorPosition(x, 33-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⢀⣀⣀⢉⠿⢿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢀⢾⣷⣿⣿⣿⣧⣶⣦⣄⣉⣛⠿⣿⣿⣿⣿⣷⡀⠀⠀⠀⢀⣠⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠈⡾⣿⣿⡿⣽⣿⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠀⢀⡠⠚⠉⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠛⡏⡁⢿⠸⠃⠟⠺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠈⠀⠀⢉⡁⢎⠛⣿⣿⣿⣿⣿⣿⡿⠉⠀⠀⠀⠀⠀⠀⣀⠀⢀⣀⢠⣤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠛⠁⠀⠸⠛⠉⣿⣿⡿⠁⠀⠀⢠⣴⡾⠿⠛⠛⠉⠙⠻⣾⣿⣷⠄⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⣿⣿⣶⣾⣿⠟⠋⠀⢀⣀⣀⡀⠀⠀⠈⠘⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣩⡉⠀⠉⠉⠁⠀⠀⠀⠐⠾⢟⢛⣛⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀       ");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣔⣿⡯⡻⢦⡀⠀⠀⠀⠀⢠⣴⣾⣿⡟⢿⠻⣿⣿⡅⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡠⡤⠀⢀⣽⠿⣛⣼⡿⡽⡲⣀⣠⠀⢸⣿⠑⡙⠁⠀⠂⠘⢹⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⢀⣴⣟⣮⣷⣇⣿⣿⣫⣾⣿⡟⠀⠀⠉⠀⠀⠀⠀⢀⣐⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 44-Y);
            Console.WriteLine("⠀⠀⠀⣠⣶⡶⠰⠀⠀⣶⠉⠈⠀⠀⠀⢠⢿⣿⣷⣫⣿⠟⠛⡻⠟⣿⣍⣽⣦⠀⠐⠶⣼⡇⠀⣸⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⠀⠀⠀⠉⠀⠀⠀⢀⠀⠀⠀⠀⠀⠀⠀⠞⢺⣿⣿⣿⣾⣄⡀⠀⣀⡯⣻⣿⡿⠂⠀⠀⣨⣧⣾⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⠀⡄⠀⠀⠀⢠⣴⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠻⣿⣿⢽⣿⣻⣟⣹⣯⢿⠟⠁⠀⠀⢰⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⠀⠁⠀⠀⡄⣿⠉⠀⠃⠀⠀⠀⠷⣷⣴⣄⣀⠀⠈⠱⠣⢿⣿⣟⢿⣿⠁⠀⠀⠀⠀⣾⣿⣿⣟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⠀⠀⢀⢰⣷⡟⠀⠀⡐⠀⡔⠁⠀⠈⠻⣿⡿⠿⡳⢤⠀⠀⠈⡺⠋⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⠀⠀⢸⣞⡟⠀⠀⠀⠠⠀⠀⠀⠀⠀⠀⠀⢻⡯⣿⣿⣦⣄⣰⡷⣦⡀⠀⠀⠀⠀⣾⣿⣿⣿⣟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⠀⢸⣼⣿⣧⠀⠀⠀⠀⠂⠀⠀⠀⠀⠀⠀⠀⢑⣿⣿⡿⠟⠋⠀⠀⠙⠈⢷⣄⠼⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⠀⡸⣿⣿⣿⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⢘⣛⣉⢁⣀⡠⠀⠀⠀⠀⠀⣠⣿⣿⣶⣽⣛⡻⡇⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀      ");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⠀⢹⣿⣿⡏⠀⠀⠀⣤⣴⣶⣶⠶⠶⠶⠟⠛⠛⠛⠉⠀⠀⠀⢀⣠⣴⣿⣿⣿⣿⣿⣿⣿⣿⣦⠠⡄⠀⠀⠀⠠⡀⠁⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⠀⢸⣿⣿⣷⡀⠀⠀⠉⠋⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠝⣿⣖⡤⡀⠓⠂⠤⡀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡇⠀⠀⠀⠐⠁⠀⠀⠀⢀⣠⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠈⠙⡁⠀⠀⢀⠿⡷⣦⣤⣀⡀   ");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⠀⢰⣿⣿⣿⡇⠀⠀⠀⠀⠀⣠⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⠦⡐⣽⣿⣇⠃   ");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⠀⠸⠛⢿⣿⣧⠀⠀⠀⠰⣿⣿⣿⣿⠿⠿⠿⢿⡿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⣰⣦⣶⣆⠀⠈⠿⣽⡠   ");
            Console.SetCursorPosition(x, 57-Y);
            Console.WriteLine("⠀⠀⠀⠘⣿⣿⣧⠀⠀⠀⢸⣿⣿⡿⠐⣶⡆⠰⣶⡶⠶⣶⡶⠀⣶⡶⠶⣶⡶⠶⢶⣶⢸⣿⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣄⠀⠀⢸⣿   ");
            Console.SetCursorPosition(x, 58-Y);
            Console.WriteLine("⠀⠀⠀⠀⠘⣿⣟⠀⠀⠀⠈⣿⣿⡇⠸⣿⡿⢚⣛⣓⣚⣛⣓⠀⣿⡷⠶⣿⡷⠶⢾⣿⠀⣤⣤⣤⣤⣤⣤⠀⢸⣿⣿⣿⣿⣿⣆⠀⠈⣿  ");
            Console.SetCursorPosition(x, 59-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⣉⣤⣶⣶⣶⣦⣄⠙⣿⡇⣿⡇⢸⣿⠿⠿⢿⣿⠀⣛⣿⡿⠟⠻⢿⣿⣛⠀⣿⠀⣼⡏⢸⣿⠀⣾⣿⣿⣿⣿⣿⢿⠂⠀⠘  ");
            Console.SetCursorPosition(x, 60-Y);
            Console.WriteLine("⠀⠀⣤⣶⡿⠟⠋⠙⠛⢿⣿⣿⣷⡈⢠⣿⠷⢈⣿⠏⢹⣯⣭⠘⠋⣹⣿⠀⠀⣿⡏⠙⠃⣿⣴⣿⠁⣼⣿⢠⣿⣿⣿⣿⣿⣿⠘⠲⡔⣄ ");
            Console.SetCursorPosition(x, 61-Y);
            Console.WriteLine("⠀⠀⠀⠐⣶⣶⣶⡖⠀⢸⣿⣿⣿⠇⢤⣤⣤⣭⡌⢀⣀⣀⣌⡀⠀⠁⣅⣀⠈⢭⣥⣤⣤⡀⠀⠠⣤⣤⠄⣈⣭⣭⣭⣉⣉⣭⣥⡄⣰⣾  ");
            Console.SetCursorPosition(x, 62-Y);
            Console.WriteLine("⠀⠀⠀⠀⣿⣿⣿⡇⠀⣸⣿⡿⠃⠀⢸⣿⣿⣿⠀⠀⣿⣿⣿⣿⣄⠀⢻⣿⠀⢸⣿⣿⣿⣿⣄⠀⣿⡏⠀⢹⣿⣿⣿⠉⠉⠉⠙⠀⣿⣿   ");
            Console.SetCursorPosition(x, 63-Y);
            Console.WriteLine("⠀⠀⠀⠀⣿⣿⣿⣿⠿⢿⣿⣦⣀⠀⢸⣿⣿⣿⠀⠀⣿⡇⠙⣿⣿⣷⣼⣿⠀⢸⣿⡏⠻⣿⣿⣶⣿⣇⠀⢸⣿⣿⣿⠶⠶⠶⢾⠀⠸⣿  ");
            Console.SetCursorPosition(x, 64-Y);
            Console.WriteLine("⠀⠀⠀⠀⣿⣿⣿⡏⠀⠀⠻⣿⣿⣧⣸⣿⣿⣿⠀⠀⣿⡇⠀⠈⢿⣿⣿⣿⠀⢈⣿⡇⠀⠙⢿⣿⣿⣷⠀⢼⣿⣿⣿⠀⠀⠀⢀⣠⠀⠙   ");

        }

        public void CROSSOVER()
        {
            int Y = 33;
            int x = 2;
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⣶⣾⣿⣿⡂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⣾⡯⣿⣿⡿⡛⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡴⣠⣴⣫⠛⠛⣿⡿⠏⠛⢷⣀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣾⣿⣶⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣯⣴⡋⡙⡇⠀⠀⠈⢿⣆⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠛⠻⣿⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠰⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⢿⡾⢹⣼⣿⡆⡇⢰⡀⡀⠈⢿⡇⠀⠀");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣷⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⡏⠀⠀⢀⣀⠠⣤⣀⡀⠀⠀⣰⣿⣿⣿⡏⠘⠁⠀⠉⠈⠀⠁⠋⣷⠃⠀⠘⠁⠀⠀");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⡆⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣀⣤⡞⠛⠿⢿⣿⣿⣿⣦⡈⠻⢿⣿⣿⣿⠀⠀⠀⠀⠀⠀⣠⣴⣯⣿⣥⢠⠀⠂⠀");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣧⠀⠀⠀⠀⢰⣿⣿⣿⣿⣿⣿⣿⣄⡀⠀⠀⢹⣿⣿⣿⣿⣗⠲⣿⣿⣿⣆⠀⠈⠀⠀⠀⢹⣿⣿⣿⠫⣿⣿⠀⠀");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⢹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠉⠀⠙⢿⣿⣿⣶⣿⣿⣿⣿⣿⣶⣶⣶⣾⣿⣿⣿⡿⣼⣿⡟⠀");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⠀⠀⠀⠀⠈⠻⠿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠑⢄⣠⠀⠻⣿⣿⣿⣿⣿⡿⣯⣿⣿⣿⣿⣽⡿⣿⣃⡾⠋⠀⠀");
            Console.SetCursorPosition(x, 44-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡀⢀⣠⣤⣤⣶⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⣀⣴⣿⡆⠀⠙⣿⣿⣿⣿⡇⠘⣿⡿⠥⣾⣥⡺⣿⠏⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⡷⠚⠟⠿⢿⣿⣿⣿⣿⣿⢻⣇⠀⢀⣠⣾⣿⣿⣿⣿⣦⣴⣿⣿⣿⡿⠁⠀⡸⠇⠀⠀⠀⠴⠁⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⠋⠀⠀⠀⠀⠀⠁⠈⠛⠛⠃⢄⣇⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣷⣆⡀⠀⠀⠀⠀⠀⠀⢀⣀⡀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⢸⣿⣿⣿⣿⡟⠀⠀⣀⣤⣴⣾⣿⣿⣿⣆⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣆⠀⠀⠀⠀⠀⠀⠀⠞⠀⠀⠀⠫⣿⣿⣿⣿⣿⣿⡟⠁⠀⠀⢸⣿⣿⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⡿⠛⠃⠀⠀⠀");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣤⣤⣤⣤⣤⣤⣤⣤⣤⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠻⣿⣿⣿⡟⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠁⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣿⣇⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⠿⠟⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⢿⣻⣦⠀⠀⠀⠀⠀⢀⠀⠀⠀⢠⣿⠟⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠿⠿⢿⣿⣿⠿⠋⠀⠀⠀⠻⠿⣿⣷⣶⣶⣏⣉⠀⠀⣠⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣄⣾⣿⠿⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⠀⠀⠐⠄⠀⠀⠀⠀⠀⠀⢀⣀⡴⢁⡤⠆⠐⠋⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠲⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⠀⠀⠀⢸⣷⣤⣄⣠⣤⡤⠞⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 57-Y);
            Console.WriteLine("⠀⣀⣠⣾⣿⣿⠟⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 58-Y);
            Console.WriteLine("⠿⠿⠟⠋⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 59-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 60-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⡿⠟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 61-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⠟⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 62-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 63-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 64-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 65-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣀⣠⣾⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");



        }
        public void NIGHTDANCERMV()
        {
            int Y = 27;
            int x = 2;

            Console.SetCursorPosition(x, 31-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠋⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 32-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⡻⡈⢿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 33-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣇⠀⠈⠿⢿⣿⣿⣿");
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠃⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⠆⢡⡀⡀⠘⢿⣿⣄");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⡆⠈⢻⣿⣧");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢡⡀⠈⣿⣿");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣷⡀⠸⣿");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠋⢁⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⣌⣿⣿⣶⣤⣄⠀⠀⠀⠀⠀⠀⣰⣧⣿⣷⡄");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣾⣆⡀⠀⠀⠘⢿⡟⣿⣿⣿");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠉⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⣻⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠸⣷⣸⣿⣿⣿");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⡟⠋⠹⣿⣿⣿⣿⠟⠛⠛⠛⠿⠿⠿⠿⠟⠁⠀⠀⣠⣶⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣴⣶⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⠀⠀⢰⠃⠀⢀⣿⣿⡿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⡿⠋⠉⠉⠛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⣤⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⡁⡾⠀⠀⣸⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⠃⠚⣻⣿⣷⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 44-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⡜⣼⠇⠀⢠⣿⡃⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣤⣀⣠⣿⡇⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣿⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⢀⣠⣤⣤⣤⣤⣼⣿⣟⠀⠀⠀⢀⣼⣿⣿⣿⣿⣿⡏⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠈⢉⠛⢿⣿⣿⣿⣿⣿⣄⣀⣴⣿⣿⣿⣿⣿⣿⡏⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿ ");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢟⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠸⣷⣶⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⣿⣿⣿⣿⣿⣿⡟⣁⣼⣿⣿⡟⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠈⠛⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⣽⣿⠇⠀⠀⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⡛⢿⣿⣿⣷⢅⣶⣶⣶⣿⣿⣿⠏⠀⢻⣿⣿⣿⣷⠟⢿⣿⣿⣿⣿⣿⣶⣦⣤⣤⣤⣬⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣡⠖⠋⠁⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣻⣿");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡶⠓⣟⣿⣿⡏⣿⣿⣿⣿⡿⠁⠂⠀⢸⣿⣿⣿⠏⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠉⣤⡟⣿⣿⣿⣿⣯⣴⡆⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⢹⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⣿⣿⣿⠀⡟⠛⠻⠛⠻⡟⠛⠻⠟⠛⠻⠟⠛⠻⣿⡶⠋⢹⣿⡵⣿⣿⣿⠏⠀⠀⠀⠀⢸⣿⠉⠟⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⠿⠿⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⣿⣿⣿⠀⡇⢸⠀⣾⠀⠃⠭⠀⠤⠍⠘⠀⠭⠤⣿⣷⡦⠟⣷⣹⣿⣿⣋⠄⠀⠀⠀⠀⢸⣿⡆⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣟⠉⠁⢿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⣿⣿⣿⣶⣷⣾⣶⣿⣶⣷⣶⣶⣷⣶⣾⣷⣦⣾⣿⣿⣇⠟⣶⣿⣿⡿⠃⠀⠀⠀⠀⠀⣿⢿⡇⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⣿⢿⡇⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⢸⣿⣿⣿⠀⠀⢀⢱⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⣿⣿⣿⡏⠉⢻⣿⠉⢹⠉⢹⠟⠉⣀⣀⠉⢻⡇⠈⣿⣿⠀⢀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⢸⣿⠁⠀⢹⣿⠁⢸⠟⠁⣀⡀⠈⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣆⠀⠀⠐⠀⠀⠘⣿⣿⣿⣂⠠⡼⡿⣿⣿⣿⣿⣿");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⣿⣿⣿⡇⠀⡀⠹⠀⢸⠀⢸⠀⢸⣿⠛⠒⠚⡇⠀⠛⠛⠀⢸⠟⠀⠀⡄⠀⡠⠀⠀⠀⠘⡄⠀⠉⢀⡆⠀⣿⠀⠀⡀⠻⠀⢸⠀⢸⡟⠁⠀⠀⠀⠀⠒⠐⠀⠀⠀⠀⠀⢀⣾⣿⣤⣄⠀⠀⠀⠀⣿⣿⣿⡇⣊⠍⣿⣿⡿⣛⣵⡿⣻");
            Console.SetCursorPosition(x, 57-Y);
            Console.WriteLine("⣿⣿⣿⡇⠀⣷⡀⠀⢸⠀⢸⡀⠘⠿⠶⠂⠀⡇⠀⣿⣿⠀⢨⣠⡄⠀⣧⣼⣁⡀⠀⠤⠄⠁⠀⠀⠀⢀⡀⠈⠀⠀⣷⡀⠀⢸⡀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣛⠹⣿⣿⣧⠀⠀⠂⣿⣿⣿⣯⣶⠿⢋⡵⠚⢕⣿⣾⣿");
            Console.SetCursorPosition(x, 58-Y);
            Console.WriteLine("⣿⣿⣿⣧⣴⣿⣿⣤⣼⣤⣼⣿⣦⣤⣤⣦⣤⣧⣤⣿⣿⣤⣼⣿⣧⣤⣿⣿⣿⣧⣤⣤⣤⣶⣤⣠⣿⣶⣥⣄⣠⣤⣿⣷⣤⣼⣿⣦⣤⣤⣠⣦⣤⣤⢀⠀⠀⠀⠠⠊⢀⠀⢐⣾⣿⣿⣿⣶⣷⣷⣿⣿⣿⣟⡡⠞⠉⣠⣴ ");
            Console.SetCursorPosition(x, 59-Y);
            Console.WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⡻⠿⣿⣿⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⡏⠀⠀⠀⠀⠘⡂⣢⡞⠁⣫⣿⣿⣿⣿⠟⢋⣥⡾⠏⢀⣠⣾⣿⣿⣿");

        }

        public void RADWIMPS()
        {
            int Y = 33;
            int x = 1;
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⠀⠀⠀⠀   ⠀⠀⠀ ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⣤⣀⣤⣤⣶⣶⣾⣿⣶⢦⣤⣶⣶⣶⣦⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠟⠻⢿⣿⣿⡿⢿⣿⡿⠉⠀⢸⣿⣿⣿⠟⠫⣻⡷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠂⠤⣤⣴⣿⡟⠀⠀⠀⢸⣿⣯⡈⠀⠈⠊⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠉⠀⠀⠀⠀⢀⣹⣿⣷⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⠀⠄⠀⠈⢿⣿⣿⣿⣏⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⡌⢧⠀⠀⠀⠈⠻⣿⣿⣟⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢁⠀⢸⠋⠹⠞⠗⢶⠆⠄⠀⢺⣿⣷⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠂⠀⠀⠀⢀⠁⠈⠀⠀⠈⢀⡿⢿⣧⠀⣾⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡉⠉⠲⡄⠀⣀⡂⠀⠀⠀⠀⠀⠈⣷⣿⣿⣶⡿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠴⠋⢉⣙⣀⡀⠀⠹⣿⣿⣶⣤⣀⠀⠀⠈⠻⠟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 44-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⢀⣾⣿⣿⣿⣤⣤⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣾⣥⣀⣀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⢿⢿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠈⢆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣺⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣷⣦⣄⣀⣀⡀⠀⠀⠀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⠿⠿⢿⣿⣿⣿⣿⣿⣷⣮⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⠟⠁⠀⠀⠀⠀⠈⠉⠛⠻⢿⣿⣿⣿⡿⠁⠀⠈⠉⠁⠘⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠀⠀⠀⠀⠀⠀⠀⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⡀⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⡇⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣧⡤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 57-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣷⣶⣶⣤⣤⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 58-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⣷⠀⠀⠀⠀⠀⠀⠀⠉⠉⣭⡿⠟⠉⠀⠀⠀⠈⠉⠙⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ");
            Console.SetCursorPosition(x, 59-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣦⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 60-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⠿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀    ");
            Console.SetCursorPosition(x, 61-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⠿⠏⠁⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 62-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ");
            Console.SetCursorPosition(x, 63-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⡶⠀⠀⠀⠀⠒⠒⣲⠖⠀⠠⡤⠤⣤⢹⠂⡇⢠⡖⠓⣆⠀⡇⠀⠀⠀⢹⡉⣉⣿⠀⠐⡶⠒⠒⠀⣿⠀⠀⣠⢴⡛⠤⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 64-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠠⠔⠉⠉⠒⠦⠀⠠⠔⠊⠉⠒⠦⠀⣇⣀⣟⢹⠀⡇⡀⢙⣚⣁⠠⡇⠀⠀⠤⠬⠭⣤⠐⠲⠆⠷⠴⠒⠂⡏⠉⠦⣤⣄⣓⣒⠒⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 65-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠤⠤⠀⠒⠒⠒⠒⠦⠤⠀⠒⠒⠒⠂⠁⠀⠀⠜⢀⠇⠈⠉⠀⠀⢀⠇⠀⠀⠀⢹⣂⣃⣀⡀⠀⠀⢹⣀⣀⣁⡀⠀⠈⠁⠀⣸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");


        }
        public void Dangerously()
        {
            int Y = 30;
            int x = 1;

            Console.SetCursorPosition(x, 31-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣠⣄⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 32-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 33-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⢶⢗⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣽⡆⠉⠑⢹⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠛⠛⠛⠿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⡍⢀⣤⣾⣧⢖⣙⣿⣿⣿⣿⣿⡿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣿⣟⡯⢐⡰⣠⡏⣷⣹⣽⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢱⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣷⢵⣞⡿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣷⣿⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⠠⢴⣶⣄⣦⣾⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⠀⠀⠀⠐⠀⠀⣀⣤⠀⠀⠉⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡏⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠛⠀⠀⠀⠀⠀⢠⣮⠶⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠛⠻⠿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣶⠖⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 44-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⠀⠊⠉⠓⡀⠈⠉⠉⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠾⠱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠐⠋⢉⣠⣿⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⣷⠀⠀⠒⠤⠴⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠚⠛⠿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣿⣿⣿⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿⣶⣶⣶⣶⣶⣶⡿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢉⣿⣿⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⣿⡿⠟⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⠀⠀⠀⠀⡔⠢⠀⡄⢠⠀⠀⣤⠀⠀⡖⡄⠀⡆⠀⠀⡆⢰⠒⠂⠀⠀⠒⢦⠀⣄⠤⡄⢰⣾⣿⣿⣿⣿⣿⣦⡄⠀⠀⠀⠀⠀⠀⠀⠉⠩⠹⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⠀⠀⠀⠀⠣⠔⠀⠟⠹⠀⠾⠤⠧⠀⠟⠧⠀⠧⠄⠀⠇⠸⠭⠄⠀⠀⠏⠁⠀⠣⠴⣡⣿⣿⣿⣿⣿⣿⣿⣿⣇⣧⣀⠀⠀⠀⠀⠀⠀⠀⢈⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣛⣛⣛⣛⣻⣿⣷⣄⠀⠀⣤⣤⣴⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⡯⣿⣽⡏⣿⡿⡿⣯⠫⣿⣽⣷⣾⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣷⣾⣷⣶⣷⣶⣿⣾⣷⣿⣿⣶⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 57-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 58-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 59-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 60-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 61-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 62-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(x, 63-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");




        }

        public void Djmax()
        {
            int Y = 30;
            int x = 30;
            Console.SetCursorPosition(x, 31-Y);
            Console.WriteLine("⠀ ⣦⣀⠀⠀⠀⠀⠀⢀⣤⣾⣦⣀⠀⠀⠀⠀⠀⢀⣠⡆⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 32-Y);
            Console.WriteLine("⠀⠀⣿⣿⣷⣦⡀⢀⣴⣿⣿⣿⣿⣿⣷⣄⢀⣠⣶⣿⣿⡇⠀⠀⠀ ");
            Console.SetCursorPosition(x, 33-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀ ");
            Console.SetCursorPosition(x, 34-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀ ");
            Console.SetCursorPosition(x, 35-Y);
            Console.WriteLine("⠀⠀⣿⣿⣧⡰⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⣿⡇⠀⠀⠀ ");
            Console.SetCursorPosition(x, 36-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣷⡜⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀ ");
            Console.SetCursorPosition(x, 37-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 38-Y);
            Console.WriteLine("⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 39-Y);
            Console.WriteLine("⠀⠀⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⡇⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 40-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 41-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡟⢿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 42-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡇⠈⠻⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 43-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡇⠀⠀⠙⣿⣿⣿⣿⣄⠀⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 45-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡇⠀⠀⣠⣾⣿⣿⣿⢫⣦⠀⠀⠀⣿⣿⣿⡇⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 46-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡇⢀⣴⣿⣿⣿⡿⣱⣿⣿⣷⡄⠀⣿⣿⣿⡇⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 47-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣇⣾⣿⣿⣿⠏⠀⠈⢿⣿⣿⣿⣦⣿⣿⣿⡇⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 48-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⣿⡿⠃⠀⠀⠀⠀⠻⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 49-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠘⢿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 50-Y);
            Console.WriteLine("⠀⠀⣿⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⣿⣿⡇⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 51-Y);
            Console.WriteLine("⠀⠀⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⣿⣿⡇⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 52-Y);
            Console.WriteLine("⠀⠀⣿⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⡇⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 53-Y);
            Console.WriteLine("⠀⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 54-Y);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡷⣶⣶⢶⣶⢶⠆⠀⠀⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 55-Y);
            Console.WriteLine("⠀⠀⣤⡄⠀⣤⡄⠀⣤⠀⢠⣤⠀⢠⣬⠉⣩⣭⡉⠩⣭⡄⠀⠀⠀⠀ ");
            Console.SetCursorPosition(x, 56-Y);
            Console.WriteLine("⠀⠀⠟⠇⠀⠻⠃⠀⠟⠀⠸⠉⠀⠘⠟⠀⠙⠾⠃⠀⠸⠀⠀⠀⠀⠀⠀ ");
        }
    }
}