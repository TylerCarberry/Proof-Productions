namespace Proof_Productions.View
{
    partial class NewCueForm
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
            this.CueNameLabel = new System.Windows.Forms.Label();
            this.cueNameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CueNameLabel
            // 
            this.CueNameLabel.AutoSize = true;
            this.CueNameLabel.Location = new System.Drawing.Point(25, 51);
            this.CueNameLabel.Name = "CueNameLabel";
            this.CueNameLabel.Size = new System.Drawing.Size(57, 13);
            this.CueNameLabel.TabIndex = 0;
            this.CueNameLabel.Text = "Cue Name";
            // 
            // cueNameTextBox
            // 
            this.cueNameTextBox.Location = new System.Drawing.Point(97, 48);
            this.cueNameTextBox.Name = "cueNameTextBox";
            this.cueNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.cueNameTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(66, 195);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(147, 195);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewCueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cueNameTextBox);
            this.Controls.Add(this.CueNameLabel);
            this.Name = "NewCueForm";
            this.Text = "New Cue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CueNameLabel;
        private System.Windows.Forms.TextBox cueNameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}