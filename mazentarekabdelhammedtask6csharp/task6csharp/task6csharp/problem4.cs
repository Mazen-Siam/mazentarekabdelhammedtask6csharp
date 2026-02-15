using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace task6csharp
{
    struct Point
    {
        private int x;
        private int y;

        public Point(int xValue)
        {
            x = xValue;
            y = 0;
        }

        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }

        public void Show()
        {
            Console.WriteLine($"Point: ({x}, {y})");
        }
    }

    class problem4
    {
        static void Main()
        {
            Point p1 = new Point(5);
            p1.Show(); 

            Point p2 = new Point(3, 7);
            p2.Show();
        }
    }
}
