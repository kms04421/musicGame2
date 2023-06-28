using System;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;
namespace practice0615
{
    public class musicList
    {
        public  void musicStart(int type ,string musicName)
        {
            bool IsAlive = true;
           
            int mutime = 0;
            int setTime = 180;
            WindowsMediaPlayer player = new WindowsMediaPlayer();
         

            IsAlive = false;

            Task musicTask = MusicBank(type, musicName, player, mutime, setTime, IsAlive);

            if (type == 1)
            {
                musicTask.Start();
            }
            else if (type == 2)
            {
                if (musicTask != null && musicTask.Status == TaskStatus.Running)
                {
                    musicTask.Dispose();
                }
            }


        }       // musicStart()

        public  Task MusicBank(int type, string musicName, WindowsMediaPlayer player_, int mutime_, int setTime_, bool IsAlive)
        {
            Task musicTask = new Task(() =>
            {
                // mp3 파일
                if (musicName == "RinneCooking Time")
                {
                    player_.URL = @"C:\musicBox\RinneCooking Time!.mp3";
                }
                else if (musicName == "Rinneinfinite promise")
                {
                    player_.URL = @"C:\musicBox\Rinneinfinite promise.mp3";
                }
                else if (musicName == "CROSS†OVER")
                {
                    player_.URL = @"C:\musicBox\CROSSOVER.mp3";
                }
                else if (musicName=="SellBuyMusic")
                {
                    player_.URL = @"C:\musicBox\SellBuyMusic.mp3";
                }
                while (true)
                    {
                        if (mutime_ == setTime_)
                        {
                            player_.controls.stop();
                            player_.close();
                            break;
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            mutime_++;
                        }

                        // 스레드 종료 여부
                        if (IsAlive)
                        {

                        }



                    }

            });

            if(musicTask != null && musicTask != default) { return musicTask; }
            else { return default; }
                
        }       // MusicBank()
    }
}
