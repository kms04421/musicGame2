using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0615
{
    public class tool
    {
        //// <param name = "str"> 리스트의 문자를 서로 더해주는 함수  sub str 은 글</param>
        public List<string> SaveListAdd(List<string> str,int substr)
        {

            List<string> addString = new List<string>();
            int coun = 0;
            for (int i = 0; i > str.Count; i++)
            {
                addString[coun] = addString[i]+str[i];
               if(i%2 == 0)
                {
                    coun++;
                }
            }

            return addString;
        }

        //// <param name = "size"> 맵생성 </param>
        public void MapMake(ref string[,] map,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size-1 ||j == 0 ||j==size-1)
                    {
                        map[i, j] = "▤";
                    }
                    else
                    {
                        map[i, j] = "  ";
                    }
                }
            }

        }


        //// <param name = "size"> 맵 콘솔에 뿌리기  </param>
        public void viewMap(ref string[,] map,int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size-1 ||j == 0 ||j==size-1)
                    {
                        Console.Write(map[i, j]);
                    }
                    else if (i > 20 && j > 20)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(map[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(map[i, j]);
                    }
                  

                }
                Console.WriteLine();
            }
        }


        //// <param name = "inputNumber"> 1,이렵값만큼 반복 2.~까지 랜덤수출력  </param>
        public int[] randomList(int inputNumber,int MaxNumber ,int minNumber) 
        { 
            Random r = new Random();
            int[] list = new int[inputNumber];

            for(int i =0; i < inputNumber; i++)
            {
                list[i] = r.Next(minNumber,MaxNumber);
            }

            return list;
        }


        //// <param name = "Max"> 0.userX 1.userY 이동 함수</param>
        public int[] PlayMove(int userX , int userY, int Max,ref string[,] map)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int[] reNumber = new int[3];
            switch (key.Key)
            { 
                
                case ConsoleKey.UpArrow:
                    if (userX==1){ break; }
                    map[userX, userY] = "  ";
                    reNumber[0]= userX -1;
                    reNumber[1]= userY;
                    break;
                case ConsoleKey.DownArrow:
                    if (userX==Max-2) { break; }
                    map[userX, userY] = "  ";
                    reNumber[0]= userX +1;
                    reNumber[1]= userY;
                    break;
                case ConsoleKey.LeftArrow:
                    if (userY==1) { break; }
                    map[userX, userY] = "  ";
                    reNumber[0]= userX;
                    reNumber[1]= userY -1;
                    break;
                case ConsoleKey.RightArrow:
                    if (userY==Max-2) { break; }
                    map[userX, userY] = "  ";
                    reNumber[0]= userX;
                    reNumber[1]= userY +1;
                    break;            
            }
            if (reNumber[0] == 0 && reNumber[1]==0)
            {
                reNumber[0] =userX;
                reNumber[1] =userY;
       
            }
         
            return reNumber;
        }


        public void swap(ref string one, ref string two)
        {
            string save = one;
            one = two;
            two = save;
        }

    }
}
