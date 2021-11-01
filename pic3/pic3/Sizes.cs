using System;
using System.Collections.Generic;
using System.Text;

namespace pic3
{
    class Sizes
    {
        public decimal width;
        public decimal length;
        public decimal height;
        public decimal VolumeOfBox(Sizes size)
        {
            return size.width * size.length * size.height;
        }
    }
}
