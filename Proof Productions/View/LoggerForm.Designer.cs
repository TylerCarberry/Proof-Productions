namespace Proof_Productions.View
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
            this.displayErrorButton = new System.Windows.Forms.Button();
            this.displayLogButton = new System.Windows.Forms.Button();
            this.logLocationButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logGridView
            // 
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time,
            this.entry});
            this.logGridView.Location = new System.Drawing.Point(12, 63);
            this.logGridView.Name = "logGridView";
            this.logGridView.Size = new System.Drawing.Size(670, 300);
            this.logGridView.TabIndex = 0;
            this.logGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.logGridView_CellContentClick);
            // 
            // displayErrorButton
            // 
            this.displayErrorButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayErrorButton.Enabled = false;
            this.displayErrorButton.Location = new System.Drawing.Point(89, 16);
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
            this.displayLogButton.Enabled = false;
            this.displayLogButton.Location = new System.Drawing.Point(180, 16);
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
            this.logLocationButton.Location = new System.Drawing.Point(271, 16);
            this.logLocationButton.Name = "logLocationButton";
            this.logLocationButton.Size = new System.Drawing.Size(75, 41);
            this.logLocationButton.TabIndex = 3;
            this.logLocationButton.Text = "Log File Location";
            this.logLocationButton.UseVisualStyleBackColor = false;
            this.logLocationButton.Click += new System.EventHandler(this.logLocationButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Enabled = false;
            this.searchBox.Location = new System.Drawing.Point(397, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(131, 20);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(394, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search";
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
            this.entry.MinimumWidth = 500;
            this.entry.Name = "entry";
            this.entry.ReadOnly = true;
            this.entry.Width = 500;
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 375);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.logLocationButton);
            this.Controls.Add(this.displayLogButton);
            this.Controls.Add(this.displayErrorButton);
            this.Controls.Add(this.logGridView);
            this.Name = "LoggerForm";
            this.Text = "Proof Productions: Logs";
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Log Entry SpreadSheet
        private System.Windows.Forms.DataGridView logGridView;

        //Buttons and remaining components
        private System.Windows.Forms.Button displayErrorButton;
        private System.Windows.Forms.Button displayLogButton;
        private System.Windows.Forms.Button logLocationButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;
    }
}