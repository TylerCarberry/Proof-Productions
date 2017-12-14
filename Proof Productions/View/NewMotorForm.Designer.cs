namespace Proof_Productions.View
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
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(179, 265);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 28);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(312, 265);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(16, 30);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Motor Name";
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Location = new System.Drawing.Point(16, 197);
            this.IPAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(76, 17);
            this.IPAddressLabel.TabIndex = 3;
            this.IPAddressLabel.Text = "IP Address";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(108, 26);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(169, 23);
            this.NameTextBox.TabIndex = 4;
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(108, 193);
            this.IPAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(169, 23);
            this.IPAddressTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(108, 58);
            this.DescTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(169, 128);
            this.DescTextBox.TabIndex = 7;
            this.DescTextBox.Text = "";
            // 
            // PLCNameTextBox
            // 
            this.PLCNameTextBox.Location = new System.Drawing.Point(108, 225);
            this.PLCNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PLCNameTextBox.Name = "PLCNameTextBox";
            this.PLCNameTextBox.Size = new System.Drawing.Size(169, 23);
            this.PLCNameTextBox.TabIndex = 8;
            // 
            // PLCNameLabel
            // 
            this.PLCNameLabel.AutoSize = true;
            this.PLCNameLabel.Location = new System.Drawing.Point(16, 229);
            this.PLCNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PLCNameLabel.Name = "PLCNameLabel";
            this.PLCNameLabel.Size = new System.Drawing.Size(75, 17);
            this.PLCNameLabel.TabIndex = 9;
            this.PLCNameLabel.Text = "PLC Name";
            // 
            // MaxVelocityLabel
            // 
            this.MaxVelocityLabel.AutoSize = true;
            this.MaxVelocityLabel.Location = new System.Drawing.Point(308, 30);
            this.MaxVelocityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxVelocityLabel.Name = "MaxVelocityLabel";
            this.MaxVelocityLabel.Size = new System.Drawing.Size(86, 17);
            this.MaxVelocityLabel.TabIndex = 10;
            this.MaxVelocityLabel.Text = "Max Velocity";
            // 
            // MaxAccelerationLabel
            // 
            this.MaxAccelerationLabel.AutoSize = true;
            this.MaxAccelerationLabel.Location = new System.Drawing.Point(308, 62);
            this.MaxAccelerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxAccelerationLabel.Name = "MaxAccelerationLabel";
            this.MaxAccelerationLabel.Size = new System.Drawing.Size(115, 17);
            this.MaxAccelerationLabel.TabIndex = 11;
            this.MaxAccelerationLabel.Text = "Max Acceleration";
            // 
            // MaxDecelerationLabel
            // 
            this.MaxDecelerationLabel.AutoSize = true;
            this.MaxDecelerationLabel.Location = new System.Drawing.Point(308, 94);
            this.MaxDecelerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxDecelerationLabel.Name = "MaxDecelerationLabel";
            this.MaxDecelerationLabel.Size = new System.Drawing.Size(117, 17);
            this.MaxDecelerationLabel.TabIndex = 12;
            this.MaxDecelerationLabel.Text = "Max Deceleration";
            // 
            // MaxNegativePositionLabel
            // 
            this.MaxNegativePositionLabel.AutoSize = true;
            this.MaxNegativePositionLabel.Location = new System.Drawing.Point(308, 126);
            this.MaxNegativePositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxNegativePositionLabel.Name = "MaxNegativePositionLabel";
            this.MaxNegativePositionLabel.Size = new System.Drawing.Size(147, 17);
            this.MaxNegativePositionLabel.TabIndex = 13;
            this.MaxNegativePositionLabel.Text = "Max Negative Position";
            // 
            // MaxPositivePositionLabel
            // 
            this.MaxPositivePositionLabel.AutoSize = true;
            this.MaxPositivePositionLabel.Location = new System.Drawing.Point(308, 158);
            this.MaxPositivePositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxPositivePositionLabel.Name = "MaxPositivePositionLabel";
            this.MaxPositivePositionLabel.Size = new System.Drawing.Size(140, 17);
            this.MaxPositivePositionLabel.TabIndex = 14;
            this.MaxPositivePositionLabel.Text = "Max Positive Position";
            // 
            // MaxVelTextBox
            // 
            this.MaxVelTextBox.Location = new System.Drawing.Point(460, 26);
            this.MaxVelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxVelTextBox.Name = "MaxVelTextBox";
            this.MaxVelTextBox.Size = new System.Drawing.Size(169, 23);
            this.MaxVelTextBox.TabIndex = 15;
            // 
            // MaxAccelTextBox
            // 
            this.MaxAccelTextBox.Location = new System.Drawing.Point(460, 58);
            this.MaxAccelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxAccelTextBox.Name = "MaxAccelTextBox";
            this.MaxAccelTextBox.Size = new System.Drawing.Size(169, 23);
            this.MaxAccelTextBox.TabIndex = 16;
            // 
            // MaxDecelTextBox
            // 
            this.MaxDecelTextBox.Location = new System.Drawing.Point(460, 90);
            this.MaxDecelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxDecelTextBox.Name = "MaxDecelTextBox";
            this.MaxDecelTextBox.Size = new System.Drawing.Size(169, 23);
            this.MaxDecelTextBox.TabIndex = 17;
            // 
            // MaxNegPosTextBox
            // 
            this.MaxNegPosTextBox.Location = new System.Drawing.Point(460, 122);
            this.MaxNegPosTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxNegPosTextBox.Name = "MaxNegPosTextBox";
            this.MaxNegPosTextBox.Size = new System.Drawing.Size(169, 23);
            this.MaxNegPosTextBox.TabIndex = 18;
            // 
            // MaxPosPosTextBox
            // 
            this.MaxPosPosTextBox.Location = new System.Drawing.Point(460, 154);
            this.MaxPosPosTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxPosPosTextBox.Name = "MaxPosPosTextBox";
            this.MaxPosPosTextBox.Size = new System.Drawing.Size(169, 23);
            this.MaxPosPosTextBox.TabIndex = 19;
            // 
            // NewMotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 305);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(663, 344);
            this.MinimumSize = new System.Drawing.Size(663, 344);
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