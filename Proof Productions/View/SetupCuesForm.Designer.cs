namespace Proof_Productions.View
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
            this.cueDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cueComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newCueButton = new System.Windows.Forms.Button();
            this.deleteCueButton = new System.Windows.Forms.Button();
            this.addCueItemButton = new System.Windows.Forms.Button();
            this.UpdateCueItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cueDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cueDataGridView
            // 
            this.cueDataGridView.AllowUserToAddRows = false;
            this.cueDataGridView.AllowUserToDeleteRows = false;
            this.cueDataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.cueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cueDataGridView.Location = new System.Drawing.Point(12, 76);
            this.cueDataGridView.MultiSelect = false;
            this.cueDataGridView.Name = "cueDataGridView";
            this.cueDataGridView.Size = new System.Drawing.Size(689, 285);
            this.cueDataGridView.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.manualControlToolStripMenuItem,
            this.setupMotorsToolStripMenuItem,
            this.setupCuesToolStripMenuItem,
            this.loggerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mainMenuToolStripMenuItem.Text = "Home";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // manualControlToolStripMenuItem
            // 
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.ManualControlToolStripMenuItem_Click);
            // 
            // setupMotorsToolStripMenuItem
            // 
            this.setupMotorsToolStripMenuItem.Name = "setupMotorsToolStripMenuItem";
            this.setupMotorsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.setupMotorsToolStripMenuItem.Text = "Setup Motors";
            this.setupMotorsToolStripMenuItem.Click += new System.EventHandler(this.SetupMotorsToolStripMenuItem_Click);
            // 
            // setupCuesToolStripMenuItem
            // 
            this.setupCuesToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setupCuesToolStripMenuItem.Name = "setupCuesToolStripMenuItem";
            this.setupCuesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.setupCuesToolStripMenuItem.Text = "Setup Cues";
            // 
            // loggerToolStripMenuItem
            // 
            this.loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            this.loggerToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.loggerToolStripMenuItem.Text = "Logs";
            this.loggerToolStripMenuItem.Click += new System.EventHandler(this.LoggerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // saveCueButton
            // 
            this.saveCueButton.Location = new System.Drawing.Point(238, 37);
            this.saveCueButton.Name = "saveCueButton";
            this.saveCueButton.Size = new System.Drawing.Size(75, 23);
            this.saveCueButton.TabIndex = 18;
            this.saveCueButton.Text = "Save";
            this.saveCueButton.UseVisualStyleBackColor = true;
            this.saveCueButton.Click += new System.EventHandler(this.SaveCueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Select Cue:";
            // 
            // cueComboBox
            // 
            this.cueComboBox.FormattingEnabled = true;
            this.cueComboBox.Location = new System.Drawing.Point(80, 34);
            this.cueComboBox.Name = "cueComboBox";
            this.cueComboBox.Size = new System.Drawing.Size(121, 21);
            this.cueComboBox.TabIndex = 20;
            this.cueComboBox.SelectedIndexChanged += new System.EventHandler(this.cueComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete cue item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteCueItemButton_Click);
            // 
            // newCueButton
            // 
            this.newCueButton.Location = new System.Drawing.Point(330, 37);
            this.newCueButton.Name = "newCueButton";
            this.newCueButton.Size = new System.Drawing.Size(83, 23);
            this.newCueButton.TabIndex = 22;
            this.newCueButton.Text = "Add New Cue";
            this.newCueButton.UseVisualStyleBackColor = true;
            this.newCueButton.Click += new System.EventHandler(this.newCueButton_Click);
            // 
            // deleteCueButton
            // 
            this.deleteCueButton.Location = new System.Drawing.Point(428, 37);
            this.deleteCueButton.Name = "deleteCueButton";
            this.deleteCueButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCueButton.TabIndex = 23;
            this.deleteCueButton.Text = "Delete Cue";
            this.deleteCueButton.UseVisualStyleBackColor = true;
            this.deleteCueButton.Click += new System.EventHandler(this.deleteCueButton_Click);
            // 
            // addCueItemButton
            // 
            this.addCueItemButton.Location = new System.Drawing.Point(12, 376);
            this.addCueItemButton.Name = "addCueItemButton";
            this.addCueItemButton.Size = new System.Drawing.Size(122, 23);
            this.addCueItemButton.TabIndex = 24;
            this.addCueItemButton.Text = "Add New Cue Item";
            this.addCueItemButton.UseVisualStyleBackColor = true;
            this.addCueItemButton.Click += new System.EventHandler(this.addCueItemButton_Click);
            // 
            // UpdateCueItemButton
            // 
            this.UpdateCueItemButton.Location = new System.Drawing.Point(157, 376);
            this.UpdateCueItemButton.Name = "UpdateCueItemButton";
            this.UpdateCueItemButton.Size = new System.Drawing.Size(105, 23);
            this.UpdateCueItemButton.TabIndex = 25;
            this.UpdateCueItemButton.Text = "Update Cue Item";
            this.UpdateCueItemButton.UseVisualStyleBackColor = true;
            this.UpdateCueItemButton.Click += new System.EventHandler(this.UpdateCueItemButton_Click);
            // 
            // SetupCueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 423);
            this.Controls.Add(this.UpdateCueItemButton);
            this.Controls.Add(this.addCueItemButton);
            this.Controls.Add(this.deleteCueButton);
            this.Controls.Add(this.newCueButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cueComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveCueButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cueDataGridView);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "SetupCueForm";
            this.Text = "Setup Cues";
            ((System.ComponentModel.ISupportInitialize)(this.cueDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView cueDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupMotorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button saveCueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cueComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newCueButton;
        private System.Windows.Forms.Button deleteCueButton;
        private System.Windows.Forms.Button addCueItemButton;
        private System.Windows.Forms.Button UpdateCueItemButton;
    }
}