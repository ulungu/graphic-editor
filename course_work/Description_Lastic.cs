using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public abstract class Description_Lastic
    {
        public int index ;

        public abstract void SetPoint(int x, int y);

        public abstract Point[] GetPoints();

        public abstract void ResetPoints();

        public abstract int GetCountPoints();
        

    }
}
