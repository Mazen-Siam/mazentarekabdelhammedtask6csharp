using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6csharp
{
    internal class ClassA
    {
        private int F;
        internal int G;
        public int H;

        public ClassA(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }

        public void print()
        {
            Console.WriteLine(F);
            Console.WriteLine(G);
            Console.WriteLine(H);
        }
    }
}
