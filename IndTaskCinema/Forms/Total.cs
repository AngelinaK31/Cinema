using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IndTaskCinema
{
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
            lFilm.Text = SelectMovie.film;
            lDate.Text = SelectMovie.date;
            lTime.Text = SelectMovie.time;
            lRow.Text = SelectPlace.row;
            lPlace.Text = SelectPlace.place;
        }

        private void btnFormalizeClick(object sender, EventArgs e)
        {
            if (tbFirstname.Text == null || tbSecondname.Text == null)
            {
                           MessageBox.Show("Введите свою фамилию и имя!", "Ошибка",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var helper = new WordHelper("ticket.docx");

                var items = new Dictionary<string, string>
            {
                {"<FILM>",  lFilm.Text},
                {"<DATE>",  lDate.Text},
                {"<TIME>",  lTime.Text},
                {"<HALL>",  lHall.Text},
                {"<ROW>",  lRow.Text},
                {"<PLACE>",  lPlace.Text},
                {"<COST>",  lCost.Text},
                {"<FIRSTNAME>",  tbFirstname.Text},
                {"<SURNAME>",  tbSecondname.Text},
            };
                helper.Process(items);

                /*using (FileStream fstream = new FileStream("ticket.docx", FileMode.Create))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes("Привет");
                    fstream.Write(array, 0, array.Length);

                }*/
                lSuccess.Visible = true;

            }
        }

        private void TotalClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            this.Hide();
            SelectPlace selectPlace = new SelectPlace();
            selectPlace.Show();
        }
    }
}
