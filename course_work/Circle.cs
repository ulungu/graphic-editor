using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Circle:Line
    {
        
        bool full;
        public Circle() { }
        public Circle(Graphics g, Point n, Point k, int PenWidth, Color col,bool f,Color del) :base(g,n,k, PenWidth,col,del)
        {
            full = f;
        }
       
        new public void Draw()
        {
            int width = end.X - start.X;
            int heigth = end.Y - start.Y;
            graphics.DrawEllipse(pen, start.X, start.Y, width, heigth);
            
        }
         public void DrawFill()
         {
            int width = end.X - start.X;
            int heigth = end.Y - start.Y;
            graphics.FillEllipse(brush, start.X, start.Y, width, heigth);
         }
        
        new public void DeleteFigure()
        {            
            if (full)
            {//с заливкой 
                brush.Color = delete;
                int width = end.X - start.X;
                int heigth = end.Y - start.Y;
                graphics.FillEllipse(brush, start.X, start.Y, width, heigth);
                brush.Color = color;
            }
            else
            {
                pen.Color = delete;
                int width = end.X - start.X;
                int heigth = end.Y - start.Y;
                graphics.DrawEllipse(pen, start.X, start.Y, width, heigth);
                pen.Color = color;
            }
        }
        new public void ChangeSize(Point new_end)
        {
            DeleteFigure();
            DeleteChoice();

            end = new_end;
            if (full)
                DrawFill();
            else
                Draw();
            DrawChoice();
        }
        new public void MoveTo(Point now)
        {

            DeleteFigure();
            DeleteChoice();

            end.X += now.X - start.X;
            end.Y += now.Y - start.Y;
            start = now;
            if (full) 
                graphics.FillEllipse(brush, now.X,now.Y, end.X - now.X, end.Y - now.Y); //переместили
            else
                graphics.DrawEllipse(pen, now.X, now.Y, end.X - now.X, end.Y - now.Y);
            DrawChoice();
        }
        new public void Spin()
        {
            DeleteFigure();
            DeleteChoice();
            int width = end.X - start.X;
            int heigth = end.Y - start.Y;
            end.Y=start.Y+width;
            end.X = start.X+heigth;
            if (full)
                DrawFill();
            else
                Draw();
            DrawChoice();
        }
    }
}
