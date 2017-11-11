﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EstopButtonClick(object sender, EventArgs e)
        {

        }

        private void addCueButton_Click(object sender, EventArgs e)
        {

        }

        private void editCueButton_Click(object sender, EventArgs e)
        {

        }

        private void removeCueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?", "Remove Cue",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }


        private void cueManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void motorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playCueButton_Click(object sender, EventArgs e)
        {

        }

        private void pauseCueButton_Click(object sender, EventArgs e)
        {

        }

        private void nextCueButton_Click(object sender, EventArgs e)
        {

        }

        private void previousCueButton_Click(object sender, EventArgs e)
        {

        }

        private void stopCueButton_Click(object sender, EventArgs e)
        {

        }

        private void moveCueUpButton_Click(object sender, EventArgs e)
        {

        }

        private void moveCueDownButton_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new ManualControlForm());
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e) {
            switchToForm(new SetupCueForm());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().Show();
        }

        private void switchToForm(Form form)
        {
            form.Show();
            form.Left = this.Left;
            form.Top = this.Top;

            this.Hide();
        }

        private void calibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new SetupMotorForm());
        }
    }
}