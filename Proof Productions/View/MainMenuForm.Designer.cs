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
            this.cueManagerLabel = new System.Windows.Forms.Label();
            this.MotorListLabel = new System.Windows.Forms.Label();
            this.addCueButton = new System.Windows.Forms.Button();
            this.cueManager = new System.Windows.Forms.ListBox();
            this.removeCueButton = new System.Windows.Forms.Button();
            this.cueDescriptionLabel = new System.Windows.Forms.Label();
            this.editCueButton = new System.Windows.Forms.Button();
            this.motorList = new System.Windows.Forms.ListView();
            this.playCueButton = new System.Windows.Forms.Button();
            this.cueDescription = new System.Windows.Forms.RichTextBox();
            this.pauseCueButton = new System.Windows.Forms.Button();
            this.previousCueButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextCueButton = new System.Windows.Forms.Button();
            this.estopButton = new System.Windows.Forms.Button();
            this.stopCueButton = new System.Windows.Forms.Button();
            this.moveCueDownButton = new System.Windows.Forms.Button();
            this.moveCueUpButton = new System.Windows.Forms.Button();
            this.cueActionFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cueManagerLabel
            // 
            this.cueManagerLabel.AutoSize = true;
            this.cueManagerLabel.Location = new System.Drawing.Point(263, 47);
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
            this.MotorListLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MotorListLabel.Location = new System.Drawing.Point(583, 47);
            this.MotorListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MotorListLabel.Name = "MotorListLabel";
            this.MotorListLabel.Size = new System.Drawing.Size(70, 17);
            this.MotorListLabel.TabIndex = 7;
            this.MotorListLabel.Text = "Motor List";
            // 
            // addCueButton
            // 
            this.addCueButton.AutoSize = true;
            this.addCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCueButton.Location = new System.Drawing.Point(201, 421);
            this.addCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCueButton.Name = "addCueButton";
            this.addCueButton.Size = new System.Drawing.Size(223, 28);
            this.addCueButton.TabIndex = 1;
            this.addCueButton.Text = "Add Cue";
            this.addCueButton.UseVisualStyleBackColor = false;
            this.addCueButton.Click += new System.EventHandler(this.addCueButton_Click);
            // 
            // cueManager
            // 
            this.cueManager.FormattingEnabled = true;
            this.cueManager.ItemHeight = 16;
            this.cueManager.Location = new System.Drawing.Point(201, 66);
            this.cueManager.Margin = new System.Windows.Forms.Padding(4);
            this.cueManager.MaximumSize = new System.Drawing.Size(221, 430);
            this.cueManager.MinimumSize = new System.Drawing.Size(221, 308);
            this.cueManager.Name = "cueManager";
            this.cueManager.Size = new System.Drawing.Size(221, 308);
            this.cueManager.TabIndex = 4;
            this.cueManager.SelectedIndexChanged += new System.EventHandler(this.cueManager_SelectedIndexChanged_1);
            // 
            // removeCueButton
            // 
            this.removeCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeCueButton.Location = new System.Drawing.Point(201, 457);
            this.removeCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeCueButton.Name = "removeCueButton";
            this.removeCueButton.Size = new System.Drawing.Size(223, 28);
            this.removeCueButton.TabIndex = 2;
            this.removeCueButton.Text = "Remove Cue";
            this.removeCueButton.UseVisualStyleBackColor = false;
            this.removeCueButton.Click += new System.EventHandler(this.removeCueButton_Click);
            // 
            // cueDescriptionLabel
            // 
            this.cueDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cueDescriptionLabel.AutoSize = true;
            this.cueDescriptionLabel.Location = new System.Drawing.Point(865, 47);
            this.cueDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cueDescriptionLabel.Name = "cueDescriptionLabel";
            this.cueDescriptionLabel.Size = new System.Drawing.Size(108, 17);
            this.cueDescriptionLabel.TabIndex = 8;
            this.cueDescriptionLabel.Text = "Cue Description";
            // 
            // editCueButton
            // 
            this.editCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editCueButton.Location = new System.Drawing.Point(201, 492);
            this.editCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.editCueButton.Name = "editCueButton";
            this.editCueButton.Size = new System.Drawing.Size(223, 28);
            this.editCueButton.TabIndex = 3;
            this.editCueButton.Text = "Edit Cue";
            this.editCueButton.UseVisualStyleBackColor = false;
            this.editCueButton.Click += new System.EventHandler(this.editCueButton_Click);
            // 
            // motorList
            // 
            this.motorList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.motorList.Location = new System.Drawing.Point(500, 66);
            this.motorList.Margin = new System.Windows.Forms.Padding(4);
            this.motorList.MaximumSize = new System.Drawing.Size(221, 368);
            this.motorList.MinimumSize = new System.Drawing.Size(221, 301);
            this.motorList.Name = "motorList";
            this.motorList.Size = new System.Drawing.Size(221, 301);
            this.motorList.TabIndex = 4;
            this.motorList.UseCompatibleStateImageBehavior = false;
            this.motorList.SelectedIndexChanged += new System.EventHandler(this.motorList_SelectedIndexChanged);
            // 
            // playCueButton
            // 
            this.playCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playCueButton.AutoSize = true;
            this.playCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.playCueButton.Location = new System.Drawing.Point(811, 195);
            this.playCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.playCueButton.Name = "playCueButton";
            this.playCueButton.Size = new System.Drawing.Size(213, 28);
            this.playCueButton.TabIndex = 1;
            this.playCueButton.Text = "Play Cue";
            this.playCueButton.UseVisualStyleBackColor = false;
            this.playCueButton.Click += new System.EventHandler(this.playCueButton_Click);
            // 
            // cueDescription
            // 
            this.cueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cueDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cueDescription.Location = new System.Drawing.Point(812, 66);
            this.cueDescription.Margin = new System.Windows.Forms.Padding(4);
            this.cueDescription.MaximumSize = new System.Drawing.Size(252, 276);
            this.cueDescription.MinimumSize = new System.Drawing.Size(212, 126);
            this.cueDescription.Name = "cueDescription";
            this.cueDescription.ReadOnly = true;
            this.cueDescription.Size = new System.Drawing.Size(212, 126);
            this.cueDescription.TabIndex = 0;
            this.cueDescription.Text = "";
            this.cueDescription.TextChanged += new System.EventHandler(this.cueDescription_TextChanged);
            // 
            // pauseCueButton
            // 
            this.pauseCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pauseCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseCueButton.Enabled = false;
            this.pauseCueButton.Location = new System.Drawing.Point(812, 231);
            this.pauseCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.pauseCueButton.Name = "pauseCueButton";
            this.pauseCueButton.Size = new System.Drawing.Size(213, 28);
            this.pauseCueButton.TabIndex = 2;
            this.pauseCueButton.Text = "Pause Cue";
            this.pauseCueButton.UseVisualStyleBackColor = false;
            this.pauseCueButton.Click += new System.EventHandler(this.pauseCueButton_Click);
            // 
            // previousCueButton
            // 
            this.previousCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousCueButton.Location = new System.Drawing.Point(812, 267);
            this.previousCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.previousCueButton.Name = "previousCueButton";
            this.previousCueButton.Size = new System.Drawing.Size(213, 28);
            this.previousCueButton.TabIndex = 3;
            this.previousCueButton.Text = "Previous Cue";
            this.previousCueButton.UseVisualStyleBackColor = false;
            this.previousCueButton.Click += new System.EventHandler(this.previousCueButton_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
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
            // nextCueButton
            // 
            this.nextCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextCueButton.Location = new System.Drawing.Point(811, 303);
            this.nextCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.nextCueButton.Name = "nextCueButton";
            this.nextCueButton.Size = new System.Drawing.Size(213, 28);
            this.nextCueButton.TabIndex = 4;
            this.nextCueButton.Text = "Next Cue";
            this.nextCueButton.UseVisualStyleBackColor = false;
            this.nextCueButton.Click += new System.EventHandler(this.nextCueButton_Click);
            // 
            // estopButton
            // 
            this.estopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.estopButton.AutoSize = true;
            this.estopButton.BackColor = System.Drawing.Color.Red;
            this.estopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estopButton.ForeColor = System.Drawing.Color.White;
            this.estopButton.Location = new System.Drawing.Point(458, 406);
            this.estopButton.Margin = new System.Windows.Forms.Padding(4);
            this.estopButton.Name = "estopButton";
            this.estopButton.Size = new System.Drawing.Size(319, 114);
            this.estopButton.TabIndex = 2;
            this.estopButton.Text = "EMERGENCY STOP";
            this.estopButton.UseVisualStyleBackColor = false;
            this.estopButton.Click += new System.EventHandler(this.EstopButtonClick);
            // 
            // stopCueButton
            // 
            this.stopCueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopCueButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopCueButton.Location = new System.Drawing.Point(811, 339);
            this.stopCueButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopCueButton.Name = "stopCueButton";
            this.stopCueButton.Size = new System.Drawing.Size(213, 28);
            this.stopCueButton.TabIndex = 5;
            this.stopCueButton.Text = "Stop Cue";
            this.stopCueButton.UseVisualStyleBackColor = false;
            this.stopCueButton.Click += new System.EventHandler(this.stopCueButton_Click);
            // 
            // moveCueDownButton
            // 
            this.moveCueDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveCueDownButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.moveCueDownButton.Enabled = false;
            this.moveCueDownButton.Location = new System.Drawing.Point(47, 295);
            this.moveCueDownButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveCueDownButton.MaximumSize = new System.Drawing.Size(93, 80);
            this.moveCueDownButton.MinimumSize = new System.Drawing.Size(63, 50);
            this.moveCueDownButton.Name = "moveCueDownButton";
            this.moveCueDownButton.Size = new System.Drawing.Size(63, 50);
            this.moveCueDownButton.TabIndex = 10;
            this.moveCueDownButton.Text = "down";
            this.moveCueDownButton.UseVisualStyleBackColor = false;
            this.moveCueDownButton.Click += new System.EventHandler(this.moveCueDownButton_Click);
            // 
            // moveCueUpButton
            // 
            this.moveCueUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveCueUpButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.moveCueUpButton.Enabled = false;
            this.moveCueUpButton.Location = new System.Drawing.Point(47, 142);
            this.moveCueUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveCueUpButton.MaximumSize = new System.Drawing.Size(93, 80);
            this.moveCueUpButton.MinimumSize = new System.Drawing.Size(63, 52);
            this.moveCueUpButton.Name = "moveCueUpButton";
            this.moveCueUpButton.Size = new System.Drawing.Size(63, 52);
            this.moveCueUpButton.TabIndex = 9;
            this.moveCueUpButton.Text = "up";
            this.moveCueUpButton.UseVisualStyleBackColor = false;
            this.moveCueUpButton.Click += new System.EventHandler(this.moveCueUpButton_Click);
            // 
            // cueActionFlowLayoutPanel
            // 
            this.cueActionFlowLayoutPanel.AutoSize = true;
            this.cueActionFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cueActionFlowLayoutPanel.Location = new System.Drawing.Point(587, 82);
            this.cueActionFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.cueActionFlowLayoutPanel.Name = "cueActionFlowLayoutPanel";
            this.cueActionFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.cueActionFlowLayoutPanel.TabIndex = 5;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 586);
            this.Controls.Add(this.cueManagerLabel);
            this.Controls.Add(this.MotorListLabel);
            this.Controls.Add(this.addCueButton);
            this.Controls.Add(this.cueManager);
            this.Controls.Add(this.removeCueButton);
            this.Controls.Add(this.cueDescriptionLabel);
            this.Controls.Add(this.editCueButton);
            this.Controls.Add(this.motorList);
            this.Controls.Add(this.playCueButton);
            this.Controls.Add(this.cueDescription);
            this.Controls.Add(this.pauseCueButton);
            this.Controls.Add(this.previousCueButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nextCueButton);
            this.Controls.Add(this.estopButton);
            this.Controls.Add(this.stopCueButton);
            this.Controls.Add(this.moveCueDownButton);
            this.Controls.Add(this.moveCueUpButton);
            this.Controls.Add(this.cueActionFlowLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1151, 625);
            this.Name = "MainMenuForm";
            this.Text = "Proof Productions: Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cueManagerLabel;
        private System.Windows.Forms.Label MotorListLabel;


        //Cue Action components
        private System.Windows.Forms.FlowLayoutPanel cueActionFlowLayoutPanel;
        private System.Windows.Forms.Label cueDescriptionLabel;
        private System.Windows.Forms.Button estopButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupMotorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button moveCueDownButton;
        private System.Windows.Forms.Button moveCueUpButton;
        private Button stopCueButton;
        private Button nextCueButton;
        private Button previousCueButton;
        private Button pauseCueButton;
        private Button playCueButton;
        private RichTextBox cueDescription;
        private ListView motorList;
        private Button editCueButton;
        private Button removeCueButton;
        private Button addCueButton;
        private ListBox cueManager;
    }
}
