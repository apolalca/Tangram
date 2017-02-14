using Mover_Figuras_Canvas.Model;
using System;
using System.Collections;
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

namespace Mover_Figuras_Canvas
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Dictionary<String, CompositeTransform> pila = new Dictionary<string, CompositeTransform>();

        public MainPage()
        {
            this.InitializeComponent();
            pila.Add(img1.Name, myIMGtransform2);
            pila.Add(img2.Name, myIMGtransform4);
        }

        public void Img_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            ((Image)sender).Opacity = 0.5;
            myRectangle.Visibility = Visibility.Collapsed;
        }

        public void Img_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {

            //TODO poner BONICO
            ((CompositeTransform)((Image)sender).RenderTransform).TranslateX += e.Delta.Translation.X;
            ((CompositeTransform)((Image)sender).RenderTransform).TranslateY += e.Delta.Translation.Y;
        }

        public void Img_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            ((Image)sender).Opacity = 1;

            if (((CompositeTransform)((Image)sender).RenderTransform).TranslateX >= pila[((Image)sender).Name].TranslateX-10
                && ((CompositeTransform)((Image)sender).RenderTransform).TranslateX <= pila[((Image)sender).Name].TranslateX+ 10
                && ((CompositeTransform)((Image)sender).RenderTransform).TranslateY >= pila[((Image)sender).Name].TranslateY- 10
                && ((CompositeTransform)((Image)sender).RenderTransform).TranslateY <= pila[((Image)sender).Name].TranslateY+10) 
            {

                ((CompositeTransform)((Image)sender).RenderTransform).TranslateX = pila[((Image)sender).Name].TranslateX;
                ((CompositeTransform)((Image)sender).RenderTransform).TranslateY = pila[((Image)sender).Name].TranslateY;

                myRectangle.Visibility = Visibility.Visible;
            }      
        }
    }
}
