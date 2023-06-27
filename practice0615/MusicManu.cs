﻿using cshap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0615
{
    public class MusicManu
    {
        GamePlay gamePlay  = new GamePlay();

        int chkNumber = 0;

        List<MusicSt> Musiclist = new List<MusicSt>();
        int speed = 2;
        public void Manu()
        {
            
            musicMap musicMap = new musicMap();
            Musiclist.Add(new MusicSt("RinneCooking Time", 0));
            Musiclist.Add(new MusicSt("Rinneinfinite promise", 0));
            Musiclist.Add(new MusicSt("CROSS†OVER", 0));
            while (true)
            {
                
                Console.CursorVisible = false;
                if(chkNumber == 0)
                {
                    musicMap.musicMaunuStart();
                }
                else if (chkNumber == Musiclist.Count-1)
                {
                    musicMap.musicMaunuLast();
                }else
                {
                    musicMap.musicMaunu();
                }             
              

                if (chkNumber != 0)
                {
                    Console.SetCursorPosition(28, 11);
                    Console.Write("                              ");
                    Console.SetCursorPosition(28, 11);
                    Console.Write("{0,-13}          Score :{1,-10}   ", Musiclist[chkNumber-1].MusicName, Musiclist[chkNumber-1].MusicScore);
                }

                Console.SetCursorPosition(24, 18);
                Console.Write("                              ");
                Console.SetCursorPosition(24, 18);
                Console.Write("{0,-13}          Score :{1,-10} speed : {2,-2}", Musiclist[chkNumber].MusicName, Musiclist[chkNumber].MusicScore, speed);

                if (chkNumber !=Musiclist.Count-1)
                {
                    Console.SetCursorPosition(28, 25);
                    Console.Write("                              ");
                    Console.SetCursorPosition(28, 25);
                    Console.Write("{0,-13}          Score :{1,-10}", Musiclist[chkNumber+1].MusicName, Musiclist[chkNumber+1].MusicScore);
                }
            

                ConsoleKeyInfo Ket = Console.ReadKey(); 
                switch(Ket.Key)
                {
                    case ConsoleKey.UpArrow:
                        if(chkNumber == 0){ break; }
                        chkNumber--;
                        speed = 1;
                    break;

                    case ConsoleKey.DownArrow:
                        if (chkNumber == Musiclist.Count-1) { break; }
                        chkNumber++;
                        speed = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        if(speed == 1) { break; }
                        speed--;
                    break;
                    case ConsoleKey.RightArrow:
                        if(speed == 3) { break; }
                        speed++;
                    break;
                    case ConsoleKey.Enter:
                        gameStart(chkNumber);
                        break;
                }
            }
        }
        public void gameStart(int chkNumber)
        {
            int subScore = gamePlay.Play(Musiclist[chkNumber].MusicName,chkNumber,speed) ;
        
            if(subScore > Musiclist[chkNumber].MusicScore)
            {
                Musiclist[chkNumber].MusicScore = subScore;
            }
            Console.Clear();
    
        }


    }
}
