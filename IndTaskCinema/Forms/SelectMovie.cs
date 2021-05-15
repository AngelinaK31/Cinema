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
        
    public partial class SelectMovie : Form
    {
        public static string date;
        public static string film;
        public static string time;
        int i = 0;
        public SelectMovie()
        {
            InitializeComponent();
            
        }

        private void btnChooseTimeClick(object sender, EventArgs e)
        {
            if (i>0)
            {
                int index = Convert.ToInt32((sender as Button).Tag);
                if (index > 0 && index < 4)
                    film = "Черная вдова";             
                if (index > 3 && index < 7)
                    film = "Мулан";
                if (index > 6 && index < 10)
                    film = "Бладшот";
                if (index > 9 && index < 13)
                    film = "Калашников";
                if (index > 12 && index < 16)
                    film = "Довод";
                date = cld.SelectionRange.Start.ToShortDateString();
                time = (sender as Button).Text;
                this.Hide();
                SelectPlace selectPlace = new SelectPlace();
                selectPlace.Show();
            }
            else
            {
                MessageBox.Show("Выберите дату!",  "Ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cldDateChanged(object sender, DateRangeEventArgs e)
        {
            i++;
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
            
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectMovieClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
