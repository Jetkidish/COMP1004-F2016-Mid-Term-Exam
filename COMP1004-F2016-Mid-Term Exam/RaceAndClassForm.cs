using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
            if (this._selectedRace == "Human")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Human_Male;
            }
            else if (this._selectedRace == "Elf")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Elf_Male;
            }
            else if (this._selectedRace == "Halfling")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Halfling_Male;
            }
            else if (this._selectedRace == "Dwarf")
            {
                pictureBox1.Image = COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Dwarf_Male;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //this was added by Devon Cochrane, since the final form would not be updated properly without it!!
            Character character = Program.character;

            character.Race = this._selectedRace;

            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }
    }
}
