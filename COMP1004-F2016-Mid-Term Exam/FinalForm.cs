using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
            this.FinalForm_Load();
            
        }
        /// <summary>
        /// Final Form Load method
        /// This is called when the program is initialized, and will ensure all textboxes and pictureboxes are updated accordingly
        /// </summary>
        private void FinalForm_Load()
        {
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            StrengthTextBox.Text = Program.character.Strength.ToString();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();
            CharismaTextBox.Text = Program.character.Charisma.ToString();
            RaceTextBox.Text = Program.character.Race;
            if (RaceTextBox.Text == "Human")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Human_Male;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (RaceTextBox.Text == "Elf")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Elf_Male;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (RaceTextBox.Text == "Halfling")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Halfling_Male;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (RaceTextBox.Text == "Dwarf")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Dwarf_Male;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        /// <summary>
        /// aboutToolStripMenuItem_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// BackButton_Click Event Handler
        /// This will take the user back to the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        /// <summary>
        /// ExitToolStripMenuItem_Click
        /// This will exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
