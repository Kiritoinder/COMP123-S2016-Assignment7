using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class SelectionForm : Form
    {
        decimal[] price = new decimal[]
            {1.99m, 1.99m, 2.99m, 2.99m, 2.99m, 1.99m, 0.99m, 4.99m};
        string[] comedyMovies = new string[] { };

        public SelectionForm()
        {
            InitializeComponent();
        }

        public void Movies_Load(object sender, EventArgs e)
        {
            string[] MovieList = new string[21];

            MovieList[0] = "    Movies    ";
            MovieList[1] = "Season of the Witch";
            MovieList[2] = "The Green Hornet";
            MovieList[3] = "The Dilema";
            MovieList[4] = "Death Race 2";
            MovieList[5] = "Company Men";
            MovieList[6] = "No Strings Attached";
            MovieList[7] = "The Way Back";
            MovieList[8] = "The Mechanic";
            MovieList[9] = "The Rite";
            MovieList[10] = "Sanctum";
            MovieList[11] = "The Other Woman";
            MovieList[12] = "The Roommate";
            MovieList[13] = "Waiting for Forever";
            MovieList[14] = "Cedar Rapids";
            MovieList[15] = "Gnomeo and Juliet";
            MovieList[16] = "Just Go With It";
            MovieList[17] = "The Eagle";
            MovieList[18] = "I am Number Four";
            MovieList[19] = "Footloose";
            MovieList[20] = "Real Steal";
            MoviesList.Items.AddRange(MovieList);

            string[] categoryList = new string[21];
            categoryList[0] = "    Category    ";
            categoryList[1] = "Sci-Fi";
            categoryList[2] = "Action";
            categoryList[3] = "Comedy";
            categoryList[4] = "Action";
            categoryList[5] = "Drama";
            categoryList[6] = "Comedy";
            categoryList[7] = "Drama";
            categoryList[8] = "Action";
            categoryList[9] = "Horror";
            categoryList[10] = "Action";
            categoryList[11] = "Action";
            categoryList[12] = "Thriller";
            categoryList[13] = "Drama";
            categoryList[14] = "Comedy";
            categoryList[15] = "family";
            categoryList[16] = "Comedy";
            categoryList[17] = "Action";
            categoryList[18] = "Sci-Fi";
            categoryList[19] = "New Release";
            categoryList[20] = "New Release";
            CategoryList.Items.AddRange(categoryList);


        }



        private void Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void MoviePictureBox_Click(object sender, EventArgs e)
        {
        }

        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string value in MoviesList.SelectedItems)
                if (value == "Season of the Witch")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.Movie_Bonanza);
                }

        }
    }
}
