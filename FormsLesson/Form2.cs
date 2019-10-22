using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLesson
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Form1 oldForm = new Form1();
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Gray;
            Label label1 = new Label
            {
            Location = new Point
                {
                    X = this.Width/7,
                    Y = this.Height/5

                }
            };
            label1.Text = "Don't forget about us..";
            this.Controls.Add(label1);

            Button button1 = new Button
            {
                Location = new Point
                {
                    X = this.Width / 3,
                    Y = this.Height / 3
                }
            };
            button1.Text = "I'll be back!";
            button1.Click += button1_Click;
            
            this.Controls.Add(button1);
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 250, 100);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
