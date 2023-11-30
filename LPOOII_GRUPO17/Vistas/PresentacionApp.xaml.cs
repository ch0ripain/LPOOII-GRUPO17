using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public partial class PresentacionApp : Window
    {
        private System.Media.SoundPlayer sp;
        private DispatcherTimer timer;
        private DateTime startTime;

        public PresentacionApp()
        {
            InitializeComponent();
            sp = new System.Media.SoundPlayer();
            timer = new DispatcherTimer();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Inicializar y comenzar el temporizador para la ProgressBar
            timer.Interval = TimeSpan.FromMilliseconds(20); // Ajustar según sea necesario
            timer.Tick += Timer_Tick;
            timer.Start();

            // Recordar el tiempo de inicio
            startTime = DateTime.Now;

            // Aquí puedes agregar la lógica para cargar y mostrar la imagen
            LoadAndShowImage();

            // Iniciar la reproducción del audio
            PlayAudio();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Calcular el progreso basado en el tiempo transcurrido
            double elapsedTime = (DateTime.Now - startTime).TotalMilliseconds;
            double progress = (elapsedTime / 3000.0) * 100.0;

            // Actualizar la ProgressBar
            progressBar1.Value = Math.Min(progress, 100.0);

            // Si la ProgressBar llega al 100%, detener el temporizador y abrir la ventana de login
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                // Detener el temporizador
                timer.Stop();

                // Abrir la ventana de login
                Login oLogin = new Login();
                oLogin.Show();

                // Cerrar la ventana actual
                Close();
            }
        }

        private void LoadAndShowImage()
        {
            try
            {
                // Lógica para cargar y mostrar la imagen
                string imagePath = "Images/peterparking.jpg";
                BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.Relative));
                mainImage.Source = bitmap;
                mainImage.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void PlayAudio()
        {
            try
            {
                // Lógica para cargar y reproducir el audio
                string audioFileName = "Media\\maru.wav";
                string audioFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, audioFileName);

                sp.SoundLocation = audioFilePath;
                sp.Load();
                sp.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo de audio: " + ex.Message);
            }
        }
    }
}