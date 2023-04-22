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
using System.Threading;
using System.Timers;
using Color = System.Windows.Media.Color;
using System.IO;
using System.Windows.Controls.Primitives;

namespace PingPong
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double ballX, ballY, ballSpeedX, ballSpeedY;
        private double player1Y, player2Y, playerSpeed;
        DispatcherTimer timer;
        private int countleft, countright;
        string nameleftplayer, namerightplayer;

        public MainWindow()
        {
            InitializeComponent();
            run.Visibility = Visibility.Visible;
            gameover.Visibility = Visibility.Hidden;
            pause.Visibility = Visibility.Hidden;
        }

        void InitData()
        {
            gameover.Visibility = Visibility.Hidden;
            run.Visibility = Visibility.Hidden;
            pause.Visibility = Visibility.Hidden;

            initBall();
            initRacket();
            SetSpeed();
            SetBall();
            SetRacket();
        }
        void initBall()
        {
            // Начальная позиция мяча
            ballX = -Ball.Width / 2;
            ballY = -Ball.Height / 2;
        }
        void initRacket()
        {
            // Начальная позиция ракеток
            player1Y = -LeftRacket.Height / 2;
            player2Y = -RightRacket.Height / 2;
        }
        void initSpeed(int speed)
        {
            // Скорость мяча и ракеток
            ballSpeedX = speed;
            ballSpeedY = speed;
            playerSpeed = speed;
        }
        void SetBall()
        {
            Canvas.SetLeft(Ball, ballX);
            Canvas.SetTop(Ball, ballY);
        }
        void SetRacket()
        {
            Canvas.SetTop(LeftRacket, player1Y);
            Canvas.SetTop(RightRacket, player2Y);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetName();
            SetSpeed();
            tabControl1.SelectedIndex = 0;
        }
        void SetName()
        {
            nameleftplayer = leftname.Text;
            namerightplayer = rightname.Text;
            left.Content = $"{nameleftplayer}: " + countleft.ToString();
            right.Content = $"{namerightplayer}: " + countright.ToString();
        }
        void SetSpeed()
        {
            if (level.SelectedIndex == 0)
            {
                initSpeed(5);
            }
            else if (level.SelectedIndex == 1)
            {
                initSpeed(8);
            }
            else if (level.SelectedIndex == 2)
            {
                initSpeed(12);
            }
        }

        private void InitTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(20);
            timer.Tick += timer_Tick;
        }
        private void StartTimer()
        {
            timer.Stop();
            timer.Start();
        }
        private void Run_Click(object sender, RoutedEventArgs e)
        {
            InitData();
            InitTimer();
            StartTimer();
            countleft = 0;
            countright = 0;
            SetName();
            SetSpeed();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateBall();
        }

        void UpdateBall()
        {
            ColorPlayers();
            // Обновление позиции мяча
            ballX -= ballSpeedX;
            ballY += ballSpeedY;

            int stop = (int)ActiveZone.ActualHeight / 2;
            // Обновление позиции ракеток
            if (Keyboard.IsKeyDown(Key.A) && player1Y > -stop)
            {
                player1Y -= playerSpeed;
            }
            if (Keyboard.IsKeyDown(Key.Z) && player1Y < stop - LeftRacket.ActualHeight)
            {
                player1Y += playerSpeed;
            }
            if (Keyboard.IsKeyDown(Key.K) && player2Y > -stop)
            {
                player2Y -= playerSpeed;
            }
            if (Keyboard.IsKeyDown(Key.M) && player2Y < stop - RightRacket.ActualHeight)
            {
                player2Y += playerSpeed;
            }

            if (Keyboard.IsKeyDown(Key.Escape))
            {
                GameOver();
            }

            if (Keyboard.IsKeyDown(Key.Space))// это типа пауза
            { 
                pause.Visibility = Visibility.Visible;
                if (timer.IsEnabled)//ИГРА РАБОТАЕТ
                {
                    timer.Stop();//Я ЕЕ ВЫРУБАЮ
                }
                else if(!timer.IsEnabled)//игра не работает. то бишь пауза
                {
                    //почему блять не работает((((((((((((((((((((((((((((((((((((((((((((
                    //StartTimer();// я ее включаю....но она не включается(
                    InitData();
                    InitTimer();
                    StartTimer();
                    SetName();
                    SetSpeed();
                    //как жить а
                }
            }
            // Обработка столкновений мяча с ракетками и краями поля
            if (ballY >= (int)ActiveZone.ActualHeight / 2 - Ball.ActualHeight)
            {
                ballSpeedY *= -1;
            }
            if (ballY <= -(int)ActiveZone.ActualHeight / 2)
            {
                ballSpeedY *= -1;
            }

            double leftval = -(Canvas.GetTop(LeftRacket));
            double ballval = -(Canvas.GetTop(Ball) + Ball.Height/2);
            double rightval = -(Canvas.GetTop(RightRacket));

            if (ballX > (int)ActiveZone.ActualWidth / 2 - 2 * RightRacket.Width && (ballval <= rightval && ballval + RightRacket.Height >= rightval))
            {
                ballSpeedX *= -1;
            }
            else if(ballX > (int)ActiveZone.ActualWidth / 2 - RightRacket.Width)
            {
                initBall();
                countleft++;
                left.Content = $"{nameleftplayer}: " + countleft.ToString();
            }
            if (ballX < -(int)ActiveZone.ActualWidth / 2 + LeftRacket.Width && (ballval <= leftval && ballval + LeftRacket.Height >= leftval))
            {
                ballSpeedX *= -1;
            }
            else if (ballX < -(int)ActiveZone.ActualWidth / 2 )
            {
                initBall();
                countright++;
                right.Content = $"{namerightplayer}: " + countright.ToString();
            }

            // Отображение мяча и ракеток на поле
            SetBall();
            SetRacket();
        }

        void ColorPlayers()
        {
            if (countleft > countright)
            {
                left.Foreground = new SolidColorBrush(Color.FromRgb(110, 222, 54));
                right.Foreground = new SolidColorBrush(Color.FromRgb(228, 38, 38));
            }
            else if (countleft < countright)
            {
                left.Foreground = new SolidColorBrush(Color.FromRgb(228, 38, 38));
                right.Foreground = new SolidColorBrush(Color.FromRgb(110, 222, 54));
            }
            else
            {
                left.Foreground = new SolidColorBrush(Color.FromRgb(38, 124, 228));
                right.Foreground = new SolidColorBrush(Color.FromRgb(38, 124, 228));
            }
        }
        void GameOver()
        {
            gameover.Visibility = Visibility.Visible;
            run.Visibility = Visibility.Visible;
            timer.Stop();
            FileOutput();
        }

        void FileOutput()
        {
            string filePath = @"C:\Users\mosol\OneDrive\Рабочий стол\results.txt.txt";
            string res = DateTime.Now.ToString().PadLeft(20) + ($"{nameleftplayer}:").PadLeft(20) + ($"{countleft}").PadLeft(10) + ($"{namerightplayer}:").PadLeft(20) + ($"{countright}").PadLeft(10);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(res);
            }
        }
    }
}
