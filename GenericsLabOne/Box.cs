using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLabOne
{
    public class Box : IEquatable<Box>
    {
        public int height { get; set; }
        public int lenght { get; set; }
        public int width { get; set; }
        public string name { get; set; }
        public Box(int h, int l, int w, string n) //Constructor
        {
            this.height = h;
            this.lenght = l;
            this.width = w;
            this.name = n;
        }
        //Compares two boxes values
        public bool Equals(Box other)
        {
            if (height == other.height && lenght == other.lenght && width == other.width)
            {
                return true;
            }
            else return false;
        }
        //compares two objects, not only boxes
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
