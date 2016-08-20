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
 * Description: This is Splash Screne of the app.
 * Version: 0.0.5
 * DateCreated: August 18,2016
 * DateModified:August 19,2016
*/
namespace Assignment7
{
    public partial class SplashScrene : Form
    {
        // alias for selectionForm
        public SelectionForm FirstForm = Program.FirstForm;
        public SplashScrene()
        {
            InitializeComponent();
        }
//Tick event and next form
        private void timer_Tick(object sender, EventArgs e)
        {

            timer.Enabled = false;
            FirstForm.Show();
            this.Hide();
            
        }
    }
}
