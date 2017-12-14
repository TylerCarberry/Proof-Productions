﻿namespace Proof_Productions.View
{
    partial class NewMotorForm
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescTextBox = new System.Windows.Forms.RichTextBox();
            this.PLCNameTextBox = new System.Windows.Forms.TextBox();
            this.PLCNameLabel = new System.Windows.Forms.Label();
            this.MaxVelocityLabel = new System.Windows.Forms.Label();
            this.MaxAccelerationLabel = new System.Windows.Forms.Label();
            this.MaxDecelerationLabel = new System.Windows.Forms.Label();
            this.MaxNegativePositionLabel = new System.Windows.Forms.Label();
            this.MaxPositivePositionLabel = new System.Windows.Forms.Label();
            this.MaxVelTextBox = new System.Windows.Forms.TextBox();
            this.MaxAccelTextBox = new System.Windows.Forms.TextBox();
            this.MaxDecelTextBox = new System.Windows.Forms.TextBox();
            this.MaxNegPosTextBox = new System.Windows.Forms.TextBox();
            this.MaxPosPosTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(134, 215);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(234, 215);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Motor Name";
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Location = new System.Drawing.Point(12, 160);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(58, 13);
            this.IPAddressLabel.TabIndex = 3;
            this.IPAddressLabel.Text = "IP Address";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(81, 21);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(128, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(81, 157);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(128, 20);
            this.IPAddressTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(81, 47);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(128, 105);
            this.DescTextBox.TabIndex = 7;
            this.DescTextBox.Text = "";
            // 
            // PLCNameTextBox
            // 
            this.PLCNameTextBox.Location = new System.Drawing.Point(81, 183);
            this.PLCNameTextBox.Name = "PLCNameTextBox";
            this.PLCNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.PLCNameTextBox.TabIndex = 8;
            // 
            // PLCNameLabel
            // 
            this.PLCNameLabel.AutoSize = true;
            this.PLCNameLabel.Location = new System.Drawing.Point(12, 186);
            this.PLCNameLabel.Name = "PLCNameLabel";
            this.PLCNameLabel.Size = new System.Drawing.Size(58, 13);
            this.PLCNameLabel.TabIndex = 9;
            this.PLCNameLabel.Text = "PLC Name";
            // 
            // MaxVelocityLabel
            // 
            this.MaxVelocityLabel.AutoSize = true;
            this.MaxVelocityLabel.Location = new System.Drawing.Point(231, 24);
            this.MaxVelocityLabel.Name = "MaxVelocityLabel";
            this.MaxVelocityLabel.Size = new System.Drawing.Size(67, 13);
            this.MaxVelocityLabel.TabIndex = 10;
            this.MaxVelocityLabel.Text = "Max Velocity";
            // 
            // MaxAccelerationLabel
            // 
            this.MaxAccelerationLabel.AutoSize = true;
            this.MaxAccelerationLabel.Location = new System.Drawing.Point(231, 50);
            this.MaxAccelerationLabel.Name = "MaxAccelerationLabel";
            this.MaxAccelerationLabel.Size = new System.Drawing.Size(89, 13);
            this.MaxAccelerationLabel.TabIndex = 11;
            this.MaxAccelerationLabel.Text = "Max Acceleration";
            // 
            // MaxDecelerationLabel
            // 
            this.MaxDecelerationLabel.AutoSize = true;
            this.MaxDecelerationLabel.Location = new System.Drawing.Point(231, 76);
            this.MaxDecelerationLabel.Name = "MaxDecelerationLabel";
            this.MaxDecelerationLabel.Size = new System.Drawing.Size(90, 13);
            this.MaxDecelerationLabel.TabIndex = 12;
            this.MaxDecelerationLabel.Text = "Max Deceleration";
            // 
            // MaxNegativePositionLabel
            // 
            this.MaxNegativePositionLabel.AutoSize = true;
            this.MaxNegativePositionLabel.Location = new System.Drawing.Point(231, 102);
            this.MaxNegativePositionLabel.Name = "MaxNegativePositionLabel";
            this.MaxNegativePositionLabel.Size = new System.Drawing.Size(113, 13);
            this.MaxNegativePositionLabel.TabIndex = 13;
            this.MaxNegativePositionLabel.Text = "Max Negative Position";
            // 
            // MaxPositivePositionLabel
            // 
            this.MaxPositivePositionLabel.AutoSize = true;
            this.MaxPositivePositionLabel.Location = new System.Drawing.Point(231, 128);
            this.MaxPositivePositionLabel.Name = "MaxPositivePositionLabel";
            this.MaxPositivePositionLabel.Size = new System.Drawing.Size(107, 13);
            this.MaxPositivePositionLabel.TabIndex = 14;
            this.MaxPositivePositionLabel.Text = "Max Positive Position";
            // 
            // MaxVelTextBox
            // 
            this.MaxVelTextBox.Location = new System.Drawing.Point(345, 21);
            this.MaxVelTextBox.Name = "MaxVelTextBox";
            this.MaxVelTextBox.Size = new System.Drawing.Size(128, 20);
            this.MaxVelTextBox.TabIndex = 15;
            this.MaxVelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxVelTextBox_KeyPress);
            // 
            // MaxAccelTextBox
            // 
            this.MaxAccelTextBox.Location = new System.Drawing.Point(345, 47);
            this.MaxAccelTextBox.Name = "MaxAccelTextBox";
            this.MaxAccelTextBox.Size = new System.Drawing.Size(128, 20);
            this.MaxAccelTextBox.TabIndex = 16;
            this.MaxAccelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxAccelTextBox_KeyPress);
            // 
            // MaxDecelTextBox
            // 
            this.MaxDecelTextBox.Location = new System.Drawing.Point(345, 73);
            this.MaxDecelTextBox.Name = "MaxDecelTextBox";
            this.MaxDecelTextBox.Size = new System.Drawing.Size(128, 20);
            this.MaxDecelTextBox.TabIndex = 17;
            this.MaxDecelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxDecelTextBox_KeyPress);
            // 
            // MaxNegPosTextBox
            // 
            this.MaxNegPosTextBox.Location = new System.Drawing.Point(345, 99);
            this.MaxNegPosTextBox.Name = "MaxNegPosTextBox";
            this.MaxNegPosTextBox.Size = new System.Drawing.Size(128, 20);
            this.MaxNegPosTextBox.TabIndex = 18;
            // 
            // MaxPosPosTextBox
            // 
            this.MaxPosPosTextBox.Location = new System.Drawing.Point(345, 125);
            this.MaxPosPosTextBox.Name = "MaxPosPosTextBox";
            this.MaxPosPosTextBox.Size = new System.Drawing.Size(128, 20);
            this.MaxPosPosTextBox.TabIndex = 19;
            // 
            // NewMotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 248);
            this.Controls.Add(this.MaxPosPosTextBox);
            this.Controls.Add(this.MaxNegPosTextBox);
            this.Controls.Add(this.MaxDecelTextBox);
            this.Controls.Add(this.MaxAccelTextBox);
            this.Controls.Add(this.MaxVelTextBox);
            this.Controls.Add(this.MaxPositivePositionLabel);
            this.Controls.Add(this.MaxNegativePositionLabel);
            this.Controls.Add(this.MaxDecelerationLabel);
            this.Controls.Add(this.MaxAccelerationLabel);
            this.Controls.Add(this.MaxVelocityLabel);
            this.Controls.Add(this.PLCNameLabel);
            this.Controls.Add(this.PLCNameTextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IPAddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Name = "NewMotorForm";
            this.Text = "New Motor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescTextBox;
        private System.Windows.Forms.TextBox PLCNameTextBox;
        private System.Windows.Forms.Label PLCNameLabel;
        private System.Windows.Forms.Label MaxVelocityLabel;
        private System.Windows.Forms.Label MaxAccelerationLabel;
        private System.Windows.Forms.Label MaxDecelerationLabel;
        private System.Windows.Forms.Label MaxNegativePositionLabel;
        private System.Windows.Forms.Label MaxPositivePositionLabel;
        private System.Windows.Forms.TextBox MaxVelTextBox;
        private System.Windows.Forms.TextBox MaxAccelTextBox;
        private System.Windows.Forms.TextBox MaxDecelTextBox;
        private System.Windows.Forms.TextBox MaxNegPosTextBox;
        private System.Windows.Forms.TextBox MaxPosPosTextBox;
    }
}