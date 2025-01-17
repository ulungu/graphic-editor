using Microsoft.VisualBasic.Devices;
using System.Drawing.Imaging;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml;

namespace course_work
{
    public partial class Paint : Form
    {
        DrawSmth? drawSmth; //делегат
        bool IsMouse = false;
        Point start;
        Point end;
        Graphics g;
        int type_of_shape = 1; // 1-линия 2-круг 3-квадрат 4 -прямоугольник
        Pen pen_lastik;
        Color color = Color.Black;
        Line nul = new Line();
        bool change_size = false;
        bool clicked = false;
        private Lastik lastik = new Lastik(2);

        Line? obj;
        Circle? obj_c;
        Square? obj_s;
        Rectangle? obj_r;
        bool check = false;
        Bitmap map;

        public Paint()
        {
            InitializeComponent();
            pen_lastik = new Pen(this.BackColor);
            pen_lastik.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void Create_Line()
        {
            if (start != end)
            {
                Line line = new Line(g, start, end, Pen_Width.Value, color, this.BackColor);
                drawSmth = new DrawSmth(line.Draw);
                obj = line;
            }
            start = end = new Point(0, 0);
        }
        private void Create_Circle()
        {
            if (start == end)
                return;
            Circle circle = new Circle(g, start, end, Pen_Width.Value, color, checkBox1.Checked, this.BackColor);
            if (checkBox1.Checked == false)
                drawSmth = circle.Draw;
            else
            {
                drawSmth = circle.DrawFill;
            }
            circle.DrawChoice();
            obj_c = circle;
            start = end = new Point(0, 0);
        }
        private void Create_Rectangle()
        {
            if (start == end)
                return;
            Rectangle rect = new Rectangle(g, start, end, Pen_Width.Value, color, checkBox1.Checked, this.BackColor);
            if (checkBox1.Checked == false)
                drawSmth = rect.Draw;
            else
                drawSmth = rect.DrawFill;
            rect.DrawChoice();
            obj_r = rect;
            start = end = new Point(0, 0);
        }
        private void Create_Square()
        {
            if (start == end)
                return;
            Square square = new Square(g, start, end, Pen_Width.Value, color, checkBox1.Checked, this.BackColor);
            if (checkBox1.Checked == false)
                drawSmth = square.Draw;
            else
                drawSmth = square.DrawFill;
            square.DrawChoice();
            obj_s = square;
            start = end = new Point(0, 0);
        }

        private void line_but_CheckedChanged(object sender, EventArgs e)
        {
            obj = null;
            type_of_shape = 1;
            start = new Point(0, 0);
            end = new Point(0, 0);
        }

        private void circle_but_CheckedChanged(object sender, EventArgs e)
        {
            drawSmth = null;
            obj_c = null;
            type_of_shape = 2;
            start = new Point(0, 0);
            end = new Point(0, 0);
        }

        private void square_but_CheckedChanged(object sender, EventArgs e)
        {
            obj_s = null;
            type_of_shape = 3;
            start = new Point(0, 0);
            end = new Point(0, 0);
        }
        private void rectangle_but_CheckedChanged(object sender, EventArgs e)
        {
            obj_r = null;
            type_of_shape = 4;
            start = new Point(0, 0);
            end = new Point(0, 0);
        }
        private void Paint_MouseClick(object sender, MouseEventArgs e)
        {
            Point now = new Point(e.X, e.Y);  // Получаем координаты клика
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int k = Pen_Width.Value;
            width.Text = "Толщина линии : " + k;
            ChangeSettings();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            check = false;
            obj = null;
            obj_c = null;
            obj_s = null;
            obj_r = null;
            drawSmth = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            color = button2.BackColor;
            ChangeSettings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            color = button3.BackColor;
            ChangeSettings();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            color = button4.BackColor;
            ChangeSettings();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            color = button5.BackColor;
            ChangeSettings();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            color = button6.BackColor;
            ChangeSettings();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            color = button7.BackColor;
            ChangeSettings();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            color = button8.BackColor;
            ChangeSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            color = button1.BackColor;
            ChangeSettings();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                button9.BackColor = colorDialog1.Color;
            }
            ChangeSettings();
        }

