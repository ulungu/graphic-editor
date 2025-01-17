using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Lastik:Description_Lastic
    {
        private int index = 0;
        private Point[] points;

        public Lastik() { }
        public Lastik (int size)
        { if (size <= 0)
                size = 2;
            points = new Point[size];
        }

        public override void SetPoint (int x, int y)
        {
            if (index >= points.Length)
            {
                index = 0;
            }
            points[index]=new Point(x, y);
            index++;
        }
        public override Point[] GetPoints()
        {
            return points;
        }
        public override void ResetPoints()
        {
            index = 0;
        }

        public override int GetCountPoints()
        {
            return index;
        }
    }
}
