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
            this.CancelCreationButton = new System.Windows.Forms.Button();
            this.CueDescBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CueNameLabel
            // 
            this.CueNameLabel.AutoSize = true;
            this.CueNameLabel.Location = new System.Drawing.Point(23, 31);
            this.CueNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CueNameLabel.Name = "CueNameLabel";
            this.CueNameLabel.Size = new System.Drawing.Size(74, 17);
            this.CueNameLabel.TabIndex = 0;
            this.CueNameLabel.Text = "Cue Name";
            // 
            // cueNameTextBox
            // 
            this.cueNameTextBox.Location = new System.Drawing.Point(140, 27);
            this.cueNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cueNameTextBox.Name = "cueNameTextBox";
            this.cueNameTextBox.Size = new System.Drawing.Size(155, 23);
            this.cueNameTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(88, 258);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 28);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelCreationButton
            // 
            this.CancelCreationButton.Location = new System.Drawing.Point(196, 258);
            this.CancelCreationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelCreationButton.Name = "CancelCreationButton";
            this.CancelCreationButton.Size = new System.Drawing.Size(100, 28);
            this.CancelCreationButton.TabIndex = 3;
            this.CancelCreationButton.Text = "Cancel";
            this.CancelCreationButton.UseVisualStyleBackColor = true;
            this.CancelCreationButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CueDescBox
            // 
            this.CueDescBox.Location = new System.Drawing.Point(140, 68);
            this.CueDescBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CueDescBox.Name = "CueDescBox";
            this.CueDescBox.Size = new System.Drawing.Size(245, 164);
            this.CueDescBox.TabIndex = 4;
            this.CueDescBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cue Description";
            // 
            // NewCueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CueDescBox);
            this.Controls.Add(this.CancelCreationButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cueNameTextBox);
            this.Controls.Add(this.CueNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(429, 360);
            this.MinimumSize = new System.Drawing.Size(429, 360);
            this.Name = "NewCueForm";
            this.Text = "New Cue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CueNameLabel;
        private System.Windows.Forms.TextBox cueNameTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button CancelCreationButton;
        private System.Windows.Forms.RichTextBox CueDescBox;
        private System.Windows.Forms.Label label1;
    }
}