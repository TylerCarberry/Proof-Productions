using System.Windows.Forms;

namespace Proof_Productions.View
{
    partial class MainMenuForm
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
            this.estopButton = new System.Windows.Forms.Button();
            this.cueDescription = new System.Windows.Forms.RichTextBox();
            this.playCueButton = new System.Windows.Forms.Button();
            this.pauseCueButton = new System.Windows.Forms.Button();
            this.stopCueButton = new System.Windows.Forms.Button();
            this.previousCueButton = new System.Windows.Forms.Button();
            this.nextCueButton = new System.Windows.Forms.Button();
            this.editCueButton = new System.Windows.Forms.Button();
            this.cueManager = new System.Windows.Forms.ListBox();
            this.cueManagerLabel = new System.Windows.Forms.Label();
            this.MotorListLabel = new System.Windows.Forms.Label();
            this.cueDescriptionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estopButton
            // 
            this.estopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.estopButton.BackColor = System.Drawing.Color.Red;
            this.estopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estopButton.ForeColor = System.Drawing.Color.White;
            this.estopButton.Location = new System.Drawing.Point(532, 389);
            this.estopButton.Margin = new System.Windows.Forms.Padding(4);
            this.estopButton.Name = "estopButton";
            this.estopButton.Size = new System.Drawing.Size(213, 89);
            this.estopButton.TabIndex = 10;
            this.estopButton.Text = "EMERGENCY STOP";
            this.estopButton.UseVisualStyleBackColor = false;
            this.estopButton.Click += new System.EventHandler(this.EstopButtonClick);
            // 
            // cueDescription
            // 
            this.cueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cueDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cueDescription.Location = new System.Drawing.Point(533, 73);
            this.cueDescription.Margin = new System.Windows.Forms.Padding(4);
            this.cueDescription.Name = "cueDescription";
            this.cueDescription.ReadOnly = true;
            this.cueDescription.Size = new System.Drawing.Size(212, 126);
            this.cueDescription.TabIndex = 4;
            this.cueDescription.Text = "";
            this.cueDescription.TextChanged += new System.EventHandler(this.cueDescription_TextChanged);
            // 
            // playCueButton
            // 
            this.playCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playCueButton.Location = new System.Drawing.Point(533, 207);
            this.playCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.playCueButton.Name = "playCueButton";
            this.playCueButton.Size = new System.Drawing.Size(213, 28);
            this.playCueButton.TabIndex = 5;
            this.playCueButton.Text = "Play Cue";
            this.playCueButton.UseVisualStyleBackColor = false;
            this.playCueButton.Click += new System.EventHandler(this.PlayCueButton_Click);
            // 
            // pauseCueButton
            // 
            this.pauseCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseCueButton.Location = new System.Drawing.Point(532, 239);
            this.pauseCueButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pauseCueButton.Name = "pauseCueButton";
            this.pauseCueButton.Size = new System.Drawing.Size(213, 28);
            this.pauseCueButton.TabIndex = 6;
            this.pauseCueButton.Text = "Pause Cue";
            this.pauseCueButton.UseVisualStyleBackColor = false;
            this.pauseCueButton.Click += new System.EventHandler(this.PauseCueButton_Click);
            // 
            // stopCueButton
            // 
            this.stopCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopCueButton.Location = new System.Drawing.Point(532, 271);
            this.stopCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopCueButton.Name = "stopCueButton";
            this.stopCueButton.Size = new System.Drawing.Size(213, 28);
            this.stopCueButton.TabIndex = 7;
            this.stopCueButton.Text = "Stop Cue";
            this.stopCueButton.UseVisualStyleBackColor = false;
            this.stopCueButton.Click += new System.EventHandler(this.StopCueButton_Click);
            // 
            // previousCueButton
            // 
            this.previousCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousCueButton.Location = new System.Drawing.Point(533, 321);
            this.previousCueButton.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.previousCueButton.Name = "previousCueButton";
            this.previousCueButton.Size = new System.Drawing.Size(213, 28);
            this.previousCueButton.TabIndex = 8;
            this.previousCueButton.Text = "Previous Cue";
            this.previousCueButton.UseVisualStyleBackColor = false;
            this.previousCueButton.Click += new System.EventHandler(this.PreviousCueButton_Click);
            // 
            // nextCueButton
            // 
            this.nextCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextCueButton.Location = new System.Drawing.Point(533, 353);
            this.nextCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextCueButton.Name = "nextCueButton";
            this.nextCueButton.Size = new System.Drawing.Size(213, 28);
            this.nextCueButton.TabIndex = 9;
            this.nextCueButton.Text = "Next Cue";
            this.nextCueButton.UseVisualStyleBackColor = false;
            this.nextCueButton.Click += new System.EventHandler(this.NextCueButton_Click);
            // 
            // editCueButton
            // 
            this.editCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editCueButton.Location = new System.Drawing.Point(28, 412);
            this.editCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.editCueButton.Name = "editCueButton";
            this.editCueButton.Size = new System.Drawing.Size(223, 28);
            this.editCueButton.TabIndex = 2;
            this.editCueButton.Text = "Edit Cue";
            this.editCueButton.UseVisualStyleBackColor = false;
            this.editCueButton.Click += new System.EventHandler(this.editCueButton_Click);
            // 
            // cueManager
            // 
            this.cueManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cueManager.FormattingEnabled = true;
            this.cueManager.ItemHeight = 16;
            this.cueManager.Location = new System.Drawing.Point(28, 73);
            this.cueManager.Margin = new System.Windows.Forms.Padding(4);
            this.cueManager.Name = "cueManager";
            this.cueManager.Size = new System.Drawing.Size(221, 308);
            this.cueManager.TabIndex = 1;
            this.cueManager.SelectedIndexChanged += new System.EventHandler(this.cueManager_SelectedIndexChanged_1);
            // 
            // cueManagerLabel
            // 
            this.cueManagerLabel.AutoSize = true;
            this.cueManagerLabel.Location = new System.Drawing.Point(92, 47);
            this.cueManagerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cueManagerLabel.Name = "cueManagerLabel";
            this.cueManagerLabel.Size = new System.Drawing.Size(93, 17);
            this.cueManagerLabel.TabIndex = 6;
            this.cueManagerLabel.Text = "Cue Manager";
            // 
            // MotorListLabel
            // 
            this.MotorListLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MotorListLabel.AutoSize = true;
            this.MotorListLabel.Location = new System.Drawing.Point(351, 47);
            this.MotorListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MotorListLabel.Name = "MotorListLabel";
            this.MotorListLabel.Size = new System.Drawing.Size(70, 17);
            this.MotorListLabel.TabIndex = 7;
            this.MotorListLabel.Text = "Motor List";
            // 
            // cueDescriptionLabel
            // 
            this.cueDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cueDescriptionLabel.AutoSize = true;
            this.cueDescriptionLabel.Location = new System.Drawing.Point(587, 47);
            this.cueDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cueDescriptionLabel.Name = "cueDescriptionLabel";
            this.cueDescriptionLabel.Size = new System.Drawing.Size(108, 17);
            this.cueDescriptionLabel.TabIndex = 8;
            this.cueDescriptionLabel.Text = "Cue Description";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mainMenuToolStripMenuItem.Text = "Home";
            // 
            // manualControlToolStripMenuItem
            // 
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.manualControlToolStripMenuItem_Click);
            // 
            // setupMotorsToolStripMenuItem
            // 
            this.setupMotorsToolStripMenuItem.Name = "setupMotorsToolStripMenuItem";
            this.setupMotorsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.setupMotorsToolStripMenuItem.Text = "Setup Motors";
            this.setupMotorsToolStripMenuItem.Click += new System.EventHandler(this.setupMotorsToolStripMenuItem_Click);
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
            // motorList
            // 
            this.motorList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.motorList.FormattingEnabled = true;
            this.motorList.ItemHeight = 16;
            this.motorList.Location = new System.Drawing.Point(285, 73);
            this.motorList.Margin = new System.Windows.Forms.Padding(4);
            this.motorList.Name = "motorList";
            this.motorList.Size = new System.Drawing.Size(212, 308);
            this.motorList.TabIndex = 3;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 494);
            this.Controls.Add(this.cueManager);
            this.Controls.Add(this.cueDescription);
            this.Controls.Add(this.editCueButton);
            this.Controls.Add(this.motorList);
            this.Controls.Add(this.playCueButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pauseCueButton);
            this.Controls.Add(this.cueDescriptionLabel);
            this.Controls.Add(this.stopCueButton);
            this.Controls.Add(this.MotorListLabel);
            this.Controls.Add(this.previousCueButton);
            this.Controls.Add(this.cueManagerLabel);
            this.Controls.Add(this.nextCueButton);
            this.Controls.Add(this.estopButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(808, 533);
            this.Name = "MainMenuForm";
            this.Text = "Proof Productions: Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cueManagerLabel;
        private System.Windows.Forms.Button editCueButton;
        private System.Windows.Forms.Label MotorListLabel;

        private System.Windows.Forms.RichTextBox cueDescription;
        private System.Windows.Forms.Label cueDescriptionLabel;
        private System.Windows.Forms.Button estopButton;
        private System.Windows.Forms.Button playCueButton;
        private System.Windows.Forms.Button pauseCueButton;
        private System.Windows.Forms.Button previousCueButton;
        private System.Windows.Forms.Button nextCueButton;
        private System.Windows.Forms.Button stopCueButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupMotorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox cueManager;
        private ListBox motorList;
    }
}
