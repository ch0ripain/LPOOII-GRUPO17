using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


namespace Vistas
{
    /// <summary>
    /// Interaction logic for PresentacionApp.xaml
    /// </summary>
    public partial class PresentacionApp : Window
    {
        private DispatcherTimer timer;
        private bool audioLoaded = false;
        public PresentacionApp()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!audioLoaded)
                {
                    string audioFilePath = "C:\\Users\\leand\\Downloads\\motor_online-audio-converter.com.wav";
                    mediaPlayer.Source = new Uri(audioFilePath, UriKind.RelativeOrAbsolute);
                    mediaPlayer.Volume = 0.1;
                    mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
                    LoadAndShowImage();
                    audioLoaded = true;

                    // Inicializar y comenzar el temporizador para actualizar la ProgressBar
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromMilliseconds(10); // Cambiado a 10 milisegundos
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de audio: " + ex.Message);
            }
        }

        private void MediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            Login oLogin = new Login();
            oLogin.Visibility = Visibility.Hidden;
            mediaPlayer.Stop();
            oLogin.Visibility = Visibility.Visible;
            Close();
        }

        private void LoadAndShowImage()
        {
            try
            {
                string imagePath = "C:\\Users\\leand\\Downloads\\peterparking.jpg";
                BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                mainImage.Source = bitmap;
                mainImage.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Calcular el progreso en función de la posición actual del reproductor
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                double progress = (mediaPlayer.Position.TotalSeconds / mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds) * 100.0;
                progressBar1.Value = progress;

                // Si la ProgressBar llega al 100%, detener el temporizador
                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    timer.Stop();
                }
            }
        }

    }
}