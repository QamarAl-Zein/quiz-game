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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

            
        public Score(Game.GameResult result, int totalQuestions)
        {
            InitializeComponent();

            lblAns.Text = result.TotalQuestions + " / " + totalQuestions;
            lblCorrect.Text = result.Score + " / " + totalQuestions;
        }
        

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            Loading loadingForm = new Loading();
            loadingForm.Show();
            this.Close();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
