using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabOne
{
    public class BoxEqualityComparer : IEqualityComparer<Box>
    {
        //Using the interface to compare boxes values
        public bool Equals(Box? b1, Box? other)
        {
            if (b1.height == other.height && b1.lenght == other.lenght && b1.width == other.width)
            {
                return true;
            }
            else return false;
        }
        //Getting hashcode uniquely created bitwise
        public int GetHashCode(Box bx)
        {
            int hCode = bx.height ^ bx.lenght ^ bx.width;
            return hCode;
        }
    }
}
