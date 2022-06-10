using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCore.Mars
{
    public class Plateau : IPlateau
    {
        private int PlateauWidth { get; set; }

        private int PlateauHeight { get; set; }

        public void Define(int width, int height)
        {
            PlateauWidth = width;

            PlateauHeight = height;
        }

        public int Height()
        {
            return PlateauHeight;
        }

        public int Width()
        {
            return PlateauWidth;
        }
    }
}
