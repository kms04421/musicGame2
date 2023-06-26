using cshap;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
namespace practice0615
{
    public class GamePlay
    {

        Timer timer;
        string[,] firstf = new string[50, 50];
        string[,] musicNote = new string[50, 50];
        int[,] MusicAllNote = new int[50, 50];
        int countX = 0;//스왑라인 X
        int countY = 0;//스왑라인 y

        int combo = 0; // 콤보 

        int notLine = 0; // 음악 라인
        int musicChk = 0; // 음악체크
        object lockObject = new object(); // 동시에 접근하는 변수 처리
        List<ConsoleKey> pressedKeys = new List<ConsoleKey>();// 동시에 눌린 키들을 저장할 리스트

        public void Play()
        {
            
            NoteMove noteMove = new NoteMove();// 뮤직 노트
            musicMap musicMap = new musicMap();// 뮤직 게임 화면 
            // 타이머 생성 및 시작
            TimerCallback callback = TimerCallbackMethod; // 노트 스왑
            timer = new Timer(callback, null, 0, 20); // 1초(1000밀리초) 간격으로 콜백 메서드 실행

            musicMap.GameMap(ref firstf); //게임 맵
            Console.CursorVisible = false;

            Thread inputThread = new Thread(ReadInput); // 키입력
            inputThread.Start(); //키입력 시작 

            Console.SetCursorPosition(45, 20);
            Console.Write("Combo");


            //노트 넣기
            MusicAllNote =noteMove.MusicNote(musicChk);
            while (true)
            {

              
                Console.SetCursorPosition(45, 22);
                Console.Write(combo);

                for (int j = 1; j < 22; j++)
                {

                    if (j % 5 == 0)
                    {

                    }
                    else
                    {

                        countY = j;
                        // 뮤직 노트 체크
                        
                        if (MusicAllNote[notLine, 0] == 1 && j >0  && j< 5 )
                        {
                            firstf[0, j] = "==";
                        }
                        if (MusicAllNote[notLine, 1] == 1 && j >5 &&j < 10)
                        {
                            firstf[0, j] = "==";
                        }
                        if (MusicAllNote[notLine, 2] == 1 && j >10 && j <15)
                        {
                            firstf[0, j] = "==";
                        }
                        if (MusicAllNote[notLine, 3] == 1 && j >15 && j <20)
                        {
                            firstf[0, j] = "==";
                        }

                        //마지막 스왑 노트 지움
                        firstf[28, j] = "  ";
                    }            

                }
                if (countX == 28)
                {
                    notLine++;
                    countX = 0;
                }


                if (ConcurrentKeysPressed(ConsoleKey.Q, ConsoleKey.W))
                {
                    //처리 메서스 넣기                  
                }
                else if (ConcurrentKeysPressed(ConsoleKey.Q, ConsoleKey.E))
                {
                    //처리 메서스 넣기                  
                }
                else if (ConcurrentKeysPressed(ConsoleKey.Q, ConsoleKey.R))
                {
                    //처리 메서스 넣기                  
                }
                else if (ConcurrentKeysPressed(ConsoleKey.W, ConsoleKey.E))
                {
                    //처리 메서스 넣기                  
                }
                else if (ConcurrentKeysPressed(ConsoleKey.W, ConsoleKey.R))
                {
                    //처리 메서스 넣기                  
                }
                else if (ConcurrentKeysPressed(ConsoleKey.E, ConsoleKey.R))
                {
                    //처리 메서스 넣기                  
                }
                Console.SetCursorPosition(0, 0);
                musicMap.GameView(ref firstf);
            
            }
        }

        //리얼 타입 노트 내려가는 로직
        void TimerCallbackMethod(object state)
        {
            
            for (int j = 1; j < 21; j++)
            {


                if (j % 5 == 0)
                {

                }
                else
                {
                    countY = j;
                    Swap();
                }

            }
            countX++;
           
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
                while(!Console.KeyAvailable)
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
                if (firstf[28, 2] == "==" || firstf[27, 2] == "=="|| firstf[26, 2] == "=="|| firstf[25, 2] == "==")
                {

                    for (int j = 1; j < 6; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                            countY = j;
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                            firstf[29, j] = "  ";
                        }


                    }

                    combo++;
                    return;


                }
                else
                {
                    combo =0;
                }
            }

            else if (Key.KeyChar == 'w' ||Key.KeyChar == 'W')
            {
                if (firstf[28, 8] == "==" || firstf[27, 8] == "=="|| firstf[26, 8] == "=="|| firstf[25, 8] == "==")
                {

                    for (int j = 5; j < 10; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                            countY = j;
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                            firstf[29, j] = "  ";
                        }


                    }

                    combo++;
                    return;


                }
                else
                {
                    combo =0;
                }
            }

            else if (Key.KeyChar == 'e' ||Key.KeyChar == 'E')
            {
                if (firstf[28, 12] == "==" || firstf[27, 12] == "=="|| firstf[26, 12] == "=="|| firstf[25, 12] == "==")
                {

                    for (int j = 10; j < 15; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                            countY = j;
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                            firstf[29, j] = "  ";
                        }


                    }

                    combo++;
                    return;


                }
                else
                {
                    combo =0;
                }
            }

            else if (Key.KeyChar == 'r' ||Key.KeyChar == 'R')
            {
                if (firstf[28, 18] == "==" || firstf[27, 18] == "=="|| firstf[26, 18] == "=="|| firstf[25, 18] == "==")
                {

                    for (int j = 15; j < 20; j++)
                    {


                        if (j % 5 == 0)
                        {

                        }
                        else
                        {

                            countY = j;
                            firstf[27, j] = "  ";
                            firstf[28, j] = "  ";
                            firstf[29, j] = "  ";
                        }


                    }

                    combo++;
                    return;


                }
                else
                {
                    combo =0;
                }
            }
            


        }

        
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

            return false;
        }


        //동시키 입력 확인시 처리 하는 메서드 
        public void together()
        {

        }

    }

}