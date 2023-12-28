using System;

namespace WpfApp1
{
    public static class CheckNextMusic
    {
        public static void Check(out int NextHour, out int NextMinute, out string NextMusic)
        {
            int NowHour = DateTime.Now.Hour;
            int NowMinute = DateTime.Now.Minute;
            string Pre = "PrepareMusic.mp3", Start = "StartMusic.mp3", End = "EndMusic.mp3", YBJC = "YBJCMusic.mp3", Pao = "PaoCaoMusic.mp3", Sleep = "SleepMusic.mp3", Wake = "WakeMusic.mp3";
            Console.WriteLine(NowHour);
            Console.WriteLine(NowMinute);
            if (NowHour < 8) // 分为Hour<8, Hour<13, Hour<17 几个大节点内再细分
            {
                if (NowHour < 7)
                {
                    NextHour = 7;
                    NextMinute = 55;
                    NextMusic = Pre;
                }
                else // NowHour == 7
                {
                    if (NowMinute < 55)
                    {
                        NextHour = 7;
                        NextMinute = 55;
                        NextMusic = Pre;
                    }
                    else
                    {
                        NextHour = 8;
                        NextMinute = 00;
                        NextMusic = Start;
                    }
                }
            }
            else if (NowHour < 13) // from 8:00 to 12:59 // 五节课+眼保健操+大课间+午休铃
            {
                if (NowHour < 10)
                {
                    if (NowHour == 8)
                    {
                        if (NowMinute < 40)
                        {
                            NextHour = 8;
                            NextMinute = 40;
                            NextMusic = End;
                        }
                        else if (NowMinute < 41)
                        {
                            NextHour = 8;
                            NextMinute = 41;
                            NextMusic = YBJC;
                        }
                        else if (NowMinute < 48)
                        {
                            NextHour = 8;
                            NextMinute = 48;
                            NextMusic = Pre;
                        }
                        else if (NowMinute < 50)
                        {
                            NextHour = 8;
                            NextMinute = 50;
                            NextMusic = Start;
                        }
                        else
                        {
                            NextHour = 9;
                            NextMinute = 30;
                            NextMusic = End;
                        }
                    }
                    else // NowHour == 9
                    {
                        if (NowMinute < 30)
                        {
                            NextHour = 9;
                            NextMinute = 30;
                            NextMusic = End;
                        }
                        else if (NowMinute < 38)
                        {
                            NextHour = 9;
                            NextMinute = 38;
                            NextMusic = Pre;
                        }
                        else if (NowMinute < 40)
                        {
                            NextHour = 9;
                            NextMinute = 40;
                            NextMusic = Start;
                        }
                        else
                        {
                            NextHour = 10;
                            NextMinute = 20;
                            NextMusic = End;
                        }
                    }
                }
                else // NowHour >= 10
                {
                    if (NowHour == 10)
                    {
                        if (NowMinute < 20)
                        {
                            NextHour = 10;
                            NextMinute = 20;
                            NextMusic = End;
                        }
                        else if (NowMinute < 21)
                        {
                            NextHour = 10;
                            NextMinute = 21;
                            NextMusic = Pao;
                        }
                        else if (NowMinute < 48)
                        {
                            NextHour = 10;
                            NextMinute = 48;
                            NextMusic = Pre;
                        }
                        else if (NowMinute < 50)
                        {
                            NextHour = 10;
                            NextMinute = 50;
                            NextMusic = Start;
                        }
                        else
                        {
                            NextHour = 11;
                            NextMinute = 30;
                            NextMusic = End;
                        }
                    }
                    else if (NowHour == 11)
                    {
                        if (NowMinute < 30)
                        {
                            NextHour = 11;
                            NextMinute = 30;
                            NextMusic = End;
                        }
                        else if (NowMinute < 38)
                        {
                            NextHour = 11;
                            NextMinute = 38;
                            NextMusic = Pre;
                        }
                        else if (NowMinute < 40)
                        {
                            NextHour = 11;
                            NextMinute = 40;
                            NextMusic = Start;
                        }
                        else
                        {
                            NextHour = 12;
                            NextMinute = 20;
                            NextMusic = End;
                        }
                    }
                    else // NowHour == 12
                    {
                        if (NowMinute < 20)
                        {
                            NextHour = 12;
                            NextMinute = 20;
                            NextMusic = End;
                        }
                        else
                        {
                            NextHour = 13;
                            NextMinute = 10;
                            NextMusic = Sleep;
                        }
                    }
                }
            }
            else if (NowHour < 17)
            {
                if (NowHour == 13)
                {
                    NextHour = 14;
                    NextMinute = 00;
                    NextMusic = Wake;
                }
                else if (NowHour == 14)
                {
                    if (NowMinute < 5)
                    {
                        NextHour = 14;
                        NextMinute = 05;
                        NextMusic = Pre;
                    }
                    else if (NowMinute < 20)
                    {
                        NextHour = 14;
                        NextMinute = 10;
                        NextMusic = Start;
                    }
                    else
                    {
                        NextHour = 15;
                        NextMinute = 05;
                        NextMusic = End;
                    }
                }
                else if (NowHour == 15)
                {
                    if (NowMinute < 1)
                    {
                        NextHour = 15;
                        NextMinute = 06;
                        NextMusic = YBJC;
                    }
                    else if (NowMinute < 18)
                    {
                        NextHour = 15;
                        NextMinute = 18;
                        NextMusic = Pre;
                    }
                    else if (NowMinute < 20)
                    {
                        NextHour = 15;
                        NextMinute = 20;
                        NextMusic = Start;
                    }
                    else
                    {
                        NextHour = 16;
                        NextMinute = 00;
                        NextMusic = End;
                    }
                }
                else // NowHour == 16
                {
                    if (NowMinute < 8)
                    {
                        NextHour = 16;
                        NextMinute = 08;
                        NextMusic = Pre;
                    }
                    else if (NowMinute < 10)
                    {
                        NextHour = 16;
                        NextMinute = 10;
                        NextMusic = Start;
                    }
                    else if (NowMinute < 50)
                    {
                        NextHour = 16;
                        NextMinute = 50;
                        NextMusic = End;
                    }
                    else
                    {
                        NextHour = 7;
                        NextMinute = 55;
                        NextMusic = Pre;
                    }
                }
            }
            else // NowHour >=17
            {
                NextHour = 7;
                NextMinute = 55;
                NextMusic = Pre;
            }
        }
    }
}
