using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace ProyectoTangan.Model
{
    public class Figura
    {
        private int _x;
        private int _y;
        private String _source;
        private Point point;

        public Figura(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Figura(Point point)
        {
            this.point = point;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public String Soruce
        {
            get
            {
                return _source;
            }
            set
            {
                _source = value;
            }
        }

    }
}
