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
 * Description: This class provides Streaming Infrormation after the payment.
 * Version: 0.0.5
 * DateCreated: August 19,2016
 * DateModified:August 19,2016
*/
namespace Assignment7
{
    public partial class StreamForm : Form
    {
        // Private Instance variables
        private string _title, _grandTotal;
        //public methods
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string GrandTotal
        {
            get { return _grandTotal; }
            set { _grandTotal = value; }
        }
//next Form
        private void StreamForm_Load(object sender, EventArgs e)
        {
            GrandTotalLabel.Text = "Your Credit card has been Charged" + _grandTotal.ToString();
            MovieLabel.Text = _title + " will stream shortly.";

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public StreamForm()
        {
            InitializeComponent();
        }
    }
}
