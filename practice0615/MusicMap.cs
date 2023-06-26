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
                for (int j = 1; j < 22; j++)
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
                for (int j = 0; j < 21; j++)
                {

                    Console.Write($"{strArray[i, j]}");

                }
                Console.WriteLine();
            }
           


        }
    }
}