using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    internal class Square : Line
    {
       
        bool full;
        public Square() { }
        public Square(Graphics g, Point n, Point k, int PenWidth, Color col,bool f,Color del) : base(g, n, k, PenWidth, col, del) 
        {
            full = f;
        }
        new public void Draw()
        {
            int width = end.X - start.X;
            graphics.DrawRectangle(pen, start.X, start.Y, width, width);
        }

         public void DrawFill()
        {
            int width = end.X - start.X;
            graphics.FillRectangle(brush, start.X, start.Y, width, width);
             
        }
        new public void DrawChoice()
        {
            int width_s = end.X - start.X;
            pen.Width = 2;
            pen.Color = Color.FromArgb(135, 206, 235);
            graphics.DrawRectangle(pen, start.X - 10, start.Y - 10, width_s + 20, width_s + 20);
            pen.Color = color;
            pen.Width = width;
        }
        new public void DeleteChoice()
        {
            int width_s = end.X - start.X;
            pen.Width *= 2;
            pen.Color = delete; //удаляем выбор фигуры
            graphics.DrawRectangle(pen, start.X - 10, start.Y - 10, width_s +20, width_s + 20);
            pen.Color = color;
            pen.Width = width;
        }
        new public void DeleteFigure()
        {
            if (full)
            {//с заливкой 
                brush.Color = delete;
                int width_s = end.X - start.X;
                graphics.FillRectangle(brush, start.X, start.Y, width_s, width_s);
                brush.Color = color;
            }
            else
            {
                pen.Color = delete;
                int width_s = end.X - start.X;
                graphics.DrawRectangle(pen, start.X, start.Y, width_s, width_s);
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
        new public void MoveTo( Point now)
        {
            DeleteFigure();
            DeleteChoice();

            end.X += now.X - start.X;
            end.Y += now.Y - start.Y;

            if(full)
                graphics.FillRectangle(brush, now.X, now.Y, end.X - now.X, end.X - now.X);
            else
                graphics.DrawRectangle(pen, now.X,now.Y, end.X - now.X, end.X - now.X); //переместили
            start = now;
            DrawChoice();
        }
    }
}
