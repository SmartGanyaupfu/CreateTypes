using System;
using System.Collections.Generic;
using System.Text;

namespace CreateTypes
{
    public class IndexersProp
    {
        private int[] array = new int[5];

        public int this [int i]
        {
            get
            {
                return array[i];

            }
            set
            {
                array[i]=value;
            }
        }
    }
}
