﻿using cshap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace practice0615
{
    public class MusicManu
    {
        GamePlay gamePlay  = new GamePlay();

        int chkNumber = 0;

        List<MusicSt> Musiclist = new List<MusicSt>();
        int speed = 2;

        Task musicTask = default;
        public void Manu()
        {
            bool IsAlive = true;
            int setTime = 180;
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            musicList music = new musicList();
            //Task 에 담기
         
            musicMap musicMap = new musicMap();
            Musiclist.Add(new MusicSt("RinneCooking Time", 0));
            Musiclist.Add(new MusicSt("Rinneinfinite promise", 0));
            Musiclist.Add(new MusicSt("CROSS†OVER", 0));
            while (true)
            {

                musicTask =  music.MusicBank(1, Musiclist[chkNumber].MusicName, player, 0, setTime, IsAlive);
                //음악종료 로직 
                //
                CancellationTokenSource musicCancleControler = new CancellationTokenSource();
                CancellationToken musicCancleToken = musicCancleControler.Token;
                Task.Run(() => { musicTask.Start(); }, musicCancleToken);
                //음악종료 
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
                        musicCancleControler.Cancel();
                        break;

                    case ConsoleKey.DownArrow:
                        if (chkNumber == Musiclist.Count-1) { break; }
                        chkNumber++;
                        speed = 1;
                        musicCancleControler.Cancel();
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
                        if(musicTask != null && musicTask.Status == TaskStatus.Running) 
                        {
                            player.controls.stop();
                            player.close();

                            //musicTask.Dispose();
                            musicCancleControler.Cancel();
                        }
                        gameStart(chkNumber);
                        break;
                }
            }
        }//Manu()
        public void gameStart(int chkNumber)
        {
            
            int subScore = gamePlay.Play(Musiclist[chkNumber].MusicName,chkNumber,speed) ;
        
            if(subScore > Musiclist[chkNumber].MusicScore)
            {
                Musiclist[chkNumber].MusicScore = subScore;
            }
            Console.Clear();

        }//gameStart(int chkNumber)


    }
}
