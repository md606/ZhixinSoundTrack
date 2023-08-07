using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        MediaPlayer player = new MediaPlayer();
        int NextHour, NextMinute;
        string NextMusic, NextMusicString, NextHourString, NextMinuteString;
        bool IsChecked = false;

        public MainWindow()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(0.1);   //设置刷新的间隔时间
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            nowTime.Text = string.Concat("当前时间: ", DateTime.Now.ToString("HH:mm:ss"));
            if (!IsChecked)
            {
                CheckNextMusic.Check(out NextHour, out NextMinute, out NextMusic);

                // 判断下个铃声
                if (NextMusic == "PrepareMusic.mp3") NextMusicString = "预备铃";
                else if (NextMusic == "StartMusic.mp3") NextMusicString = "上课铃";
                else if (NextMusic == "EndMusic.mp3") NextMusicString = "下课铃";
                else if (NextMusic == "YBJCMusic.mp3") NextMusicString = "眼保健操";
                else if (NextMusic == "PaoCaoMusic.mp3") NextMusicString = "跑操";
                else if (NextMusic == "SleepMusic.mp3") NextMusicString = "午休铃";
                else NextMusicString = "起床铃";
                nextRing.Text = $"下个铃声: {NextMusicString}";
                // 判断响铃时间 - Hour
                if (NextHour < 10) NextHourString = $"0{NextHour}";
                else NextHourString = NextHour.ToString();
                // 判断响铃时间 - Minute
                if (NextMinute < 10) NextMinuteString = $"0{NextMinute}";
                else NextMinuteString = NextMinute.ToString();
                // 判断响铃时间 - 是否为次日
                if (DateTime.Now.Hour > NextHour || (DateTime.Now.Hour == NextHour && DateTime.Now.Minute >= NextMinute))
                    nextTime.Text = $"响铃时间: 次日{NextHourString}:{NextMinuteString}";
                else
                    nextTime.Text = $"响铃时间: {NextHourString}:{NextMinuteString}";

                IsChecked = true; // 已更新
            }
            if (DateTime.Now.Hour == NextHour && DateTime.Now.Minute == NextMinute)
            {
                IsChecked = false; // 未更新
                player.Open(new Uri($"./assets/{NextMusic}", UriKind.Relative));
                player.Play(); // 播放mp3
            }
        }
    }
}
