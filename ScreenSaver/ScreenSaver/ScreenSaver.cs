using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class ScreenSaver : Form
    {

        Random r;
        int angle;

        public ScreenSaver()
        {
            r = new Random();
            angle = r.Next(360);
            InitializeComponent();
            GraphicsPath shape = new GraphicsPath();
            shape.AddEllipse(0, 0, 50, 50);
            this.Region = new Region(shape);
            MessageBox.Show("A ball will be generated with angle: " + angle);
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {

            double radian = (angle * Math.PI) / 180;
            Top -= (int)(10 * Math.Sin(radian));
            Left += (int)(10 * Math.Cos(radian));

            if(this.DesktopLocation.Y <= 0)
            {
                angle = 360 - angle;
                radian = (angle * Math.PI) / 180;
            }
            if(this.DesktopLocation.X <= 0)
            {   
                angle = 180 - angle;
                radian = (angle * Math.PI) / 180;
            }
            if (this.DesktopLocation.X >= Screen.PrimaryScreen.Bounds.Width - 50)
            {
                angle = 180 - angle;
                radian = (angle * Math.PI) / 180;
            }

            if(this.DesktopLocation.Y >= Screen.PrimaryScreen.Bounds.Height - 50)
            {
                angle = 360 - angle;
                radian = (angle * Math.PI) / 180;

            }

        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

    }
}
