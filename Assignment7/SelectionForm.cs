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
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void Movies_Load(object sender, EventArgs e)
        {

        }

        private void Movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
