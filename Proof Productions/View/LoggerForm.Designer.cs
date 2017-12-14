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
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshLogsButton = new System.Windows.Forms.Button();
            this.logLocationButton = new System.Windows.Forms.Button();
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
            // refreshLogsButton
            // 
            this.refreshLogsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshLogsButton.Location = new System.Drawing.Point(30, 11);
            this.refreshLogsButton.Name = "refreshLogsButton";
            this.refreshLogsButton.Size = new System.Drawing.Size(75, 41);
            this.refreshLogsButton.TabIndex = 1;
            this.refreshLogsButton.Text = "Refresh";
            this.refreshLogsButton.UseVisualStyleBackColor = false;
            this.refreshLogsButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // logLocationButton
            // 
            this.logLocationButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logLocationButton.Location = new System.Drawing.Point(123, 11);
            this.logLocationButton.Name = "logLocationButton";
            this.logLocationButton.Size = new System.Drawing.Size(75, 41);
            this.logLocationButton.TabIndex = 3;
            this.logLocationButton.Text = "Log File Location";
            this.logLocationButton.UseVisualStyleBackColor = false;
            this.logLocationButton.Click += new System.EventHandler(this.logLocationButton_Click);
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 375);
            this.Controls.Add(this.logLocationButton);
            this.Controls.Add(this.refreshLogsButton);
            this.Controls.Add(this.logGridView);
            this.Name = "LoggerForm";
            this.Text = "Proof Productions: Logs";
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //Log Entry SpreadSheet
        private System.Windows.Forms.DataGridView logGridView;

        //Buttons and remaining components
        private System.Windows.Forms.Button refreshLogsButton;
        private System.Windows.Forms.Button logLocationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;
    }
}