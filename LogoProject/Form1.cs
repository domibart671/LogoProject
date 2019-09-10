using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoProject
{
    public partial class Form1 : Form
    {
        private object drawpen;
        private object g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //graphic objects
            Graphics g = this.CreateGraphics();
            Pen drawpen = new Pen(Color.Red, 2);
            SolidBrush drawBrushT = new SolidBrush(Color.White);
            SolidBrush drawBrushY = new SolidBrush(Color.Red);
            Font drawfont = new Font("Sugar Pie", 16, FontStyle.Bold);

            g.DrawEllipse(drawpen, 50, 45, 60, 60);
            g.FillEllipse(drawBrushY, 50, 45, 60, 60);
            // code for my text
            g.DrawString("P", drawfont, drawBrushT, 70, 62);
        }
    }
}
