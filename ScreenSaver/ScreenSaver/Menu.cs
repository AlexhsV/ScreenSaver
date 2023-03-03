using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{


    
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
        
            for (int i = 0; i < Int16.Parse(textBox1.Text); i++)
            {
                new ScreenSaver().Show();

            }
            this.Hide();
        }
    }
}
