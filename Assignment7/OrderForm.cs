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
    public partial class OrderForm : Form
    {
        private string _title, _cat, _price;

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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Title;
            CategoryTextBox.Text = Category;
            PriceTextBox.Text = Price;
        }
    }
}
