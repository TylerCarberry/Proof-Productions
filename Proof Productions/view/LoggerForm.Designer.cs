namespace Proof_Productions
{
    partial class LoggerForm
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
            this.logGridView = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayErrorButton = new System.Windows.Forms.Button();
            this.displayLogButton = new System.Windows.Forms.Button();
            this.logLocationButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logGridView
            // 
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time,
            this.entry});
            this.logGridView.Location = new System.Drawing.Point(60, 82);
            this.logGridView.Name = "logGridView";
            this.logGridView.Size = new System.Drawing.Size(464, 271);
            this.logGridView.TabIndex = 0;
            this.logGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logGridView_CellContentClick);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // entry
            // 
            this.entry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.entry.HeaderText = "Log Entry";
            this.entry.MinimumWidth = 300;
            this.entry.Name = "entry";
            this.entry.ReadOnly = true;
            this.entry.Width = 300;
            // 
            // displayErrorButton
            // 
            this.displayErrorButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayErrorButton.Location = new System.Drawing.Point(85, 35);
            this.displayErrorButton.Name = "displayErrorButton";
            this.displayErrorButton.Size = new System.Drawing.Size(75, 41);
            this.displayErrorButton.TabIndex = 1;
            this.displayErrorButton.Text = "Display Only Error Logs";
            this.displayErrorButton.UseVisualStyleBackColor = false;
            this.displayErrorButton.Click += new System.EventHandler(this.displayErrorButton_Click);
            // 
            // displayLogButton
            // 
            this.displayLogButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayLogButton.Location = new System.Drawing.Point(176, 35);
            this.displayLogButton.Name = "displayLogButton";
            this.displayLogButton.Size = new System.Drawing.Size(75, 41);
            this.displayLogButton.TabIndex = 2;
            this.displayLogButton.Text = "Display All Logs";
            this.displayLogButton.UseVisualStyleBackColor = false;
            this.displayLogButton.Click += new System.EventHandler(this.displayLogButton_Click);
            // 
            // logLocationButton
            // 
            this.logLocationButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logLocationButton.Location = new System.Drawing.Point(267, 35);
            this.logLocationButton.Name = "logLocationButton";
            this.logLocationButton.Size = new System.Drawing.Size(75, 41);
            this.logLocationButton.TabIndex = 3;
            this.logLocationButton.Text = "Log File Location";
            this.logLocationButton.UseVisualStyleBackColor = false;
            this.logLocationButton.Click += new System.EventHandler(this.logLocationButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(393, 51);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(131, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(390, 35);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.manualControlToolStripMenuItem,
            this.setupMotorToolStripMenuItem,
            this.setupCuesToolStripMenuItem,
            this.loggerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mainMenuToolStripMenuItem.Text = "Home";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // manualControlToolStripMenuItem
            // 
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.manualControlToolStripMenuItem_Click);
            // 
            // setupMotorToolStripMenuItem
            // 
            this.setupMotorToolStripMenuItem.Name = "setupMotorToolStripMenuItem";
            this.setupMotorToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.setupMotorToolStripMenuItem.Text = "Setup Motors";
            this.setupMotorToolStripMenuItem.Click += new System.EventHandler(this.setupMotorsToolStripMenuItem_Click);
            // 
            // setupCuesToolStripMenuItem
            // 
            this.setupCuesToolStripMenuItem.Name = "setupCuesToolStripMenuItem";
            this.setupCuesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.setupCuesToolStripMenuItem.Text = "Setup Cues";
            this.setupCuesToolStripMenuItem.Click += new System.EventHandler(this.setupCuesToolStripMenuItem_Click);
            // 
            // loggerToolStripMenuItem
            // 
            this.loggerToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loggerToolStripMenuItem.Name = "loggerToolStripMenuItem";
            this.loggerToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.loggerToolStripMenuItem.Text = "Logs";
            this.loggerToolStripMenuItem.Click += new System.EventHandler(this.loggerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 375);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.logLocationButton);
            this.Controls.Add(this.displayLogButton);
            this.Controls.Add(this.displayErrorButton);
            this.Controls.Add(this.logGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "LoggerForm";
            this.Text = "Logger";
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Log Entry SpreadSheet
        private System.Windows.Forms.DataGridView logGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;

        //Menu options
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupMotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        //Buttons and remaining components
        private System.Windows.Forms.Button displayErrorButton;
        private System.Windows.Forms.Button displayLogButton;
        private System.Windows.Forms.Button logLocationButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
    }
}