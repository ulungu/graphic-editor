using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public interface IShape
    {
        public void Draw() { }
        public void DrawChoice() { }
        public void DeleteChoice() { }
        public void DeleteFigure() { }
        public bool IfClick(Point now);
        public void MoveTo(Point now);
    }
}
