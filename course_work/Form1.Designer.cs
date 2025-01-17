namespace course_work
{
    partial class Paint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            line_but = new RadioButton();
            circle_but = new RadioButton();
            square_but = new RadioButton();
            rectangle_but = new RadioButton();
            width = new Label();
            mouse = new Label();
            Pen_Width = new TrackBar();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button8 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button9 = new Button();
            button6 = new Button();
            button7 = new Button();
            line2_but = new RadioButton();
            button10 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            clear = new Button();
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            какРисоватьToolStripMenuItem = new ToolStripMenuItem();
            какПеремещатьToolStripMenuItem = new ToolStripMenuItem();
            какИзменитьРазмерToolStripMenuItem = new ToolStripMenuItem();
            какРазвернутьToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Pen_Width).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // line_but
            // 
            line_but.AutoSize = true;
            line_but.Dock = DockStyle.Top;
            line_but.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic);
            line_but.Location = new Point(3, 91);
            line_but.Name = "line_but";
            line_but.Size = new Size(181, 23);
            line_but.TabIndex = 0;
            line_but.Text = "прямая";
            line_but.UseVisualStyleBackColor = true;
            line_but.CheckedChanged += line_but_CheckedChanged;
            // 
            // circle_but
            // 
            circle_but.AutoSize = true;
            circle_but.Dock = DockStyle.Top;
            circle_but.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic);
            circle_but.Location = new Point(3, 68);
            circle_but.Name = "circle_but";
            circle_but.Size = new Size(181, 23);
            circle_but.TabIndex = 1;
            circle_but.Text = "круг";
            circle_but.UseVisualStyleBackColor = true;
            circle_but.CheckedChanged += circle_but_CheckedChanged;
            // 
            // square_but
            // 
            square_but.AutoSize = true;
            square_but.Dock = DockStyle.Top;
            square_but.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic);
            square_but.Location = new Point(3, 45);
            square_but.Name = "square_but";
            square_but.Size = new Size(181, 23);
            square_but.TabIndex = 2;
            square_but.Text = "квадрат";
            square_but.UseVisualStyleBackColor = true;
            square_but.CheckedChanged += square_but_CheckedChanged;
            // 
            // rectangle_but
            // 
            rectangle_but.AutoSize = true;
            rectangle_but.Dock = DockStyle.Top;
            rectangle_but.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic);
            rectangle_but.Location = new Point(3, 22);
            rectangle_but.Name = "rectangle_but";
            rectangle_but.RightToLeft = RightToLeft.No;
            rectangle_but.Size = new Size(181, 23);
            rectangle_but.TabIndex = 3;
            rectangle_but.Text = "прямоугольник";
            rectangle_but.UseVisualStyleBackColor = true;
            rectangle_but.CheckedChanged += rectangle_but_CheckedChanged;
            // 
            // width
            // 
            width.AutoSize = true;
            width.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            width.Location = new Point(29, 154);
            width.Name = "width";
            width.Size = new Size(127, 19);
            width.TabIndex = 4;
            width.Text = "Толщина линии : 1";
            // 
            // mouse
            // 
            mouse.AutoSize = true;
            mouse.Dock = DockStyle.Bottom;
            mouse.Font = new Font("Comic Sans MS", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            mouse.Location = new Point(3, 67);
            mouse.Name = "mouse";
            mouse.Size = new Size(33, 17);
            mouse.TabIndex = 7;
            mouse.Text = "x: y:";
            // 
            // Pen_Width
            // 
            Pen_Width.BackColor = SystemColors.GradientInactiveCaption;
            Pen_Width.Location = new Point(6, 176);
            Pen_Width.Maximum = 20;
            Pen_Width.Minimum = 1;
            Pen_Width.Name = "Pen_Width";
            Pen_Width.Size = new Size(175, 45);
            Pen_Width.TabIndex = 8;
            Pen_Width.Value = 1;
            Pen_Width.Scroll += trackBar1_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(line2_but);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(line_but);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(circle_but);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(Pen_Width);
            groupBox1.Controls.Add(square_but);
            groupBox1.Controls.Add(width);
            groupBox1.Controls.Add(rectangle_but);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic);
            groupBox1.Location = new Point(0, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 466);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button7);
            groupBox3.Location = new Point(1, 227);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(183, 98);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Red;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(6, 22);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(42, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 10;
            label1.Text = "Цвет контура";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(42, 22);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(78, 22);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(114, 22);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Cyan;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(150, 22);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(78, 58);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(114, 58);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Blue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(6, 58);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 14;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Fuchsia;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(42, 58);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // line2_but
            // 
            line2_but.AutoSize = true;
            line2_but.Dock = DockStyle.Top;
            line2_but.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Italic);
            line2_but.Location = new Point(3, 114);
            line2_but.Name = "line2_but";
            line2_but.Size = new Size(181, 23);
            line2_but.TabIndex = 18;
            line2_but.Text = "линия";
            line2_but.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(84, 347);
            button10.Name = "button10";
            button10.Size = new Size(75, 32);
            button10.TabIndex = 12;
            button10.Text = "Поворот";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 353);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 23);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Ластик";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 324);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 23);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Заливка";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mouse);
            groupBox2.Controls.Add(clear);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 87);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // clear
            // 
            clear.Dock = DockStyle.Top;
            clear.Location = new Point(3, 22);
            clear.Name = "clear";
            clear.Size = new Size(175, 40);
            clear.TabIndex = 10;
            clear.Text = "Очистить";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(874, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { какРисоватьToolStripMenuItem, какПеремещатьToolStripMenuItem, какИзменитьРазмерToolStripMenuItem, какРазвернутьToolStripMenuItem });
            оПрограммеToolStripMenuItem.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(90, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // какРисоватьToolStripMenuItem
            // 
            какРисоватьToolStripMenuItem.Name = "какРисоватьToolStripMenuItem";
            какРисоватьToolStripMenuItem.Size = new Size(182, 22);
            какРисоватьToolStripMenuItem.Text = "как рисовать";
            какРисоватьToolStripMenuItem.Click += какРисоватьToolStripMenuItem_Click;
            // 
            // какПеремещатьToolStripMenuItem
            // 
            какПеремещатьToolStripMenuItem.Name = "какПеремещатьToolStripMenuItem";
            какПеремещатьToolStripMenuItem.Size = new Size(182, 22);
            какПеремещатьToolStripMenuItem.Text = "как перемещать";
            какПеремещатьToolStripMenuItem.Click += какПеремещатьToolStripMenuItem_Click;
            // 
            // какИзменитьРазмерToolStripMenuItem
            // 
            какИзменитьРазмерToolStripMenuItem.Name = "какИзменитьРазмерToolStripMenuItem";
            какИзменитьРазмерToolStripMenuItem.Size = new Size(182, 22);
            какИзменитьРазмерToolStripMenuItem.Text = "как изменить размер";
            какИзменитьРазмерToolStripMenuItem.Click += какИзменитьРазмерToolStripMenuItem_Click;
            // 
            // какРазвернутьToolStripMenuItem
            // 
            какРазвернутьToolStripMenuItem.Name = "какРазвернутьToolStripMenuItem";
            какРазвернутьToolStripMenuItem.Size = new Size(182, 22);
            какРазвернутьToolStripMenuItem.Text = "как повернуть";
            какРазвернутьToolStripMenuItem.Click += какРазвернутьToolStripMenuItem_Click;
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 490);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Paint";
            Text = "Paint 2.0";
            Load += Paint_Load;
            Click += Paint_Click;
            MouseClick += Paint_MouseClick;
            MouseDown += Paint_MouseDown;
            MouseMove += Paint_MouseMove;
            MouseUp += Paint_MouseUp;
            Resize += Paint_Resize;
            ((System.ComponentModel.ISupportInitialize)Pen_Width).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton line_but;
        private RadioButton circle_but;
        private RadioButton square_but;
        private RadioButton rectangle_but;
        private Label width;
        private Label mouse;
        private TrackBar Pen_Width;
        private GroupBox groupBox1;
        private Label label1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button clear;
        private Button button1;
        private ColorDialog colorDialog1;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem какРисоватьToolStripMenuItem;
        private ToolStripMenuItem какПеремещатьToolStripMenuItem;
        private CheckBox checkBox2;
        private Button button10;
        private ToolStripMenuItem какИзменитьРазмерToolStripMenuItem;
        private ToolStripMenuItem какРазвернутьToolStripMenuItem;
        private RadioButton line2_but;
        private GroupBox groupBox3;
    }
}
