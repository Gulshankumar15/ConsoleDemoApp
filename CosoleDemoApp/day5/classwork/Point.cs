using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleDemoApp.day5.classwork
{
    internal class Point
    {
        int x;
        int y;
        public Point()
        {
            this.x = 20;
            this.y = 30;
        }
        public Point(int x = 50, int y = 40)

        {
            this.x = x;
            this.y = y;

        }
        public override string ToString()
        {
            return $"point({x},{y})";
        }
    }
}
