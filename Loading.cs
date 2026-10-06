using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGAme
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private async void Loading_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    await Task.Delay(500);
                    progressBar1.Value += 10;
                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";
                   
                }
                else
                {
                    for (double j = 1.0; j > 0.0; j -= 0.1)
                    {
                        this.Opacity = j;
                        await Task.Delay(20); 
                    }                   
                     Game g = new Game();
                    g.Show();
                    this.Hide();             
                    this.Opacity = 1.0;
                }

            }
        }
    }
}
