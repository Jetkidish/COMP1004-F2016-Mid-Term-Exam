﻿namespace COMP1004_F2016_Mid_Term_Exam
{
    partial class RaceAndClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.RaceGroupBox = new System.Windows.Forms.GroupBox();
            this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
            this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.ElfRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RaceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 603);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(113, 40);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RaceGroupBox
            // 
            this.RaceGroupBox.Controls.Add(this.HalflingRadioButton);
            this.RaceGroupBox.Controls.Add(this.DwarfRadioButton);
            this.RaceGroupBox.Controls.Add(this.ElfRadioButton);
            this.RaceGroupBox.Controls.Add(this.HumanRadioButton);
            this.RaceGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.RaceGroupBox.Name = "RaceGroupBox";
            this.RaceGroupBox.Size = new System.Drawing.Size(146, 174);
            this.RaceGroupBox.TabIndex = 5;
            this.RaceGroupBox.TabStop = false;
            this.RaceGroupBox.Text = "Select Race";
            // 
            // HalflingRadioButton
            // 
            this.HalflingRadioButton.AutoSize = true;
            this.HalflingRadioButton.Location = new System.Drawing.Point(6, 120);
            this.HalflingRadioButton.Name = "HalflingRadioButton";
            this.HalflingRadioButton.Size = new System.Drawing.Size(87, 22);
            this.HalflingRadioButton.TabIndex = 5;
            this.HalflingRadioButton.Text = "Halfling";
            this.HalflingRadioButton.UseVisualStyleBackColor = true;
            this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // DwarfRadioButton
            // 
            this.DwarfRadioButton.AutoSize = true;
            this.DwarfRadioButton.Location = new System.Drawing.Point(6, 92);
            this.DwarfRadioButton.Name = "DwarfRadioButton";
            this.DwarfRadioButton.Size = new System.Drawing.Size(70, 22);
            this.DwarfRadioButton.TabIndex = 4;
            this.DwarfRadioButton.Text = "Dwarf";
            this.DwarfRadioButton.UseVisualStyleBackColor = true;
            this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // ElfRadioButton
            // 
            this.ElfRadioButton.AutoSize = true;
            this.ElfRadioButton.Location = new System.Drawing.Point(6, 64);
            this.ElfRadioButton.Name = "ElfRadioButton";
            this.ElfRadioButton.Size = new System.Drawing.Size(45, 22);
            this.ElfRadioButton.TabIndex = 3;
            this.ElfRadioButton.Text = "Elf";
            this.ElfRadioButton.UseVisualStyleBackColor = true;
            this.ElfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.Checked = true;
            this.HumanRadioButton.Location = new System.Drawing.Point(6, 36);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(79, 22);
            this.HumanRadioButton.TabIndex = 0;
            this.HumanRadioButton.TabStop = true;
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            this.HumanRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(701, 602);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(113, 40);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP1004_F2016_Mid_Term_Exam.Properties.Resources.Human_Male;
            this.pictureBox1.Location = new System.Drawing.Point(165, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // RaceAndClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 654);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RaceGroupBox);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RaceAndClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race And Class Selection";
            this.RaceGroupBox.ResumeLayout(false);
            this.RaceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox RaceGroupBox;
        private System.Windows.Forms.RadioButton HalflingRadioButton;
        private System.Windows.Forms.RadioButton DwarfRadioButton;
        private System.Windows.Forms.RadioButton ElfRadioButton;
        private System.Windows.Forms.RadioButton HumanRadioButton;
        protected System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}