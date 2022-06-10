using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCore.Mars
{
    public interface IPlateau
    {
        void Define(int width, int height);

        int Height();

        int Width();
    }
}
