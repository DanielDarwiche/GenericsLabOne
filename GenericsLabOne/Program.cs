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

            Box a = new Box(100, 100, 100, "a");
            Box b = new Box(25, 25, 25, "b");
            Box c = new Box(2, 2, 2, "c");
            Box d = new Box(50, 30, 10, "d");
            Box e = new Box(9, 9, 9, "e");
            Box x = new Box(9, 9, 9, "x");

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
            Box DBox = new Box(500, 500, 500, "DBox");

            //bc.contains, uses the equalitycomparer to compare the containment-values of bc with DBox-values
            //BoxEqualityComparer boxEqualityComparer = new BoxEqualityComparer();
            //We can create an instance as above or one temporary as below
            if (bc.Contains(DBox, new BoxEqualityComparer()))
            {
                Console.WriteLine("Bc contains values which are identical to " + DBox.name);
            }   //If any of the values are equal to DBox:s values it will be written
            else
            {
                Console.WriteLine("Bc does not contain values which are identical to " + DBox.name);
            }   //Else, it will be written as well
        }
    }
}