        private void Paint_Click(object sender, EventArgs e)
        {
            end = start;
        }
        private void какРисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет! \n*Выбери фигуру, которую хочешь изобразить. \n*Выбери толщину пера и его цвет. \n*Если это круг/прямоугольник/квадрат можешь выбрать заливку.");
        }
        private void какПеремещатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*зажми мышку внутри выделенной области нарисованной фигуры(внутри голобого контура) \n*передвинь фигуру и отпусти мышку");
        }

        private void Paint_Resize(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (type_of_shape == 1 && obj != null)
            {
                obj.Spin();
            }
            if (type_of_shape == 2 && obj_c != null)
            {
                obj_c.Spin();
            }
            if (type_of_shape == 4 && obj_r != null)
            {
                obj_r.Spin();
            }
        }

        private void какИзменитьРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*зажми мышку в правом нижнем углу фигуры\n*передвинь мышку на такое расстояние, на которое хочешь увеличить размер и отпусти мышку");
        }

        private void какРазвернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажми на кнопку <Поворот>");
        }
        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            mouse.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
            
            if (IsMouse)
            {
                if (checkBox2.Checked || line2_but.Checked)
                {
                    lastik.SetPoint(e.X, e.Y);
                    if (lastik.GetCountPoints() >= 2)
                    {
                        pen_lastik.Width = Pen_Width.Value;
                        if (checkBox2.Checked)
                            pen_lastik.Color = this.BackColor;
                        else
                            pen_lastik.Color = color;
                        g.DrawLines(pen_lastik, lastik.GetPoints());
                        lastik.SetPoint(e.X, e.Y);
                    }
                    drawSmth = null;
                }
                else
                    return;
            }
                
            if (type_of_shape == 1)
            {
                if (obj != null && (change_size || check))
                {
                    obj.Changing(new ChangeEventArgs(end));
                    return;
                }
                else
                {
                    Create_Line();
                }
            }
            if (type_of_shape == 2)
            {
                if (obj_c != null && change_size)
                {
                    obj_c.ChangeSize(end);
                    return;
                }
                if (obj_c != null && check)
                {
                    obj_c.MoveTo(end);
                }
                else
                {
                    Create_Circle();
                }
            }
            if (type_of_shape == 4)
            {
                if (obj_r != null && change_size)
                {
                    obj_r.ChangeSize(end);
                    return;
                }
                if (obj_r != null && check)
                    obj_r.MoveTo(end);
                else
                    Create_Rectangle();
            }
            if (type_of_shape == 3)
            {
                if (obj_s != null && change_size)
                {
                    obj_s.ChangeSize(end);
                    return;
                }
                if (obj_s != null && check)
                    obj_s.MoveTo(end);
                else
                {
                    Create_Square();
                }
            }
             if (drawSmth != null)
                drawSmth();
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouse = false;
            if (checkBox2.Checked || line2_but.Checked)
                return;
            lastik.ResetPoints();
            end = new Point(e.X, e.Y);
        }
        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouse = true;
            if (checkBox2.Checked || line2_but.Checked)
            { 
                lastik.ResetPoints();
                return;
            }
            start = new Point(e.X, e.Y);
            if (type_of_shape == 1 && obj != null)
            {

                if (obj.IfClick(new Point(e.X, e.Y)))
                {
                    check = true;
                    change_size = obj.IfClickEnd(new Point(e.X, e.Y));
                }
                else
                {
                    check = false;
                    obj.DeleteChoice();
                    obj.Flag = 1;
                    change_size = false;
                    obj.Draw();
                    obj = null;
                }
            }
            if (type_of_shape == 2 && obj_c != null)
            {
                if (obj_c.IfClick(new Point(e.X, e.Y)))
                {
                    check = true;
                    change_size = obj_c.IfClickEnd(new Point(e.X, e.Y));
                }
                else
                {
                    change_size = false;
                    check = false;
                    obj_c.DeleteChoice();
                    obj_c.Draw();
                    obj_c = null;
                }
            }
            if (type_of_shape == 4 && obj_r != null)
            {
                if (obj_r.IfClick(new Point(e.X, e.Y)))
                {
                    change_size = obj_r.IfClickEnd(new Point(e.X, e.Y));
                    check = true;
                }
                else
                {
                    check = false;
                    obj_r.DeleteChoice();
                    change_size = false;
                    obj_r.Draw();
                    obj_r = null;
                }
            }
            if (type_of_shape == 3 && obj_s != null)
            {
                if (obj_s.IfClick(new Point(e.X, e.Y)))
                {
                    change_size = obj_s.IfClickEnd(new Point(e.X, e.Y));
                    check = true;
                }
                else
                {
                    change_size = false;
                    check = false;
                    obj_s.DeleteChoice();
                    obj_s.Draw();
                    obj_s = null;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSettings();
        }
        public void ChangeSettings()
        {
            pen_lastik.Color = color;
            if (type_of_shape == 1 && obj != null)
            {
                obj.DeleteFigure();
                start = obj.Start;
                end = obj.End;
                Create_Line();
            }
            if (type_of_shape == 2 && obj_c != null)
            {
                obj_c.DeleteFigure();
                start = obj_c.Start;
                end = obj_c.End;
                Create_Circle();
            }
            if (type_of_shape == 3 && obj_s != null)
            {
                obj_s.DeleteFigure();
                start = obj_s.Start;
                end = obj_s.End;
                Create_Square();
            }
            if (type_of_shape == 4 && obj_r != null)
            {
                obj_r.DeleteFigure();
                start = obj_r.Start;
                end = obj_r.End;
                Create_Rectangle();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            switch (type_of_shape)
            {
                case 1:
                    {
                        if(obj != null) 
                            obj.DeleteChoice();
                        break;
                    }
                case 2:
                    {
                        if (obj_c != null)
                            obj_c.DeleteChoice();
                        break;
                    }
                case 3:
                    {
                        if (obj_s != null)
                            obj_s.DeleteChoice();
                        break;
                    }
                case 4:
                    {
                        if (obj_r != null)
                            obj_r.DeleteChoice();
                        break;
                    }
                default:
                    break;
            }
            check = false;
            obj = null;
            obj_c = null;
            obj_s = null;
            obj_r = null;
            drawSmth = null;
        }
    }
}
