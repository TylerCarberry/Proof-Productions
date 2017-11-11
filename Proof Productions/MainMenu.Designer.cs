namespace Proof_Productions
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
            this.motorList = new System.Windows.Forms.ListView();
            this.cueActionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cueDescription = new System.Windows.Forms.RichTextBox();
            this.playCueButton = new System.Windows.Forms.Button();
            this.pauseCueButton = new System.Windows.Forms.Button();
            this.previousCueButton = new System.Windows.Forms.Button();
            this.nextCueButton = new System.Windows.Forms.Button();
            this.stopCueButton = new System.Windows.Forms.Button();
            this.removeCueButton = new System.Windows.Forms.Button();
            this.editCueButton = new System.Windows.Forms.Button();
            this.addCueButton = new System.Windows.Forms.Button();
            this.cueManager = new System.Windows.Forms.ListView();
            this.cueFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cueManagerLabel = new System.Windows.Forms.Label();
            this.MotorListLabel = new System.Windows.Forms.Label();
            this.cueDescriptionLabel = new System.Windows.Forms.Label();
            this.moveCueUpButton = new System.Windows.Forms.Button();
            this.moveCueDownButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cueActionFlowLayoutPanel.SuspendLayout();
            this.cueFlowLayoutPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // estopButton
            // 
            this.estopButton.BackColor = System.Drawing.Color.Red;
            this.estopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estopButton.ForeColor = System.Drawing.Color.White;
            this.estopButton.Location = new System.Drawing.Point(3, 257);
            this.estopButton.Name = "estopButton";
            this.estopButton.Size = new System.Drawing.Size(160, 72);
            this.estopButton.TabIndex = 2;
            this.estopButton.Text = "EMERGENCY STOP";
            this.estopButton.UseVisualStyleBackColor = false;
            this.estopButton.Click += new System.EventHandler(this.EstopButtonClick);
            // 
            // motorList
            // 
            this.motorList.Location = new System.Drawing.Point(251, 70);
            this.motorList.Name = "motorList";
            this.motorList.Size = new System.Drawing.Size(167, 245);
            this.motorList.TabIndex = 4;
            this.motorList.UseCompatibleStateImageBehavior = false;
            this.motorList.SelectedIndexChanged += new System.EventHandler(this.motorList_SelectedIndexChanged);
            // 
            // cueActionFlowLayoutPanel
            // 
            this.cueActionFlowLayoutPanel.Controls.Add(this.cueDescription);
            this.cueActionFlowLayoutPanel.Controls.Add(this.playCueButton);
            this.cueActionFlowLayoutPanel.Controls.Add(this.pauseCueButton);
            this.cueActionFlowLayoutPanel.Controls.Add(this.previousCueButton);
            this.cueActionFlowLayoutPanel.Controls.Add(this.nextCueButton);
            this.cueActionFlowLayoutPanel.Controls.Add(this.stopCueButton);
            this.cueActionFlowLayoutPanel.Controls.Add(this.estopButton);
            this.cueActionFlowLayoutPanel.Location = new System.Drawing.Point(440, 67);
            this.cueActionFlowLayoutPanel.Name = "cueActionFlowLayoutPanel";
            this.cueActionFlowLayoutPanel.Size = new System.Drawing.Size(166, 335);
            this.cueActionFlowLayoutPanel.TabIndex = 5;
            // 
            // cueDescription
            // 
            this.cueDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cueDescription.Location = new System.Drawing.Point(3, 3);
            this.cueDescription.Name = "cueDescription";
            this.cueDescription.ReadOnly = true;
            this.cueDescription.Size = new System.Drawing.Size(160, 103);
            this.cueDescription.TabIndex = 0;
            this.cueDescription.Text = "";
            // 
            // playCueButton
            // 
            this.playCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playCueButton.Location = new System.Drawing.Point(3, 112);
            this.playCueButton.Name = "playCueButton";
            this.playCueButton.Size = new System.Drawing.Size(160, 23);
            this.playCueButton.TabIndex = 1;
            this.playCueButton.Text = "Play Cue";
            this.playCueButton.UseVisualStyleBackColor = false;
            this.playCueButton.Click += new System.EventHandler(this.playCueButton_Click);
            // 
            // pauseCueButton
            // 
            this.pauseCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseCueButton.Location = new System.Drawing.Point(3, 141);
            this.pauseCueButton.Name = "pauseCueButton";
            this.pauseCueButton.Size = new System.Drawing.Size(160, 23);
            this.pauseCueButton.TabIndex = 2;
            this.pauseCueButton.Text = "Pause Cue";
            this.pauseCueButton.UseVisualStyleBackColor = false;
            this.pauseCueButton.Click += new System.EventHandler(this.pauseCueButton_Click);
            // 
            // previousCueButton
            // 
            this.previousCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousCueButton.Location = new System.Drawing.Point(3, 170);
            this.previousCueButton.Name = "previousCueButton";
            this.previousCueButton.Size = new System.Drawing.Size(160, 23);
            this.previousCueButton.TabIndex = 3;
            this.previousCueButton.Text = "Previous Cue";
            this.previousCueButton.UseVisualStyleBackColor = false;
            this.previousCueButton.Click += new System.EventHandler(this.previousCueButton_Click);
            // 
            // nextCueButton
            // 
            this.nextCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextCueButton.Location = new System.Drawing.Point(3, 199);
            this.nextCueButton.Name = "nextCueButton";
            this.nextCueButton.Size = new System.Drawing.Size(160, 23);
            this.nextCueButton.TabIndex = 4;
            this.nextCueButton.Text = "Next Cue";
            this.nextCueButton.UseVisualStyleBackColor = false;
            this.nextCueButton.Click += new System.EventHandler(this.nextCueButton_Click);
            // 
            // stopCueButton
            // 
            this.stopCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopCueButton.Location = new System.Drawing.Point(3, 228);
            this.stopCueButton.Name = "stopCueButton";
            this.stopCueButton.Size = new System.Drawing.Size(160, 23);
            this.stopCueButton.TabIndex = 5;
            this.stopCueButton.Text = "Stop Cue";
            this.stopCueButton.UseVisualStyleBackColor = false;
            this.stopCueButton.Click += new System.EventHandler(this.stopCueButton_Click);
            // 
            // removeCueButton
            // 
            this.removeCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeCueButton.Location = new System.Drawing.Point(3, 312);
            this.removeCueButton.Name = "removeCueButton";
            this.removeCueButton.Size = new System.Drawing.Size(167, 23);
            this.removeCueButton.TabIndex = 2;
            this.removeCueButton.Text = "Remove Cue";
            this.removeCueButton.UseVisualStyleBackColor = false;
            this.removeCueButton.Click += new System.EventHandler(this.removeCueButton_Click);
            // 
            // editCueButton
            // 
            this.editCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editCueButton.Location = new System.Drawing.Point(3, 283);
            this.editCueButton.Name = "editCueButton";
            this.editCueButton.Size = new System.Drawing.Size(167, 23);
            this.editCueButton.TabIndex = 3;
            this.editCueButton.Text = "Edit Cue";
            this.editCueButton.UseVisualStyleBackColor = false;
            this.editCueButton.Click += new System.EventHandler(this.editCueButton_Click);
            // 
            // addCueButton
            // 
            this.addCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCueButton.Location = new System.Drawing.Point(3, 254);
            this.addCueButton.Name = "addCueButton";
            this.addCueButton.Size = new System.Drawing.Size(167, 23);
            this.addCueButton.TabIndex = 1;
            this.addCueButton.Text = "Add Cue";
            this.addCueButton.UseVisualStyleBackColor = false;
            this.addCueButton.Click += new System.EventHandler(this.addCueButton_Click);
            // 
            // cueManager
            // 
            this.cueManager.Location = new System.Drawing.Point(3, 3);
            this.cueManager.Name = "cueManager";
            this.cueManager.Size = new System.Drawing.Size(167, 245);
            this.cueManager.TabIndex = 0;
            this.cueManager.UseCompatibleStateImageBehavior = false;
            this.cueManager.SelectedIndexChanged += new System.EventHandler(this.cueManager_SelectedIndexChanged);
            // 
            // cueFlowLayoutPanel
            // 
            this.cueFlowLayoutPanel.Controls.Add(this.cueManager);
            this.cueFlowLayoutPanel.Controls.Add(this.addCueButton);
            this.cueFlowLayoutPanel.Controls.Add(this.editCueButton);
            this.cueFlowLayoutPanel.Controls.Add(this.removeCueButton);
            this.cueFlowLayoutPanel.Location = new System.Drawing.Point(62, 67);
            this.cueFlowLayoutPanel.Name = "cueFlowLayoutPanel";
            this.cueFlowLayoutPanel.Size = new System.Drawing.Size(174, 343);
            this.cueFlowLayoutPanel.TabIndex = 3;
            // 
            // cueManagerLabel
            // 
            this.cueManagerLabel.AutoSize = true;
            this.cueManagerLabel.Location = new System.Drawing.Point(113, 49);
            this.cueManagerLabel.Name = "cueManagerLabel";
            this.cueManagerLabel.Size = new System.Drawing.Size(71, 13);
            this.cueManagerLabel.TabIndex = 6;
            this.cueManagerLabel.Text = "Cue Manager";
            // 
            // MotorListLabel
            // 
            this.MotorListLabel.AutoSize = true;
            this.MotorListLabel.Location = new System.Drawing.Point(307, 49);
            this.MotorListLabel.Name = "MotorListLabel";
            this.MotorListLabel.Size = new System.Drawing.Size(53, 13);
            this.MotorListLabel.TabIndex = 7;
            this.MotorListLabel.Text = "Motor List";
            // 
            // cueDescriptionLabel
            // 
            this.cueDescriptionLabel.AutoSize = true;
            this.cueDescriptionLabel.Location = new System.Drawing.Point(484, 49);
            this.cueDescriptionLabel.Name = "cueDescriptionLabel";
            this.cueDescriptionLabel.Size = new System.Drawing.Size(82, 13);
            this.cueDescriptionLabel.TabIndex = 8;
            this.cueDescriptionLabel.Text = "Cue Description";
            // 
            // moveCueUpButton
            // 
            this.moveCueUpButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.moveCueUpButton.Location = new System.Drawing.Point(12, 143);
            this.moveCueUpButton.Name = "moveCueUpButton";
            this.moveCueUpButton.Size = new System.Drawing.Size(47, 42);
            this.moveCueUpButton.TabIndex = 9;
            this.moveCueUpButton.Text = "up";
            this.moveCueUpButton.UseVisualStyleBackColor = false;
            this.moveCueUpButton.Click += new System.EventHandler(this.moveCueUpButton_Click);
            // 
            // moveCueDownButton
            // 
            this.moveCueDownButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.moveCueDownButton.Location = new System.Drawing.Point(12, 202);
            this.moveCueDownButton.Name = "moveCueDownButton";
            this.moveCueDownButton.Size = new System.Drawing.Size(47, 41);
            this.moveCueDownButton.TabIndex = 10;
            this.moveCueDownButton.Text = "down";
            this.moveCueDownButton.UseVisualStyleBackColor = false;
            this.moveCueDownButton.Click += new System.EventHandler(this.moveCueDownButton_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 425);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.moveCueDownButton);
            this.Controls.Add(this.moveCueUpButton);
            this.Controls.Add(this.cueDescriptionLabel);
            this.Controls.Add(this.MotorListLabel);
            this.Controls.Add(this.cueManagerLabel);
            this.Controls.Add(this.cueActionFlowLayoutPanel);
            this.Controls.Add(this.motorList);
            this.Controls.Add(this.cueFlowLayoutPanel);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cueActionFlowLayoutPanel.ResumeLayout(false);
            this.cueFlowLayoutPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Cue Manager components
        private System.Windows.Forms.FlowLayoutPanel cueFlowLayoutPanel;
        private System.Windows.Forms.ListView cueManager;
        private System.Windows.Forms.Label cueManagerLabel;
        private System.Windows.Forms.Button moveCueUpButton;
        private System.Windows.Forms.Button moveCueDownButton;
        private System.Windows.Forms.Button removeCueButton;
        private System.Windows.Forms.Button editCueButton;
        private System.Windows.Forms.Button addCueButton;

        //Motor List components
        private System.Windows.Forms.ListView motorList;
        private System.Windows.Forms.Label MotorListLabel;


        //Cue Action components
        private System.Windows.Forms.FlowLayoutPanel cueActionFlowLayoutPanel;
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
    }
}
