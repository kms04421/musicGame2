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
            int musicTime=Convert.ToInt32(DateTime.Now.ToString("mm"));
            musicTime = musicTime+2;
            WindowsMediaPlayer player = new WindowsMediaPlayer();
         

                IsAlive = false;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                // mp3 파일
                if (musicName == "월광")
                {
                    player.URL = @"C:\musicBox\wb.mp3";
                }else if(musicName == "Lift You Up")
                {
                    player.URL = @"C:\musicBox\1-04. Lift You Up.mp3";
                }
                    
                while (true)
                {
                    if(musicTime == Convert.ToInt32(DateTime.Now.ToString("mm")))
                    {
                        
                        player.controls.stop();
                        player.close();
                        break ;
                    }
                    // 스레드 종료 여부
                    if (IsAlive)
                    {
                       
                    }
                  

                }

             });

      
        }
    }
}
