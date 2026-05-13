using System;
using System.Media;
using System.Windows;

namespace CyberSecurityBotGUI
{
    public partial class SplashScreen : Window
    {
        private bool secondVideoPlaying = false;

        private SoundPlayer? player;

        public SplashScreen()
        {
            InitializeComponent();

            StartSplash();
        }

        private void StartSplash()
        {
            // PLAY THE WAV FILE
            player = new SoundPlayer("Assets/greeting.wav");

            player.Play();

            // THEN PLAY FIRST VIDEO
            SplashVideo.Play();
        }

        private void SplashVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            // THIS MAKES THE FIRST VIDEO END
            if (!secondVideoPlaying)
            {
                secondVideoPlaying = true;

                SplashVideo.Source =
                    new Uri("Assets/Gif2.mp4", UriKind.Relative);

                SplashVideo.Play();
            }
            else
            {
                // PROSCEEDS TO MAIN WINDOW
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                this.Close();
            }
        }
    }
}