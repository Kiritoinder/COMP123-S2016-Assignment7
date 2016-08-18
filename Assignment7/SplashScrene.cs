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
    public partial class SplashScrene : Form
    {
        public SelectionForm FirstForm = Program.FirstForm;
        public SplashScrene()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            timer.Enabled = false;
            FirstForm.Show();
            this.Hide();
            
        }
    }
}
