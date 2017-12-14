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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logGridView
            // 
            this.logGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time,
            this.entry});
            this.logGridView.Location = new System.Drawing.Point(16, 78);
            this.logGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logGridView.Name = "logGridView";
            this.logGridView.Size = new System.Drawing.Size(893, 369);
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
            this.refreshLogsButton.Location = new System.Drawing.Point(40, 14);
            this.refreshLogsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshLogsButton.Name = "refreshLogsButton";
            this.refreshLogsButton.Size = new System.Drawing.Size(100, 50);
            this.refreshLogsButton.TabIndex = 1;
            this.refreshLogsButton.Text = "Refresh";
            this.refreshLogsButton.UseVisualStyleBackColor = false;
            this.refreshLogsButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // logLocationButton
            // 
            this.logLocationButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logLocationButton.Location = new System.Drawing.Point(164, 14);
            this.logLocationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logLocationButton.Name = "logLocationButton";
            this.logLocationButton.Size = new System.Drawing.Size(100, 50);
            this.logLocationButton.TabIndex = 3;
            this.logLocationButton.Text = "Log File Location";
            this.logLocationButton.UseVisualStyleBackColor = false;
            this.logLocationButton.Click += new System.EventHandler(this.logLocationButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Enabled = false;
            this.searchBox.Location = new System.Drawing.Point(327, 33);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(173, 23);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(323, 14);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(53, 17);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search";
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 462);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.logLocationButton);
            this.Controls.Add(this.refreshLogsButton);
            this.Controls.Add(this.logGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button refreshLogsButton;
        private System.Windows.Forms.Button logLocationButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;
    }
}