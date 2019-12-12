using System;
using System.Collections.Generic;
using System.Text;

namespace CreateTypes
{
    struct AlienStruct
    {
        public int X,Y,Lives;
        public AlienStruct (int x, int y)
        {
            this.X = x;
            this.Y = y;
            Lives = 3;
        }
        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lives: {2}", X, Y, Lives); ;
        }
    }
    enum AlienState:
        byte
    {
        sleeping=1,
        running =2,
        dead=3
    }
}
