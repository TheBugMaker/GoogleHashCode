using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHash.data
{
    class Grid
    {
        Cell[,] cl;
        int c;
        int r;

        public Grid(int c, int r)
        {
            this.c = c;
            this.r = r; 
            cl = new Cell[r, c]; 
        }
    }
}
