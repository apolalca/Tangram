using ProyectoTangan.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProyectoTangan
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double goodY;
        private double goodX;

        public MainPage()
        {
            this.InitializeComponent();

            goodX = Math.Round(Canvas.GetTop(imgBien), 2);
            goodY = Math.Round(Canvas.GetLeft(imgBien), 2);

        }

        void Img_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            img.Opacity = 0.5;
        }

        void Img_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            double X = Math.Round(e.Delta.Translation.X, 2);
            double Y = Math.Round(e.Delta.Translation.Y, 2);

            if (X == goodX && Y == goodY)
            {
                imgBien.Opacity = 0;
            } else
            {
                imgBien.Opacity = 1;
            }

            myTransform.TranslateX += X;
            myTransform.TranslateY += Y;
        }

        void Img_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            img.Opacity = 1;
        }
    }
}
