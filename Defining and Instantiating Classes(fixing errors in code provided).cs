using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Dustin's Copy - Defining and Instantiating Classes");
            Point origin = new Point(0, 0); // Shouldn't there be a 0, 0 here since we're doing points?
            Point bottomRight = new Point(1366, 768); // change to from anotherpoint to new point
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine("Distance is: {0}", distance);
            Console.WriteLine("Number of Point objects: {0}", Point.ObjectCount());
        }
    }
    class Point
    {
        private int x, y;
        private static int objectCount = 0; // Notie that this one didn't have static but line 43 did
        public Point() // Took away void due to the 
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }
        public double DistanceTo(Point other) //Changing to public. Doesn't need to be private
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}
