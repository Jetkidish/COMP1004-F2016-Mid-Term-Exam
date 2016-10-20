using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Splash Form - Part of the COMP1004 F2016 Midterm Exam
 * Designed by Devon Cochrane (SN 200244662)
 * Last Modified 2016-10-20 @ 7:43pm
 * Rev 1
 * This displays the splash screen while the program loads
*/


namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SplashFormTimer_Tick Event Handler
        /// This displays the splash form for 3 seconds, then moves on to the generate name form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //this is so that the timer only goes once, otherwise it will open a billion generate name forms
            SplashFormTimer.Enabled = false;
            //this is where the generate name form opens
            GenerateNameForm startform = new GenerateNameForm();
            startform.Show();
            //this hides the splash screen
            this.Hide();
        }
    }
}
