using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Drawing;

namespace PingPong
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int addballx = 5;
        int addbally = 5;
        double ballSpeedX = 1;
        double ballSpeedY = 1;
        int countleft = 0;
        int countright = 0;
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            label1.Visibility = Visibility.Hidden;
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            Canvas.SetLeft(Ball, ActiveZone.ActualWidth/2);
            Canvas.SetTop(Ball, ActiveZone.ActualHeight / 2);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            UpdateBall();
        }

        void UpdateBall()
        {
            Canvas.SetLeft(Ball, Canvas.GetLeft(Ball) + ballSpeedX*addballx);
            //Canvas.SetTop(Ball, Canvas.GetTop(Ball) + ballSpeedY*addbally);
            if (Canvas.GetTop(Ball) < -((int)ActiveZone.ActualHeight/2))
            {
                ballSpeedX *= -1;
                ballSpeedY *= -1;
                addbally -= addbally;

            } 
            else if(Canvas.GetTop(Ball) > (int)ActiveZone.ActualHeight/2 - (int)Ball.ActualHeight)
            {
                ballSpeedX *= -1;
                ballSpeedY *= -1;
            }
            if(Canvas.GetLeft(Ball) < -((int)ActiveZone.ActualWidth/2 - (int)LeftRacket.ActualWidth) && (Canvas.GetTop(Ball) > LeftRacket.Margin.Top)){
                ballSpeedX *= -1;
                //addbally -= addbally;
            }
            else if ((Canvas.GetLeft(Ball) > ((int)ActiveZone.ActualWidth/2 - 2*(int)RightRacket.ActualWidth)))
            {
                ballSpeedX *= -1;
                //addbally -= addbally;
            }
        }

        //countleft++; left.Content = $"Левый игрок: {countleft}";
        //countright++;  right.Content = $"Правый игрок: {countright}";

        private void UserKeyDown(object sender, KeyEventArgs e)
        {
            int Stop = (int)ActiveZone.ActualHeight - (int)LeftRacket.ActualHeight;
            if (e.Key == Key.A && LeftRacket.Margin.Top > -Stop)
            {
                LeftRacket.Margin = new Thickness(LeftRacket.Margin.Left, LeftRacket.Margin.Top - 5, LeftRacket.Margin.Right, LeftRacket.Margin.Bottom);
            }
            if (e.Key == Key.Z && LeftRacket.Margin.Top < Stop)
            {
                LeftRacket.Margin = new Thickness(LeftRacket.Margin.Left, LeftRacket.Margin.Top + 5, LeftRacket.Margin.Right, LeftRacket.Margin.Bottom);
            }
            if (e.Key == Key.K && RightRacket.Margin.Top > -Stop)
            {
                RightRacket.Margin = new Thickness(RightRacket.Margin.Left, RightRacket.Margin.Top - 5, RightRacket.Margin.Right, RightRacket.Margin.Bottom);
            }
            if (e.Key == Key.M && RightRacket.Margin.Top < Stop)
            {
                RightRacket.Margin = new Thickness(RightRacket.Margin.Left, RightRacket.Margin.Top + 5, RightRacket.Margin.Right, RightRacket.Margin.Bottom);
            }
        }

    }
}
