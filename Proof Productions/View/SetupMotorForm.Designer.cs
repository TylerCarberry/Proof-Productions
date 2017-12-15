namespace Proof_Productions.View
{
    partial class SetupMotorForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MotorLabel = new System.Windows.Forms.Label();
            this.UpdateMotorButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UpdateMotorButton = new System.Windows.Forms.Button();
            this.MotorLabel = new System.Windows.Forms.Label();
            this.UpdateAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MotorLabel
            //
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 73);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(825, 264);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            // 
            // UpdateMotorButton
            // 
            this.removeMotorButton.Location = new System.Drawing.Point(348, 358);
            this.removeMotorButton.Name = "removeMotorButton";
            this.removeMotorButton.Size = new System.Drawing.Size(91, 23);
            this.removeMotorButton.TabIndex = 13;
            this.removeMotorButton.Text = "Remove Motor";
            this.removeMotorButton.UseVisualStyleBackColor = true;
            this.removeMotorButton.Click += new System.EventHandler(this.RemoveMotorButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.manualControlToolStripMenuItem,
            this.setupMotorsToolStripMenuItem,
            this.setupCuesToolStripMenuItem,
            this.loggerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip1";
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
            this.manualControlToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.ManualControlToolStripMenuItem_Click);
            // 
            // setupMotorsToolStripMenuItem
            // 
            this.setupMotorsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setupMotorsToolStripMenuItem.Name = "setupMotorsToolStripMenuItem";
            this.setupMotorsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.setupMotorsToolStripMenuItem.Text = "Setup Motors";
            // 
            // setupCuesToolStripMenuItem
            // 
            this.setupCuesToolStripMenuItem.Name = "setupCuesToolStripMenuItem";
            this.setupCuesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.setupCuesToolStripMenuItem.Text = "Setup Cues";
            this.setupCuesToolStripMenuItem.Click += new System.EventHandler(this.SetupCuesToolStripMenuItem_Click);
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
            // removeMotorButton
            //
            this.UpdateMotorButton.Location = new System.Drawing.Point(118, 358);
            this.UpdateMotorButton.Name = "UpdateMotorButton";
            this.UpdateMotorButton.Size = new System.Drawing.Size(82, 23);
            this.UpdateMotorButton.TabIndex = 19;
            this.UpdateMotorButton.Text = "Update Motor";
            this.UpdateMotorButton.UseVisualStyleBackColor = true;
            this.UpdateMotorButton.Click += new System.EventHandler(this.UpdateMotorButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(34, 65);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MinimumSize = new System.Drawing.Size(1101, 303);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1101, 340);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentChanged);
            // 
            // AddMotorButton
            // 
            this.AddMotorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddMotorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMotorButton.Location = new System.Drawing.Point(35, 435);
            this.AddMotorButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMotorButton.Name = "AddMotorButton";
            this.AddMotorButton.Size = new System.Drawing.Size(117, 34);
            this.AddMotorButton.TabIndex = 12;
            this.AddMotorButton.Text = "Add Motor";
            this.AddMotorButton.UseVisualStyleBackColor = true;
            this.AddMotorButton.Click += new System.EventHandler(this.AddMotorButton_Click);
            // 
            // UpdateAllButton
            // 
            this.UpdateAllButton.Location = new System.Drawing.Point(216, 358);
            this.UpdateAllButton.Name = "UpdateAllButton";
            this.UpdateAllButton.Size = new System.Drawing.Size(114, 23);
            this.UpdateAllButton.TabIndex = 21;
            this.UpdateAllButton.Text = "Update All Motors";
            this.UpdateAllButton.UseVisualStyleBackColor = true;
            this.UpdateAllButton.Click += new System.EventHandler(this.UpdateAllButton_Click);
            // 
            // SetupMotorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 393);
            this.Controls.Add(this.UpdateAllButton);
            this.Controls.Add(this.MotorLabel);
            this.Controls.Add(this.UpdateMotorButton);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.removeMotorButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AddMotorButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1181, 523);
            this.Name = "SetupMotorForm";
            this.Text = "Proof Productions: Setup Motors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupMotorForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddMotorButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button removeMotorButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupMotorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button UpdateMotorButton;
        private System.Windows.Forms.Label MotorLabel;
        private System.Windows.Forms.Button UpdateAllButton;
    }
}