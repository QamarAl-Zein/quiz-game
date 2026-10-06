using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGAme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

          private Loading frm = new Loading();


        private async void button1_Click_1(object sender, EventArgs e)
        {
            for (double i = 1.0; i > 0.0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(5); 
            }       
            frm.Show();
            this.Hide();     
            this.Opacity = 1.0;
        }
    }
}
