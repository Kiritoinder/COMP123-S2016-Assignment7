using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * App Name : Movie Bonanza
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: This is the river class for the App Movie Bonanza.
 * Version: 0.0.6
 * DateCreated: August 18,2016
 * DateModified:August 19,2016
*/
namespace Assignment7
{
   public static class Program
    {
        //Alias names for forms
        public static SplashScrene SplashScrene;
        public static SelectionForm FirstForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FirstForm = new SelectionForm();
            SplashScrene = new SplashScrene();
//Running first Form
            Application.Run(SplashScrene);
        }
    }
}
