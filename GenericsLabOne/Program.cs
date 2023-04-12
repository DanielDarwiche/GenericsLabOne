using System.Diagnostics;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;

namespace GenericsLabOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection bc = new BoxCollection();

            Box a = new Box(25, 100, 100, "a");
            Box b = new Box(25, 3, 100, "b");
            Box c = new Box(55, 55, 100, "c");
            Box d = new Box(5, 3, 1, "d");
            Box e = new Box(8, 8, 8, "e");
            Box x = new Box(8, 8, 8, "x");

            bc.Add(a);
            bc.Add(b);
            bc.Add(c);
            bc.Add(d);
            bc.Add(e);
            Console.WriteLine("5 boxes are added, and will be displayed:");
            bc.Display();

            Console.WriteLine("\nTrying to add a box with duplicate values, but it wont work");
            bc.Add(x);

            Console.WriteLine("\nRemoving boxes b,c,d,e");
            bc.Remove(b);
            bc.Remove(c);
            bc.Remove(d);
            bc.Remove(e);

            Console.WriteLine("Displaying the BoxCollection again:");
            bc.Display();
            Console.WriteLine("Adding box 'd' again and seeing if BoxCollection contains 'd':");
            if (bc.Contains(d)) { Console.WriteLine("bc contains D: True"); }


            //below is using IEqualityComparer
            Box DBox = new Box(25, 100, 100, "DBox");

            //not added to bc ! Below will be false

            //BC contains, uses the equalitycomparer to compare bc.containment values with DBox values
            BoxEqualityComparer boxEqualityComparer = new BoxEqualityComparer();
            if (bc.Contains(DBox, boxEqualityComparer))
            {
                Console.WriteLine("Bc contains values which are identical to " + DBox.name);
            }
            else
            {
                Console.WriteLine("Bc does not contain values which are identical to " + DBox.name);
            }


        }
    }
}