using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Rectangle:Line
    {
       
        bool full;
        public Rectangle() { }
        public Rectangle(Graphics g, Point n, Point k, int PenWidth, Color col, bool f,Color del) : base(g, n, k, PenWidth, col, del) 
        {
            full = f;
        }
        new public void Draw()
        {
            int width = end.X - start.X;
            int heigth = end.Y - start.Y;
            graphics.DrawRectangle(pen, start.X, start.Y, width, heigth) ;
            

        }
         public void DrawFill()
        {
           
            int width = end.X - start.X;
            int heigth = end.Y - start.Y;
               graphics.FillRectangle(brush, start.X, start.Y, width, heigth);
              
            
        }
        new public void DeleteFigure()
        {
            if (full)
            {//с заливкой 
                brush.Color = delete;
                int width = end.X - start.X;
                int heigth = end.Y - start.Y;
                graphics.FillRectangle(brush, start.X, start.Y, width, heigth);
                brush.Color = color;
            }
            else
            {
                pen.Color = delete;
                int width = end.X - start.X;
                int heigth = end.Y - start.Y;
                graphics.DrawRectangle(pen, start.X, start.Y, width, heigth);
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
                graphics.FillRectangle(brush, now.X, now.Y, end.X - now.X, end.Y - now.Y); //переместили
            else
                graphics.DrawRectangle(pen, now.X, now.Y, end.X - now.X, end.Y - now.Y);
            DrawChoice();
        }
        new public void Spin()
        {
            DeleteFigure();
            DeleteChoice();
            int width = end.X - start.X;
            int heigth = end.Y - start.Y;
            end.Y = start.Y + width;
            end.X = start.X + heigth;
            if (full)
                DrawFill();
            else
                Draw();
            DrawChoice();
        }
    }
}
