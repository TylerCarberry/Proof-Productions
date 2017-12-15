namespace Proof_Productions.View
{
    partial class NewCueItemForm
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
            this.CueItemNumber = new System.Windows.Forms.Label();
            this.StartDelayLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.AccelLabel = new System.Windows.Forms.Label();
            this.DecelLabel = new System.Windows.Forms.Label();
            this.MotorLabel = new System.Windows.Forms.Label();
            this.CueLabel = new System.Windows.Forms.Label();
            this.CueItemNumberTextBox = new System.Windows.Forms.TextBox();
            this.DelayTextbox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.VelocityTextBox = new System.Windows.Forms.TextBox();
            this.AccelTextBox = new System.Windows.Forms.TextBox();
            this.DecelTextBox = new System.Windows.Forms.TextBox();
            this.CueTextBox = new System.Windows.Forms.TextBox();
            this.MotorTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CCWRadioButton = new System.Windows.Forms.RadioButton();
            this.CWRadioButton = new System.Windows.Forms.RadioButton();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CueItemNameTextBox = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CueItemNumber
            // 
            this.CueItemNumber.AutoSize = true;
            this.CueItemNumber.Location = new System.Drawing.Point(22, 68);
            this.CueItemNumber.Name = "CueItemNumber";
            this.CueItemNumber.Size = new System.Drawing.Size(89, 13);
            this.CueItemNumber.TabIndex = 0;
            this.CueItemNumber.Text = "Cue Item Number";
            // 
            // StartDelayLabel
            // 
            this.StartDelayLabel.AutoSize = true;
            this.StartDelayLabel.Location = new System.Drawing.Point(22, 95);
            this.StartDelayLabel.Name = "StartDelayLabel";
            this.StartDelayLabel.Size = new System.Drawing.Size(59, 13);
            this.StartDelayLabel.TabIndex = 1;
            this.StartDelayLabel.Text = "Start Delay";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(22, 121);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(47, 13);
            this.DurationLabel.TabIndex = 2;
            this.DurationLabel.Text = "Duration";
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.Location = new System.Drawing.Point(257, 42);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Size = new System.Drawing.Size(44, 13);
            this.VelocityLabel.TabIndex = 3;
            this.VelocityLabel.Text = "Velocity";
            // 
            // AccelLabel
            // 
            this.AccelLabel.AutoSize = true;
            this.AccelLabel.Location = new System.Drawing.Point(257, 68);
            this.AccelLabel.Name = "AccelLabel";
            this.AccelLabel.Size = new System.Drawing.Size(66, 13);
            this.AccelLabel.TabIndex = 4;
            this.AccelLabel.Text = "Acceleration";
            // 
            // DecelLabel
            // 
            this.DecelLabel.AutoSize = true;
            this.DecelLabel.Location = new System.Drawing.Point(258, 95);
            this.DecelLabel.Name = "DecelLabel";
            this.DecelLabel.Size = new System.Drawing.Size(67, 13);
            this.DecelLabel.TabIndex = 5;
            this.DecelLabel.Text = "Deceleration";
            // 
            // MotorLabel
            // 
            this.MotorLabel.AutoSize = true;
            this.MotorLabel.Location = new System.Drawing.Point(453, 68);
            this.MotorLabel.Name = "MotorLabel";
            this.MotorLabel.Size = new System.Drawing.Size(65, 13);
            this.MotorLabel.TabIndex = 9;
            this.MotorLabel.Text = "Motor Name";
            // 
            // CueLabel
            // 
            this.CueLabel.AutoSize = true;
            this.CueLabel.Location = new System.Drawing.Point(453, 42);
            this.CueLabel.Name = "CueLabel";
            this.CueLabel.Size = new System.Drawing.Size(57, 13);
            this.CueLabel.TabIndex = 10;
            this.CueLabel.Text = "Cue Name";
            // 
            // CueItemNumberTextBox
            // 
            this.CueItemNumberTextBox.Location = new System.Drawing.Point(117, 65);
            this.CueItemNumberTextBox.Name = "CueItemNumberTextBox";
            this.CueItemNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.CueItemNumberTextBox.TabIndex = 11;
            this.CueItemNumberTextBox.TextChanged += new System.EventHandler(this.CueItemNumberTextBox_TextChanged);
            this.CueItemNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            // 
            // DelayTextbox
            // 
            this.DelayTextbox.Location = new System.Drawing.Point(117, 92);
            this.DelayTextbox.Name = "DelayTextbox";
            this.DelayTextbox.Size = new System.Drawing.Size(100, 20);
            this.DelayTextbox.TabIndex = 12;
            this.DelayTextbox.TextChanged += new System.EventHandler(this.DelayTextbox_TextChanged);
            this.DelayTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(117, 118);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationTextBox.TabIndex = 13;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            this.DurationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            // 
            // VelocityTextBox
            // 
            this.VelocityTextBox.Location = new System.Drawing.Point(329, 39);
            this.VelocityTextBox.Name = "VelocityTextBox";
            this.VelocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.VelocityTextBox.TabIndex = 14;
            this.VelocityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            // 
            // AccelTextBox
            // 
            this.AccelTextBox.Location = new System.Drawing.Point(329, 65);
            this.AccelTextBox.Name = "AccelTextBox";
            this.AccelTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccelTextBox.TabIndex = 15;
            this.AccelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            // 
            // DecelTextBox
            // 
            this.DecelTextBox.Location = new System.Drawing.Point(329, 92);
            this.DecelTextBox.Name = "DecelTextBox";
            this.DecelTextBox.Size = new System.Drawing.Size(100, 20);
            this.DecelTextBox.TabIndex = 16;
            this.DecelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);
            // 
            // CueTextBox
            // 
            this.CueTextBox.Location = new System.Drawing.Point(524, 39);
            this.CueTextBox.Name = "CueTextBox";
            this.CueTextBox.Size = new System.Drawing.Size(100, 20);
            this.CueTextBox.TabIndex = 20;
            // 
            // MotorTextBox
            // 
            this.MotorTextBox.Location = new System.Drawing.Point(524, 65);
            this.MotorTextBox.Name = "MotorTextBox";
            this.MotorTextBox.Size = new System.Drawing.Size(100, 20);
            this.MotorTextBox.TabIndex = 21;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(354, 228);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CCWRadioButton);
            this.panel1.Controls.Add(this.CWRadioButton);
            this.panel1.Location = new System.Drawing.Point(479, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 26;
            // 
            // CCWRadioButton
            // 
            this.CCWRadioButton.AutoSize = true;
            this.CCWRadioButton.Location = new System.Drawing.Point(3, 26);
            this.CCWRadioButton.Name = "CCWRadioButton";
            this.CCWRadioButton.Size = new System.Drawing.Size(113, 17);
            this.CCWRadioButton.TabIndex = 26;
            this.CCWRadioButton.Text = "Counter Clockwise";
            this.CCWRadioButton.UseVisualStyleBackColor = true;
            // 
            // CWRadioButton
            // 
            this.CWRadioButton.AutoSize = true;
            this.CWRadioButton.Checked = true;
            this.CWRadioButton.Location = new System.Drawing.Point(3, 3);
            this.CWRadioButton.Name = "CWRadioButton";
            this.CWRadioButton.Size = new System.Drawing.Size(73, 17);
            this.CWRadioButton.TabIndex = 26;
            this.CWRadioButton.TabStop = true;
            this.CWRadioButton.Text = "Clockwise";
            this.CWRadioButton.UseVisualStyleBackColor = true;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(258, 121);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 25;
            this.PositionLabel.Text = "Position";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(329, 118);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.PositionTextBox.TabIndex = 17;
            this.PositionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnlyTextBox_KeyPress);

            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(248, 228);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 24;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CueItemNameTextBox
            // 
            this.CueItemNameTextBox.AutoSize = true;
            this.CueItemNameTextBox.Location = new System.Drawing.Point(22, 42);
            this.CueItemNameTextBox.Name = "CueItemNameTextBox";
            this.CueItemNameTextBox.Size = new System.Drawing.Size(80, 13);
            this.CueItemNameTextBox.TabIndex = 28;
            this.CueItemNameTextBox.Text = "Cue Item Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(117, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // NewCueItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 277);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CueItemNameTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MotorTextBox);
            this.Controls.Add(this.CueTextBox);
            this.Controls.Add(this.DecelTextBox);
            this.Controls.Add(this.AccelTextBox);
            this.Controls.Add(this.VelocityTextBox);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.DelayTextbox);
            this.Controls.Add(this.CueItemNumberTextBox);
            this.Controls.Add(this.CueLabel);
            this.Controls.Add(this.MotorLabel);
            this.Controls.Add(this.DecelLabel);
            this.Controls.Add(this.AccelLabel);
            this.Controls.Add(this.VelocityLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.StartDelayLabel);
            this.Controls.Add(this.CueItemNumber);
            this.Name = "NewCueItemForm";
            this.Text = "NewCueItemForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CueItemNumber;
        private System.Windows.Forms.Label StartDelayLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Label AccelLabel;
        private System.Windows.Forms.Label DecelLabel;
        private System.Windows.Forms.Label MotorLabel;
        private System.Windows.Forms.Label CueLabel;
        private System.Windows.Forms.TextBox CueItemNumberTextBox;
        private System.Windows.Forms.TextBox DelayTextbox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox VelocityTextBox;
        private System.Windows.Forms.TextBox AccelTextBox;
        private System.Windows.Forms.TextBox DecelTextBox;
        private System.Windows.Forms.TextBox CueTextBox;
        private System.Windows.Forms.TextBox MotorTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton CCWRadioButton;
        private System.Windows.Forms.RadioButton CWRadioButton;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label CueItemNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}
