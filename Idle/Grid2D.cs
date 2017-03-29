using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idle
{
    public class Grid2D
    {
        public  GameObject[,] Grid;
        Grid2D(int SizeX,int SizeY)
        {
            Grid = new GameObject[SizeX, SizeY];
        }
    }
}
