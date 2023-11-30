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
using System.Windows.Shapes;

namespace Vistas
{
    public partial class AcercaDe : Window
    {
        public AcercaDe()
        {
            InitializeComponent();

            // Cargar el video desde el código-behind
            string videoFileName = "Media\\intro.mp4";
            string videoFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, videoFileName);

            // Crear una instancia de Uri con la ruta del archivo de video
            Uri videoUri = new Uri(videoFilePath, UriKind.RelativeOrAbsolute);

            // Establecer la fuente del MediaElement y reproducir el video
            myMediaElement.Source = videoUri;
            myMediaElement.Play();
        }

        private void btnCerrarVideo_Click(object sender, RoutedEventArgs e)
        {
            myMediaElement.Stop();
            this.Close();
        }
    }
}