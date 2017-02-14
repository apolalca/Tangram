using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Mover_Figuras_Canvas.Model
{
    public class FiguraManajer
    {
        private Dictionary<String, CompositeTransform> pilaFigura;
        private const int RANGO = 10;

        public FiguraManajer()
        {
            pilaFigura = new Dictionary<string, CompositeTransform>();
        }

        public void Add(String name, CompositeTransform transform)
        {
            pilaFigura.Add(name, transform);
        }

        public void checkFiguras(Image figura)
        {
            CompositeTransform figuraDinamica = (CompositeTransform) figura.RenderTransform;
            CompositeTransform figuraEstatica = pilaFigura[figura.Name];

            double xDinamico = figuraDinamica.TranslateX;
            double xEstatico = figuraEstatica.TranslateX;
            double yDinamico = figuraDinamica.TranslateY;
            double yEstatico = figuraDinamica.TranslateY;


            if (xDinamico >= xEstatico - RANGO && xDinamico <= xEstatico + RANGO &&
               yDinamico  >= yEstatico - RANGO && yDinamico <= yEstatico + RANGO)
            {
                figuraDinamica.TranslateX = xEstatico;
                figuraDinamica.TranslateY = yEstatico;
            }
         }
    }
}
