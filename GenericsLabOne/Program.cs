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

            Box a = new Box(25, 100, 100);
            Box b = new Box(25, 3, 100);
            Box c = new Box(55, 55, 100);
            Box d = new Box(5, 3, 1);
            Box e = new Box(8, 8, 8);
            Box x = new Box(8, 8, 8);

            bc.Add(a);
            bc.Add(b);
            bc.Add(c);
            bc.Add(d);
            bc.Add(e);
            Console.WriteLine("5 boxes are added, and will be displayed");

            bc.Display();

            Console.WriteLine("\nTrying to add a box with duplicate values, but it wont work");
            bc.Add(x);

            Console.WriteLine("\nRemoving all boxes but box 'a'");
            bc.Remove(b);
            bc.Remove(c);
            bc.Remove(d);
            bc.Remove(e);
            bc.Remove(x);

            Console.WriteLine("Displaying the BoxCollection again\n");
            bc.Display();
            Console.WriteLine("Adding box 'd' again and seeing if BoxCollection contains 'd': \n");
            if (bc.Contains(d)) { Console.WriteLine("True"); }

            Console.WriteLine(nameof(a));

        }
    }
}