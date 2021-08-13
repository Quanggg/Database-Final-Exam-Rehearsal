using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Final_Exam_Rehearsal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < 0; i++)
            {
                Panel panel = new Panel();
                Button btn = new Button();
                btn.Text = "BUTTON " + i.ToString();
                panel.Dock = DockStyle.Top;
                btn.Width = 100;
                btn.Height = 200;
                btn.Dock = DockStyle.Fill;
                panel.Padding = new Padding(30);
                panel1.Controls.Add(panel);
                panel.Controls.Add(btn);
                panel.BringToFront();
            }
        }
    }
}
