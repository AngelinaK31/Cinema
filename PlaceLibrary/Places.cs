using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLibrary;
using System.Windows.Forms;

namespace PlaceLibrary
{
     public class Places
    {
        int[,] places = new int[6, 14]
            {
                {1,2,3,4,5,6,7,8,9,10,0,0,0,0 },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                { 1,2,3,4,5,6,7,8,9,10,11,12,13,14 },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                {1,2,3,4,5,6,7,8,9,10,11,12,13,14  },
                { 1,2,3,4,5,6,0,0,0,0,0,0,0,0}
            };
        public static string row;
        public static string place;
        public  void SelectPlace(label lFilm, label lDate, label lTime, ComboBox comboBoxRows )
        {
            lFilm.Text = SelectMovie.film;
            lDate.Text = SelectMovie.date;
            lTime.Text = SelectMovie.time;
            for (int i = 1; i <= 6; i++)
            {
                comboBoxRows.Items.Add(i);
            }

        }
    }
}
