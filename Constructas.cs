using System;
using System.Collections.Generic;
using System.Text;

namespace CreateTypes
{
    public class Constructas
    {
        int X, Y;
        public Constructas(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Constructas(int x) :this (x,7)
        {

        }
        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lives: ", X, Y); 
        }

    }
}
