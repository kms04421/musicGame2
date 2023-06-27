using System;
using System.Threading;
using WMPLib;
namespace practice0615
{
    public class musicList
    {
        public static void musicStart(int type ,string musicName)
        {
            bool IsAlive = true;
           
            int mutime = 0;
            int setTime = 180;
            WindowsMediaPlayer player = new WindowsMediaPlayer();
         

                IsAlive = false;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                // mp3 파일
                if (musicName == "RinneCooking Time")
                {
                    player.URL = @"C:\musicBox\RinneCooking Time!.mp3";
                }else if(musicName == "Rinneinfinite promise")
                {
                    player.URL = @"C:\musicBox\Rinneinfinite promise.mp3";
                }
                else if (musicName == "CROSS†OVER")
                {
                    player.URL = @"C:\musicBox\CROSSOVER.mp3";
                }


                while (true)
                {
                    if (mutime == setTime)
                    {
                        player.controls.stop();
                        player.close();
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        mutime ++;
                    }
                        
                       
                    }
                    // 스레드 종료 여부
                    if (IsAlive)
                    {
                       
                    }
                  

                

             });

      
        }
    }
}
