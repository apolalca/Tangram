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
        //Diccionario en el cual se guardará la referencia entre un objeto y otro.
        private Dictionary<String, CompositeTransform> pilaFigura;
        //Rango maximo permitido
        private const int RANGO = 10;

        /// <summary>
        /// Inicializa la manejadora de Figuras
        /// </summary>
        public FiguraManajer()
        {
            pilaFigura = new Dictionary<string, CompositeTransform>();
        }

        /// <summary>
        /// Añade una figura para poder ser referenciada.
        /// </summary>
        /// <param name="name">Nombre del objeto dinamico que se va mover</param>
        /// <param name="transform">Transform del objeto estatico con el cual se va a comparar</param>
        public void Add(String name, CompositeTransform transform)
        {
            pilaFigura.Add(name, transform);
        }

        /// <summary>
        /// Comprueba si la figura esta encima de la real, si es así la fugura se ajustara a la figura estatica (la que nunca movemos y
        /// usaremos para comprobar si la figura esta bien posicionada.
        /// </summary>
        /// <param name="figura">Imagen de la figura</param>
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
