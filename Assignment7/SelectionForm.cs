using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * App Name : Movie Bonanza
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: This class selects Movies.
 * Version: 0.0.5
 * DateCreated: August 18,2016
 * DateModified:August 19,2016
*/
namespace Assignment7
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }
        //Loading Movies for user
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
//Movie Catogeries
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
            categoryList[19] = "New Releases";
            categoryList[20] = "New Releases";
           
            CategoryList.Items.AddRange(categoryList);
//Movie Prices
            string[] priceList = new string[9];
            priceList[0] = "Price";
            priceList[1] = "$1.99";
            priceList[2] = "$1.99";
            priceList[3] = "$2.99";
            priceList[4] = "$2.99";
            priceList[5] = "$2.99";
            priceList[6] = "$1.99";
            priceList[7] = "$0.99";
            priceList[8] = "$4.99";
            PriceList.Items.AddRange(priceList);
//Categories
            string[] categoryPriceList = new string[9];
            categoryPriceList[0] = "Category";
            categoryPriceList[1] = "Comedy";
            categoryPriceList[2] = "Drama";
            categoryPriceList[3] = "Action";
            categoryPriceList[4] = "Sci-Fi";
            categoryPriceList[5] = "Horror";
            categoryPriceList[6] = "Thriller";
            categoryPriceList[7] = "Family";
            categoryPriceList[8] = "New Releases";
           CategoryPriceListBox.Items.AddRange(categoryPriceList);

        }


//Application closing
        private void Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void MoviePictureBox_Click(object sender, EventArgs e)
        {
        }
        //Form Operations
        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = string.Empty;
            foreach (string value in MoviesList.SelectedItems)
            {
                if (value == "Season of the Witch")//1
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.sow);
                    CategoryTextBox.Text = CategoryList.Items[1].ToString();
                }
                if (value == "The Green Hornet")//2
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TGH);
                    CategoryTextBox.Text = CategoryList.Items[2].ToString();
                }
                if (value == "The Dilema")//3
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TD);
                    CategoryTextBox.Text = CategoryList.Items[3].ToString();
                }
                if (value == "Death Race 2")//4
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.DR2);
                    CategoryTextBox.Text = CategoryList.Items[4].ToString();
                }
                if (value == "Company Men")//5
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.CM);
                    CategoryTextBox.Text = CategoryList.Items[5].ToString();
                }
                if (value == "No Strings Attached")//6
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.NSA);
                    CategoryTextBox.Text = CategoryList.Items[6].ToString();
                }
                if (value == "The Way Back")//7
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TWB);
                    CategoryTextBox.Text = CategoryList.Items[7].ToString();
                }
                if (value == "The Mechanic")//8
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TM);
                    CategoryTextBox.Text = CategoryList.Items[8].ToString();
                }
                if (value == "The Rite")//9
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TR);
                    CategoryTextBox.Text = CategoryList.Items[9].ToString();
                }
                if (value == "Sanctum")//10
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.SA);
                    CategoryTextBox.Text = CategoryList.Items[10].ToString();
                }
                if (value == "The Other Woman")//11
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TOW);
                    CategoryTextBox.Text = CategoryList.Items[11].ToString();
                }
                if (value == "The Roommate")//12
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TRM);
                    CategoryTextBox.Text = CategoryList.Items[12].ToString();
                }
                if (value == "Waiting for Forever")//13
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.WFF);
                    CategoryTextBox.Text = CategoryList.Items[13].ToString();
                }
                if (value == "Cedar Rapids")//14
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.CR);
                    CategoryTextBox.Text = CategoryList.Items[14].ToString();
                }
                if (value == "Gnomeo and Juliet")//15
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.GAJ);
                    CategoryTextBox.Text = CategoryList.Items[15].ToString();
                }
                if (value == "Just Go With It")//16
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.JGWI);
                    CategoryTextBox.Text = CategoryList.Items[16].ToString();
                }
                if (value == "The Eagle")//17
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.TE);
                    CategoryTextBox.Text = CategoryList.Items[17].ToString();
                }
                if (value == "I am Number Four")//18
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.IAN4);
                    CategoryTextBox.Text = CategoryList.Items[18].ToString();
                }
                if (value == "Footloose")//19
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.FL);
                    CategoryTextBox.Text = CategoryList.Items[19].ToString();
                }

                if (value == "Real Steal")//20
                {
                    TitleTextBox.Text = value.ToString();
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.RS);
                    CategoryTextBox.Text = CategoryList.Items[20].ToString();
                }
                
                // SETTING PRICE
                if (CategoryTextBox.Text == "Action")
                {
                    PriceTextBox.Text = PriceList.Items[3].ToString();
                }
                if (CategoryTextBox.Text == "Drama")
                {
                    PriceTextBox.Text = PriceList.Items[2].ToString();
                }
                if (CategoryTextBox.Text == "Comedy")
                {
                    PriceTextBox.Text = PriceList.Items[1].ToString();
                }
                if (CategoryTextBox.Text == "Sci-Fi")
                {
                    PriceTextBox.Text = PriceList.Items[4].ToString();
                }
                if (CategoryTextBox.Text == "Horror")
                {
                    PriceTextBox.Text = PriceList.Items[5].ToString();
                }
                if (CategoryTextBox.Text == "Thriller")
                {
                    PriceTextBox.Text = PriceList.Items[6].ToString();
                }
                if (CategoryTextBox.Text == "Family")
                {
                    PriceTextBox.Text = PriceList.Items[7].ToString();
                }
                if (CategoryTextBox.Text == "New Releases")
                {
                    PriceTextBox.Text = PriceList.Items[8].ToString();
                }

            }

        }
//Next Form
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm OrderForm1 = new OrderForm(MoviePictureBox.Image);

            OrderForm1.Title = TitleTextBox.Text;
            OrderForm1.Category = CategoryTextBox.Text;
            OrderForm1.Price = PriceTextBox.Text; 
            OrderForm1.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
