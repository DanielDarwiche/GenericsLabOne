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

        public Box(int h, int l, int w, string n) //Konstruktor
        {
            this.height = h;
            this.lenght = l;
            this.width = w;
            this.name = n;
        }

        public bool Equals(Box other)//Jämför lådors egenskaper
        {
            if (height == other.height && lenght == other.lenght && width == other.width)
            {
                return true;
            }
            else return false;
        }


        public override bool Equals(object obj)//jämför två objekt
        {
            return base.Equals(obj);
        }
        /*
        public override int GetHashCode()
        {
            return height.GetHashCode() ^ lenght.GetHashCode() ^ width.GetHashCode();
        }
        */
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
