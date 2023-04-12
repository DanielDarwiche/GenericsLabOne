using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabOne
{
    public class BoxEqualityComparer : IEqualityComparer<Box>
    {
        public bool Equals(Box? b1, Box? other)
        {

            if (b1.height == other.height && b1.lenght == other.lenght && b1.width == other.width)
            {
                return true;
            }
            else return false;
        }
        /*
        public bool Equals(Box b1, Box b2)
        {
            if (b2 == null && b1 == null)
                return true;
            else if (b1 == null || b2 == null)
                return false;
            else if (b1.height == b2.height && b1.lenght == b2.lenght && b1.width == b2.width)
                return true;
            else
                return false;
        }*/
        public int GetHashCode(Box bx)
        {
            int hCode = bx.height ^ bx.lenght ^ bx.width;
            return hCode;
        }
    }
}
