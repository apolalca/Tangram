using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Mover_Figuras_Canvas.Model
{
    public class Figura
    {
        public CompositeTransform dinamica { get; }
        public CompositeTransform estatica { get; }

        public Figura(CompositeTransform dinamica, CompositeTransform estatica)
        {
            this.dinamica = dinamica;
            this.estatica = estatica;
        } 
    }
}
