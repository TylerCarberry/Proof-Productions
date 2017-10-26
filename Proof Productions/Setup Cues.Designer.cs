namespace Proof_Productions
{
    partial class SetupCueForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.accelComboBox = new System.Windows.Forms.ComboBox();
            this.accelLabel = new System.Windows.Forms.Label();
            this.spdLabel = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.spdComboBox = new System.Windows.Forms.ComboBox();
            this.dirComboBox = new System.Windows.Forms.ComboBox();
            this.detailedViewLabel = new System.Windows.Forms.Label();
            this.detailedViewTextBox = new System.Windows.Forms.RichTextBox();
            this.cueSelectionLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.motorDataGridView = new System.Windows.Forms.DataGridView();
            this.motorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorAccel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertRowButton = new System.Windows.Forms.Button();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accelComboBox);
            this.panel1.Controls.Add(this.accelLabel);
            this.panel1.Controls.Add(this.spdLabel);
            this.panel1.Controls.Add(this.dirLabel);
            this.panel1.Controls.Add(this.spdComboBox);
            this.panel1.Controls.Add(this.dirComboBox);
            this.panel1.Controls.Add(this.detailedViewLabel);
            this.panel1.Controls.Add(this.detailedViewTextBox);
            this.panel1.Controls.Add(this.cueSelectionLabel);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 371);
            this.panel1.TabIndex = 0;
            // 
            // accelComboBox
            // 
            this.accelComboBox.FormattingEnabled = true;
            this.accelComboBox.Location = new System.Drawing.Point(15, 263);
            this.accelComboBox.Name = "accelComboBox";
            this.accelComboBox.Size = new System.Drawing.Size(121, 21);
            this.accelComboBox.TabIndex = 8;
            this.accelComboBox.SelectedIndexChanged += new System.EventHandler(this.accelComboBox_SelectedIndexChanged);
            // 
            // accelLabel
            // 
            this.accelLabel.AutoSize = true;
            this.accelLabel.Location = new System.Drawing.Point(13, 247);
            this.accelLabel.Name = "accelLabel";
            this.accelLabel.Size = new System.Drawing.Size(66, 13);
            this.accelLabel.TabIndex = 7;
            this.accelLabel.Text = "Acceleration";
            // 
            // spdLabel
            // 
            this.spdLabel.AutoSize = true;
            this.spdLabel.Location = new System.Drawing.Point(13, 207);
            this.spdLabel.Name = "spdLabel";
            this.spdLabel.Size = new System.Drawing.Size(38, 13);
            this.spdLabel.TabIndex = 6;
            this.spdLabel.Text = "Speed";
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Location = new System.Drawing.Point(13, 167);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(49, 13);
            this.dirLabel.TabIndex = 5;
            this.dirLabel.Text = "Direction";
            // 
            // spdComboBox
            // 
            this.spdComboBox.FormattingEnabled = true;
            this.spdComboBox.Location = new System.Drawing.Point(15, 223);
            this.spdComboBox.Name = "spdComboBox";
            this.spdComboBox.Size = new System.Drawing.Size(121, 21);
            this.spdComboBox.TabIndex = 4;
            this.spdComboBox.SelectedIndexChanged += new System.EventHandler(this.spdComboBox_SelectedIndexChanged);
            // 
            // dirComboBox
            // 
            this.dirComboBox.FormattingEnabled = true;
            this.dirComboBox.Location = new System.Drawing.Point(15, 183);
            this.dirComboBox.Name = "dirComboBox";
            this.dirComboBox.Size = new System.Drawing.Size(121, 21);
            this.dirComboBox.TabIndex = 3;
            this.dirComboBox.SelectedIndexChanged += new System.EventHandler(this.dirComboBox_SelectedIndexChanged);
            // 
            // detailedViewLabel
            // 
            this.detailedViewLabel.AutoSize = true;
            this.detailedViewLabel.Location = new System.Drawing.Point(13, 52);
            this.detailedViewLabel.Name = "detailedViewLabel";
            this.detailedViewLabel.Size = new System.Drawing.Size(72, 13);
            this.detailedViewLabel.TabIndex = 2;
            this.detailedViewLabel.Text = "Detailed View";
            // 
            // detailedViewTextBox
            // 
            this.detailedViewTextBox.Location = new System.Drawing.Point(15, 68);
            this.detailedViewTextBox.Name = "detailedViewTextBox";
            this.detailedViewTextBox.Size = new System.Drawing.Size(121, 96);
            this.detailedViewTextBox.TabIndex = 1;
            this.detailedViewTextBox.Text = "";
            this.detailedViewTextBox.TextChanged += new System.EventHandler(this.detailedViewTextBox_TextChanged);
            // 
            // cueSelectionLabel
            // 
            this.cueSelectionLabel.AutoSize = true;
            this.cueSelectionLabel.Location = new System.Drawing.Point(12, 12);
            this.cueSelectionLabel.Name = "cueSelectionLabel";
            this.cueSelectionLabel.Size = new System.Drawing.Size(73, 13);
            this.cueSelectionLabel.TabIndex = 1;
            this.cueSelectionLabel.Text = "Cue Selection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // motorDataGridView
            // 
            this.motorDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.motorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.motorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.motorName,
            this.motorType,
            this.motorDirection,
            this.motorSpeed,
            this.motorAccel});
            this.motorDataGridView.Location = new System.Drawing.Point(213, 12);
            this.motorDataGridView.MultiSelect = false;
            this.motorDataGridView.Name = "motorDataGridView";
            this.motorDataGridView.Size = new System.Drawing.Size(393, 371);
            this.motorDataGridView.TabIndex = 9;
            this.motorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // motorName
            // 
            this.motorName.HeaderText = "Motor";
            this.motorName.Name = "motorName";
            // 
            // motorType
            // 
            this.motorType.HeaderText = "Motor Type";
            this.motorType.Name = "motorType";
            // 
            // motorDirection
            // 
            this.motorDirection.HeaderText = "Direction";
            this.motorDirection.Name = "motorDirection";
            // 
            // motorSpeed
            // 
            this.motorSpeed.HeaderText = "Speed";
            this.motorSpeed.Name = "motorSpeed";
            // 
            // motorAccel
            // 
            this.motorAccel.HeaderText = "Acceleration";
            this.motorAccel.Name = "motorAccel";
            // 
            // insertRowButton
            // 
            this.insertRowButton.BackColor = System.Drawing.SystemColors.Window;
            this.insertRowButton.Location = new System.Drawing.Point(624, 38);
            this.insertRowButton.Name = "insertRowButton";
            this.insertRowButton.Size = new System.Drawing.Size(84, 23);
            this.insertRowButton.TabIndex = 10;
            this.insertRowButton.Text = "Insert Row";
            this.insertRowButton.UseVisualStyleBackColor = false;
            this.insertRowButton.Click += new System.EventHandler(this.insertRowButton_Click);
            // 
            // removeRowButton
            // 
            this.removeRowButton.BackColor = System.Drawing.SystemColors.Window;
            this.removeRowButton.Location = new System.Drawing.Point(624, 67);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(84, 23);
            this.removeRowButton.TabIndex = 11;
            this.removeRowButton.Text = "Remove Row";
            this.removeRowButton.UseVisualStyleBackColor = false;
            this.removeRowButton.Click += new System.EventHandler(this.removeRowButton_Click);
            // 
            // SetupCueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 405);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.insertRowButton);
            this.Controls.Add(this.motorDataGridView);
            this.Controls.Add(this.panel1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "SetupCueForm";
            this.Text = "Setup Cues";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cueSelectionLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox accelComboBox;
        private System.Windows.Forms.Label accelLabel;
        private System.Windows.Forms.Label spdLabel;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.ComboBox spdComboBox;
        private System.Windows.Forms.ComboBox dirComboBox;
        private System.Windows.Forms.Label detailedViewLabel;
        private System.Windows.Forms.RichTextBox detailedViewTextBox;
        private System.Windows.Forms.DataGridView motorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorAccel;
        private System.Windows.Forms.Button insertRowButton;
        private System.Windows.Forms.Button removeRowButton;
    }
}