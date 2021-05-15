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
    public partial class SelectPlace : Form
    {
        int[,] places = new int[7, 14]
            {
                {1,2,3,4,5,6,7,8,9,10,0,0,0,0 },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                { 1,2,3,4,5,6,7,8,9,10,11,12,13,14 },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                { 1,2,3,4,5,6,0,0,0,0,0,0,0,0}
            };
        public static string row;
        public static string place;
        public SelectPlace()
        {
            InitializeComponent();
            lFilm.Text = SelectMovie.film;
            lDate.Text = SelectMovie.date;
            lTime.Text = SelectMovie.time;
            for (int i = 1; i <= 6; i++)
            {
                comboBoxRows.Items.Add(i);
            }

        }

        private void imgHallClick(object sender, EventArgs e)
        {
            Hall hall = new Hall();
            hall.Show();
        }

        private void comboBoxRowsSelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPlaces.Items.Clear();
            if (comboBoxRows.SelectedIndex == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    comboBoxPlaces.Items.Add(places[0, i]);
                }
               
            }
            else if (comboBoxRows.SelectedIndex == 5)
            {
                for (int i = 0; i < 6; i++)
                {
                    comboBoxPlaces.Items.Add(places[5, i]);
                }
            }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                        comboBoxPlaces.Items.Add(places[Convert.ToInt32(comboBoxRows.Text), i]);
                }
            }
        }
        int j = 0;
        private void btnAddClick(object sender, EventArgs e)
        {
            if(comboBoxPlaces.SelectedItem==null || comboBoxPlaces.SelectedItem == null)
            {
                MessageBox.Show("Выберите ряд и место!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                j++;
                if (j < 7)
                {
                    lRow.Visible = true;
                    lRow.Text = comboBoxRows.Text;
                    row = comboBoxRows.Text;
                    lPlace.Visible = true;
                    place = comboBoxPlaces.Text;
                    lPlace.Text = comboBoxPlaces.Text;
                }

            }
        }

        private void btnContinueClick(object sender, EventArgs e)
        {
            if(lRow.Visible==true && lPlace.Visible==true)
            {
                this.Hide();
                Total total = new Total();
                total.Show();
            }
            else
            {
                MessageBox.Show("Выберите ряд и место!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            this.Hide();
            SelectMovie selectMovie = new SelectMovie();
            selectMovie.Show();
        }

        private void btnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectPLaceClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
