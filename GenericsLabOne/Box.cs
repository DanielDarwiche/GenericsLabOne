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

        public Box(int h, int l, int w) //Konstruktor
        {
            this.height = h;
            this.lenght = l;
            this.width = w;
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
            // kallar på Equals-metoden i den underliggande klassen
            // Object genom att använda nyckelordet "base".
        }
        /*
        public override int GetHashCode()
        {
            return height.GetHashCode() ^ lenght.GetHashCode() ^ width.GetHashCode();
        }
        //genererar hashcode för objektet baserat på egenskapernas värden
        //XOR operatorn utföra hashkoderna för varje egenskap
        */
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
