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
 * Description: This class provides Information on selected Movies.
 * Version: 0.0.5
 * DateCreated: August 19,2016
 * DateModified:August 19,2016
*/
namespace Assignment7
{
    public partial class OrderForm : Form
    {
        // Private Instance variables
        private string _title, _cat, _price;

        //public methods
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Category
        {
            get
            {
                return _cat;
            }
            set
            {
                _cat = value;
            }
        }
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }



        public SelectionForm FirstForm = Program.FirstForm;

        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(System.Drawing.Image e)
        {
            InitializeComponent();
            MoviePictureBox.Image = e;

        }

        private void MoviePictureBox_Click(object sender, EventArgs e)
        {

        }
//next Form
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm StreamForm1 = new StreamForm();
            StreamForm1.Title = TitleTextBox.Text;
            StreamForm1.GrandTotal = GrandTotalTextBox.Text;
            StreamForm1.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionForm SelectionForm1 = new SelectionForm();
            SelectionForm1.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox = new AboutBox1();
            AboutBox.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm.Show();
        }

        //Methods on form Loading
        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Title;
            CategoryTextBox.Text = Category;
            PriceTextBox.Text = Price;

            double MoviePrice = 10.00;
            //double subTotal =  double.Parse(PriceTextBox.Text);
        //    double salesTax = 0.13 * subTotal;
          //  double grandTotal = salesTax + subTotal;

            if (BuyCheckBox.Checked)
            {
                ExtraPriceTextBox.Visible = true;
                ExtraPriceLabel.Visible = true;

                //There is some Exception handling error here

            /**   double ExtraPriceSubTotal = subTotal + MoviePrice;
                double ExtraPriceSalesTax = 0.13 * ExtraPriceSubTotal;
                double ExtraPriceGrandTotal = ExtraPriceSalesTax + ExtraPriceSubTotal;
                 subTotal = ExtraPriceSubTotal;
                salesTax = ExtraPriceSalesTax;
                grandTotal = ExtraPriceGrandTotal;
                GrandTotalTextBox.Text = grandTotal.ToString("C");
                SubTotalTextBox.Text = subTotal.ToString("C");
                SalesTaxTextBox.Text = salesTax.ToString("C");*/
                ExtraPriceTextBox.Text = MoviePrice.ToString("C");
            }
            else
            {
                ExtraPriceTextBox.Visible = false;
                ExtraPriceLabel.Visible = false;
        /**        SalesTaxTextBox.Text = salesTax.ToString("C");
                SubTotalTextBox.Text = subTotal.ToString("C");
                GrandTotalTextBox.Text = grandTotal.ToString("C");*/
            }
        }

    }
}

