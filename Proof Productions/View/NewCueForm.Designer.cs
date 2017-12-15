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
            this.CueDescBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CueNameLabel
            // 
            this.CueNameLabel.AutoSize = true;
            this.CueNameLabel.Location = new System.Drawing.Point(17, 25);
            this.CueNameLabel.Name = "CueNameLabel";
            this.CueNameLabel.Size = new System.Drawing.Size(57, 13);
            this.CueNameLabel.TabIndex = 0;
            this.CueNameLabel.Text = "Cue Name";
            // 
            // cueNameTextBox
            // 
            this.cueNameTextBox.Location = new System.Drawing.Point(105, 22);
            this.cueNameTextBox.Name = "cueNameTextBox";
            this.cueNameTextBox.Size = new System.Drawing.Size(117, 20);
            this.cueNameTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(66, 210);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(147, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CueDescBox
            // 
            this.CueDescBox.Location = new System.Drawing.Point(105, 55);
            this.CueDescBox.Name = "CueDescBox";
            this.CueDescBox.Size = new System.Drawing.Size(185, 134);
            this.CueDescBox.TabIndex = 4;
            this.CueDescBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cue Description";
            // 
            // NewCueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CueDescBox);
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
        private System.Windows.Forms.RichTextBox CueDescBox;
        private System.Windows.Forms.Label label1;
    }
}