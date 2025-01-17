using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace course_work
{
    public delegate void ChangeSmth(ChangeEventArgs e);
    public class ChangeEventArgs : EventArgs
    {
        Point now;
        public Point Now
        {
            set { now = value; }
            get { return now; }
        }
        public ChangeEventArgs(Point point)
        {
            now=point;
        }
    }
    public class MyException : Exception 
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception e) : base(message, e) { }
    }
    delegate void DrawSmth();
    public class Line : IShape
    {
        public event ChangeSmth Change; //событие

        int flag = 0;
        protected Graphics graphics;
        protected Point start, end;
        protected Pen pen;
        protected SolidBrush brush;
        public int width;
        public Color color,delete;
        
        public Line() { }
        public Line(Graphics g, Point n, Point k, int PenWidth,Color col,Color del)
        {
            graphics = g;
            start = n;
            end = k;
            pen = new Pen(Color.Black);
            pen.Color = col;
            color = col;
            width=PenWidth;
            pen.Width = PenWidth;
            brush = new SolidBrush(Color.Black);
            brush.Color = col;
            delete = del;

        }
        public int Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public Color Color
        {
            get 
            { 
                return pen.Color; 
            }
        }
        public int Width
        {
            get 
            { 
                return width; 
            }
        }
        public Point Start
        {
            get
            {
                return start;
            }
        }
        public Point End
        {
            get 
            { 
                return end;
            }
            set 
            { 
                end = value;
            }
        }

        protected virtual void OnChange(ChangeEventArgs e)
        {
            Change?.Invoke(e);
        }
        public void Draw()
        {
            try
            {
                if (end.X < start.X)
                    throw new MyException() ;
                if (flag == 1)
                    graphics.DrawLine(pen, start, end);
                else
                {
                    graphics.DrawLine(pen, start, end);
                    DrawChoice();
                }
            }
            catch(MyException)
            {
                Point temp = start;
                start = end;
                end = temp;
            }
        }
        
        public void DrawChoice()
        {
            pen.Width = 2;
            pen.Color = Color.FromArgb(135, 206, 235);
            int wid = end.X - start.X + 20;
            int heig = end.Y - start.Y + 20;
            graphics.DrawRectangle(pen, start.X - 10, start.Y - 10, wid, heig);

            pen.Color = color;
            pen.Width = width;
        }
        public void DeleteChoice()
        {
            pen.Width = 2;
            pen.Color = delete; //удаляем выбор фигуры
            graphics.DrawRectangle(pen, start.X - 10, start.Y - 10, end.X - start.X + 20, end.Y - start.Y + 20);
            pen.Color = color;
            pen.Width =width;
        }
        public void DeleteFigure()
        {
            pen.Color = delete;
            graphics.DrawLine(pen, start, end);
            pen.Color = color;
            
        }
        public bool IfClick(Point now) 
        {
            if (now.X<=end.X+10 && now.X>=start.X+10 && now.Y<=end.Y+10 && now.Y>=start.Y+10)
            {
                Change = MoveTo;
                return true;
            }
            return false;
        }
        public void Changing(ChangeEventArgs p)
        {
            OnChange(p);
        }
        public bool IfClickEnd(Point now)
        {
            if (now.X <= end.X + 20 && now.X >= end.X - 20 && now.Y <= end.Y + 20 && now.Y >= end.Y - 20)
            {
                Change = ChangeSize;
                return true;
            }
            return false;
        }
        public void ChangeSize(ChangeEventArgs e)
        {
            DeleteFigure();
            DeleteChoice();

            end = e.Now;
            Draw();
        }
        public void MoveTo(ChangeEventArgs e)
        {
            DeleteFigure();
            DeleteChoice();
            
            end.X += e.Now.X - start.X;
            end.Y += e.Now.Y - start.Y;
            start = e.Now;
            graphics.DrawLine(pen,start, end); //переместили
            DrawChoice();
        }
        public void ChangeSize(Point new_end) { }
        public void MoveTo(Point now) { }
        public void Spin()
        {
            DeleteFigure();
            
            int temp = start.Y;
            start.Y= end.Y;
            end.Y = temp;
            Draw();
        }
    }
}
