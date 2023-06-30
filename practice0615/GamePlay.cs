using cshap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace practice0615
{
    public class GamePlay
    {
        Task musicTask = default;
     
        int comboCount = 0;
        string[,] firstf = new string[50, 50];
        string[,] musicNote = new string[50, 50];
        int[,] MusicAllNote = new int[50, 50];
        int countX = 0;//스왑라인 X
        int countY = 0;//스왑라인 y

        int score = 0;//점수
        int combo = 0; // 콤보 
        int scoreType = 0;
        int notLine = 0;
        int HP = 20;
        musicMap musicMap = new musicMap();// 뮤직 게임 화면 
       
     

        object lockObject = new object(); // 동시에 접근하는 변수 처리
        List<ConsoleKey> pressedKeys = new List<ConsoleKey>();// 동시에 눌린 키들을 저장할 리스트

        MusicSetting musicSetting = new MusicSetting();

        public int Play(string muName ,int muNumber,int speed)
        {
            musicList musicList = new musicList();//음악재생
            string[,] musicNote = new string[50, 50];
            NoteMove noteMove = new NoteMove();// 뮤직 노트
            Timer timer;
            bool IsAlive = true;
            int setTime = 180;
            Console.OutputEncoding = Encoding.UTF8;
            //음악종료 로직 
            //
            countX = 0;//스왑라인 X
            countY = 0;//스왑라인 y

            int maxLine = 125;
            Console.SetWindowSize(120, 40);
            score = 0;//점수
            notLine = 0; // 음악 라인

            int timerspeed = 20;
            if (speed == 1)
            {
                maxLine = 140;
                timerspeed = 18;
            }
            else if (speed == 2)
            {
                maxLine = 140;
                timerspeed = 16;
            }
            else if (speed == 3)
            {
                maxLine = 140;
                timerspeed = 14;
            }
            // 타이머 생성 및 시작
            TimerCallback callback = TimerCallbackMethod; // 노트 스왑
          

            timer = new Timer(callback, null, 0, timerspeed); // 1초(1000밀리초) 간격으로 콜백 메서드 실행

            musicMap.GameMap(ref firstf); //게임 맵
            Console.CursorVisible = false;

            Thread inputThread = new Thread(ReadInput); // 키입력
            inputThread.Start(); //키입력 시작 
            musicMap.Demap();
            musicMap.DrawScoreLine();

            Console.SetCursorPosition(50, 20);
            Console.Write("Combo");
            Console.SetCursorPosition(50, 15);
            Console.Write("score");

            WindowsMediaPlayer player = new WindowsMediaPlayer();

            musicTask =  musicList.MusicBank(1, muName, player, 0, setTime, IsAlive);
            //노트 넣기
            MusicAllNote =noteMove.MusicNote(muName);

            CancellationTokenSource musicCancleControler = new CancellationTokenSource();
            Random random = new Random();
            CancellationToken musicCancleToken = musicCancleControler.Token;
            //음악종료 
            HP = 20;//hp
            int missCount = 0;
            int lose = 0;
            int musicDash = 0;
            Task.Run(() => { musicTask.Start(); }, musicCancleToken);
            while (true)
            {
                musicDash++;
                if (HP == 0)
                {
                    lose= 1;
                    break;
                }
                int randMax = 7;

                if (combo == 0)
                {
                    randMax = 1;

                }
                if (musicDash% 3 == 0)
                {
                    for (int j = 0; j< 7; j++)
                    {
                        Console.SetCursorPosition(50, 30-j);
                        Console.Write("                                         ");
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        
                        for (int j = 0; j< random.Next(1, randMax); j++)
                        {
                            Console.SetCursorPosition(50+i*2, 30-j);
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            if (combo >= 10)
                            {
                               Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            }
                            if (combo > 20)
                            {
                                if(i%2 == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                
                            }
                            Console.Write("■");
                            Console.ResetColor();

                        }
                    }
                }
                
                if (missCount == 1)
                {                                  
                    HP-=1;
                    missCount=0;
                }

              

                if (comboCount == 5)
                {
                    if (HP < 20)
                    {
                        HP =HP+1;
                    }
                    comboCount = 0;
                }
               
                for (int i = 0; i <20; i++)
                {
                    Console.SetCursorPosition(2, 31-i);
                    Console.Write("  ");
                  
                    
                }

                for (int i = 0; i <HP; i++)
                {
                    
                    Console.SetCursorPosition(2, 31-i);
                    if(HP <5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (HP <10)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }                  
                    Console.Write("□");
                }
                musicMap.DrawScoreLine();
                if (firstf[30, 2] == "==" || firstf[30, 7] == "==" || firstf[30, 13] == "==" || firstf[30, 18] == "==")
                {
                    missCount++;
                    combo = 0;
                    scoreType = 3;
                    comboCount = 0;
                }

                //maxLine
                if (notLine == maxLine)
                {
                    
                    timer.Dispose();                   
                    break;
                }
                Console.SetCursorPosition(50, 17);
                Console.Write(score);
                Console.SetCursorPosition(50, 22);
                Console.Write("      ");
                Console.SetCursorPosition(50, 22);
                Console.Write(combo);

                Console.SetCursorPosition(50, 12);
                Console.Write("         ");
                Console.SetCursorPosition(50, 12);

            

                if (scoreType == 1)
                {
                    Console.Write("Perfect");
                }
                else if (scoreType == 2)
                {
                    Console.Write("Good");
                }
                else if (scoreType == 3)
                {
                    Console.Write("Miss");
                }
                musicMap.Anim();
                Console.SetCursorPosition(0, 0);
                musicMap.GameView(ref firstf);

                musicMap.DrawScoreLine();
            }//while종료

            player.controls.stop();
            player.close();

            musicCancleControler.Cancel();
            if(lose ==1)
            {
                timer.Dispose();
                return -10;
            }
            return score;


        }// Play(string muName ,int muNumber,int speed)종료

        //리얼 타입 노트 내려가는 로직
        void TimerCallbackMethod(object state)
        {
            // 노트 입력
            for (int j = 1; j < 22; j+=5)
            {

                if (j % 5 == 0)
                {

                }
                else
                {

                countY = j;
                // 뮤직 노트 체크

                if (MusicAllNote[notLine, 0] == 1 && j > 0 && j < 5)
                {
                    firstf[0, j] = "==";
                    firstf[0, j+1] = "==";
                    firstf[0, j+2] = "==";
                    firstf[0, j+3] = "==";
                }
                if (MusicAllNote[notLine, 1] == 1 && j > 5 && j < 10)
                {
                    firstf[0, j] = "==";
                    firstf[0, j + 1] = "==";
                    firstf[0, j + 2] = "==";
                    firstf[0, j + 3] = "==";
                }
                if (MusicAllNote[notLine, 2] == 1 && j > 10 && j < 15)
                {
                    firstf[0, j] = "==";
                    firstf[0, j + 1] = "==";
                    firstf[0, j + 2] = "==";
                    firstf[0, j + 3] = "==";
                }
                if (MusicAllNote[notLine, 3] == 1 && j > 15 && j < 20)
                {
                    firstf[0, j] = "==";
                    firstf[0, j + 1] = "==";
                    firstf[0, j + 2] = "==";
                    firstf[0, j + 3] = "==";
                }

                //마지막 스왑 노트 지움
                firstf[30, j] = "  ";
                firstf[30, j+1] = "  ";
                firstf[30, j+2] = "  ";
                firstf[30, j+3] = "  ";
                }

            }

            if (countX == 30)
            {
                notLine++;
                countX = 0;

            }
            
                
            for (int j = 1; j < 21; j+=5)
            {


                if (firstf[countX, j] == "==")
                {                   
                    countY = j;
                    Swap();
                    countY = j+1;
                    Swap();
                    countY = j+2;
                    Swap();
                    countY = j+3;
                    Swap();
                }

            }
            countX++;

            if(countX == 3)
            {
                for (int j = 1; j < 21; j += 5)
                {


                    if (firstf[countX, j] == "==")
                    {
                        countY = j;
                        Swap();
                        countY = j + 1;
                        Swap();
                        countY = j + 2;
                        Swap();
                        countY = j + 3;
                        Swap();
                    }

                }
                countX++;
            }
            
        }
       
        //내려가는 노트 스왑
        void Swap()
        {
          
            string a = firstf[countX, countY];
            firstf[countX, countY] = firstf[countX + 1, countY];
            firstf[countX + 1, countY] = a;
         
        }
      


        //키입력
        void ReadInput()
        {
            while (true)
            {
              
                while (!Console.KeyAvailable)
                {
                    Thread.Sleep(1);

                }
                OnKeyPressed(Console.ReadKey(true));
            }
        }

        //키입력시 처리 메서드
         void OnKeyPressed(ConsoleKeyInfo Key)
        {
            lock (lockObject)
            {
                // 눌린 키를 리스트에 추가
                pressedKeys.Add(Key.Key);
            }

            //q입력시
            if (Key.KeyChar == 'q' ||Key.KeyChar == 'Q')
            {
                if (firstf[29, 2] == "==" ||firstf[28, 2] == "==" || firstf[27, 2] == "=="|| firstf[26, 2] == "=="|| firstf[25, 2] == "=="||firstf[30, 2] == "==")
                {
                    if (firstf[29, 2] == "==" || firstf[28, 2] == "==" || firstf[27, 2] == "==")
                    {
                        score += 200;
                        scoreType = 1;
                    }
                    if (firstf[26, 2] == "=="|| firstf[25, 2] == "=="||firstf[30, 2] == "==")
                    {
                        score += 100;
                        scoreType = 2;
                    }

                    for (int j = 1; j < 6; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                            countY = j;
                            firstf[25, j] = "  ";
                            firstf[26, j] = "  ";
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                          
                        }


                    }

                    combo++;
                    comboCount++;


                }
                else
                {
                  
                    
                }
            }

            else if (Key.KeyChar == 'w' ||Key.KeyChar == 'W')
            {
                if (firstf[29, 8] == "==" || firstf[28, 8] == "==" || firstf[27, 8] == "=="|| firstf[26, 8] == "=="|| firstf[25, 8] == "=="||firstf[30, 8] == "==")
                {
                    if(firstf[29, 8] == "==" || firstf[28, 8] == "==" || firstf[27, 8] == "==")
                    {
                        score += 200;
                        scoreType = 1;
                    }
                    if (firstf[26, 8] == "=="|| firstf[25, 8] == "=="||firstf[30, 8] == "==")
                    {
                        score += 100;
                        scoreType = 2;
                    }
                    for (int j = 5; j < 10; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                   
                            firstf[25, j] = "  ";
                            firstf[26, j] = "  ";
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                        }


                    }

                    combo++;
                    comboCount++;


                }
                else
                {
                  
                  
                }
            }

            else if (Key.KeyChar == 'e' ||Key.KeyChar == 'E')
            {
                if (firstf[29, 12] == "==" || firstf[28, 12] == "==" || firstf[27, 12] == "=="|| firstf[26, 12] == "=="|| firstf[25, 12] == "=="||firstf[30, 12] == "==")
                {
                    if (firstf[29, 12] == "==" || firstf[28, 12] == "==" || firstf[27, 12] == "==")
                    {
                        scoreType = 1;
                        score += 200;
                    }
                    if (firstf[26, 12] == "=="|| firstf[25, 12] == "=="||firstf[30, 12] == "==")
                    {
                        scoreType = 2;
                        score += 100;
                    }
                    for (int j = 10; j < 15; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                          
                            firstf[25, j] = "  ";
                            firstf[26, j] = "  ";
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                        }


                    }

                    combo++;
                    comboCount++;

                }
                else
                {
             
                 
                }
            }

            else if (Key.KeyChar == 'r' ||Key.KeyChar == 'R')
            {
                if (firstf[29, 18] == "==" || firstf[28, 18] == "==" || firstf[27, 18] == "=="|| firstf[26, 18] == "=="|| firstf[25, 18] == "=="||firstf[30, 18] == "==")
                {
                    if (firstf[29, 18] == "==" || firstf[28, 18] == "==" || firstf[27, 18] == "==")
                    {
                        score += 200;
                        scoreType = 1;
                    }
                    if (firstf[26, 18] == "=="|| firstf[25, 18] == "=="||firstf[30, 18] == "==")
                    {
                        score += 100;
                        scoreType = 2;
                    }
                    for (int j = 15; j < 20; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                      
                            firstf[25, j] = "  ";
                            firstf[26, j] = "  ";
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                        }


                    }

                    combo++;
                    comboCount++;


                }
                else 
                {
                    
                }
            }
            else if(Key.Key == ConsoleKey.Escape)
            {

                HP = 0;

            }
            


        }//키입력받아서 처리 끝

        
        // 특정 키가 눌렸는지 확인하는 메서드
        bool ConcurrentKeysPressed(params ConsoleKey[] keys)
        {
          
            lock (lockObject)
            {
                // 눌린 키들 중에서 파라미터로 받은 키들이 모두 포함되어 있는지 확인
                foreach (var key in keys)
                {
                    if (!pressedKeys.Contains(key))
                    {
                       
                        return false;
                    }
                }

                // 모든 키들이 동시에 눌렸음을 확인
                return true;
            }

           
        }


        //동시키 입력 확인시 처리 하는 메서드 
        public void together()
        {

        }

    }

}