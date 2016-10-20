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
 * Generate Name Form - Part of the COMP1004 F2016 Midterm Exam
 * Designed by Devon Cochrane (SN 200244662)
 * Last Modified 2016-10-20 @ 7:43pm
 * Rev 1.3
 * This form will generate a random name, and accept a custom name
*/


namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class GenerateNameForm : Form
    {
        // private Instance Object
        private Random _random;

        public GenerateNameForm()
        {
            InitializeComponent();
            this.GenerateForm_Load();
            
        }
        /// <summary>
        /// GenerateForm_Load
        /// This is called when the form is initialized, and will call the generate names method
        /// </summary>
        private void GenerateForm_Load()
        {
            this._random = new Random(); // initialize random number object
            GenerateNames();

        }
        /// <summary>
        /// GenerateNames Method
        /// This will take a random number and assign it's value to an int
        /// Then, it will pick the corresponding value from the list box 
        /// </summary>
        private void GenerateNames()
        {
            int generatedNumber = this._random.Next(0, 50);
            int generatedNumber2 = this._random.Next(0, 50);
            FirstNameListBox.SetSelected(generatedNumber, true);
            LastNameListBox.SetSelected(generatedNumber2, true);
        }
        /// <summary>
        /// GenerateButton_Click Event Handler
        /// This calls the generatenames method, and also sets the FirstName/LastName values to what is currently in the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }
        /// <summary>
        /// NextButton_Click Event Handler
        /// This will show the next form, and will also set the FirstName/LastName values to what is currently in the text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //this hides the current form and opens the next form
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }
        /// <summary>
        /// FirstNameListBox_SelectedIndexChanged Event Handler
        /// This will update all appropriate info based on what the user selects from the FirstNameListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = (string)FirstNameListBox.SelectedItem;
            Character character = Program.character;
            character.FirstName = (string)FirstNameListBox.SelectedItem;
        }
        /// <summary>
        /// LastNameListBox_SelectedIndexChanged
        /// This will update all appropriate info based on what the user selects from the LastNameListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastNameTextBox.Text = (string)LastNameListBox.SelectedItem;
            Character character = Program.character;
            character.LastName = (string)LastNameListBox.SelectedItem;
        }
    }
}
