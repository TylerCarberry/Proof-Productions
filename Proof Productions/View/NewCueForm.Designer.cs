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
            this.CueNameLabel.Location = new System.Drawing.Point(33, 63);
            this.CueNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CueNameLabel.Name = "CueNameLabel";
            this.CueNameLabel.Size = new System.Drawing.Size(74, 17);
            this.CueNameLabel.TabIndex = 0;
            this.CueNameLabel.Text = "Cue Name";
            // 
            // cueNameTextBox
            // 
            this.cueNameTextBox.Location = new System.Drawing.Point(129, 59);
            this.cueNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cueNameTextBox.Name = "cueNameTextBox";
            this.cueNameTextBox.Size = new System.Drawing.Size(165, 23);
            this.cueNameTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(92, 144);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(217, 144);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewCueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cueNameTextBox);
            this.Controls.Add(this.CueNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(429, 300);
            this.MinimumSize = new System.Drawing.Size(429, 300);
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