using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndTaskCinema
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnStartClick(object sender, EventArgs e)
        {
            this.Hide();
            SelectMovie selectMovie = new SelectMovie();
            selectMovie.Show();
            
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAboutProgClick(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.Show();
        }

        private void HomePageClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
