namespace Proof_Productions
{
    partial class ManualControlForm
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
            this.motor1Desc = new System.Windows.Forms.TextBox();
            this.motorBox1 = new System.Windows.Forms.ComboBox();
            this.motor1Spd = new System.Windows.Forms.ComboBox();
            this.motor1Accel = new System.Windows.Forms.ComboBox();
            this.motor1Decel = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.motor1Start = new System.Windows.Forms.Button();
            this.motor1Stop = new System.Windows.Forms.Button();
            this.motor1Clear = new System.Windows.Forms.Button();
            this.motorPanelLeft = new System.Windows.Forms.Panel();
            this.decelLabel1 = new System.Windows.Forms.Label();
            this.spdLabel1 = new System.Windows.Forms.Label();
            this.accelLabel1 = new System.Windows.Forms.Label();
            this.motorPanelCenter = new System.Windows.Forms.Panel();
            this.decelLabel2 = new System.Windows.Forms.Label();
            this.accelLabel2 = new System.Windows.Forms.Label();
            this.spdLabel2 = new System.Windows.Forms.Label();
            this.dirLabel2 = new System.Windows.Forms.Label();
            this.motor2Clear = new System.Windows.Forms.Button();
            this.motor2Stop = new System.Windows.Forms.Button();
            this.motor2Start = new System.Windows.Forms.Button();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.motor2Decel = new System.Windows.Forms.ComboBox();
            this.motor2Accel = new System.Windows.Forms.ComboBox();
            this.motor2Spd = new System.Windows.Forms.ComboBox();
            this.motor2Dir = new System.Windows.Forms.ComboBox();
            this.motorBox2 = new System.Windows.Forms.ComboBox();
            this.motor2Desc = new System.Windows.Forms.TextBox();
            this.motorPanelRight = new System.Windows.Forms.Panel();
            this.decelLabel3 = new System.Windows.Forms.Label();
            this.accelLabel3 = new System.Windows.Forms.Label();
            this.spdLabel3 = new System.Windows.Forms.Label();
            this.dirLabel3 = new System.Windows.Forms.Label();
            this.motor3Clear = new System.Windows.Forms.Button();
            this.motor3Stop = new System.Windows.Forms.Button();
            this.motor3Start = new System.Windows.Forms.Button();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.motor3Decel = new System.Windows.Forms.ComboBox();
            this.motor3Accel = new System.Windows.Forms.ComboBox();
            this.motor3Spd = new System.Windows.Forms.ComboBox();
            this.motor3Dir = new System.Windows.Forms.ComboBox();
            this.motorBox3 = new System.Windows.Forms.ComboBox();
            this.motor3Desc = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMotorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrateMotorCheckList = new System.Windows.Forms.CheckedListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startCalibrationBtn = new System.Windows.Forms.Button();
            this.pauseCalibrationBtn = new System.Windows.Forms.Button();
            this.stopCalibrationBtn = new System.Windows.Forms.Button();
            this.motor1FowardBox = new System.Windows.Forms.CheckBox();
            this.motor1BackwardsBox = new System.Windows.Forms.CheckBox();
            this.motorPanelLeft.SuspendLayout();
            this.motorPanelCenter.SuspendLayout();
            this.motorPanelRight.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // motor1Desc
            // 
            this.motor1Desc.BackColor = System.Drawing.SystemColors.Window;
            this.motor1Desc.Location = new System.Drawing.Point(21, 35);
            this.motor1Desc.Multiline = true;
            this.motor1Desc.Name = "motor1Desc";
            this.motor1Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.motor1Desc.Size = new System.Drawing.Size(148, 117);
            this.motor1Desc.TabIndex = 0;
            this.motor1Desc.TextChanged += new System.EventHandler(this.motor1Desc_TextChanged);
            // 
            // motorBox1
            // 
            this.motorBox1.FormattingEnabled = true;
            this.motorBox1.Items.AddRange(new object[] {
            "Motor 1"});
            this.motorBox1.Location = new System.Drawing.Point(21, 13);
            this.motorBox1.Name = "motorBox1";
            this.motorBox1.Size = new System.Drawing.Size(148, 21);
            this.motorBox1.TabIndex = 1;
            this.motorBox1.SelectedIndexChanged += new System.EventHandler(this.motorBox1_SelectedIndexChanged);
            // 
            // motor1Spd
            // 
            this.motor1Spd.FormattingEnabled = true;
            this.motor1Spd.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor1Spd.Location = new System.Drawing.Point(20, 175);
            this.motor1Spd.Name = "motor1Spd";
            this.motor1Spd.Size = new System.Drawing.Size(149, 21);
            this.motor1Spd.TabIndex = 3;
            this.motor1Spd.Text = "300";
            this.motor1Spd.SelectedIndexChanged += new System.EventHandler(this.motor1Spd_SelectedIndexChanged);
            // 
            // motor1Accel
            // 
            this.motor1Accel.FormattingEnabled = true;
            this.motor1Accel.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor1Accel.Location = new System.Drawing.Point(20, 215);
            this.motor1Accel.Name = "motor1Accel";
            this.motor1Accel.Size = new System.Drawing.Size(149, 21);
            this.motor1Accel.TabIndex = 4;
            this.motor1Accel.Text = "80";
            this.motor1Accel.SelectedIndexChanged += new System.EventHandler(this.motor1Accel_SelectedIndexChanged);
            // 
            // motor1Decel
            // 
            this.motor1Decel.FormattingEnabled = true;
            this.motor1Decel.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor1Decel.Location = new System.Drawing.Point(21, 256);
            this.motor1Decel.Name = "motor1Decel";
            this.motor1Decel.Size = new System.Drawing.Size(148, 21);
            this.motor1Decel.TabIndex = 5;
            this.motor1Decel.Text = "80";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(21, 292);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(148, 21);
            this.comboBox6.TabIndex = 6;
            // 
            // motor1Start
            // 
            this.motor1Start.Location = new System.Drawing.Point(20, 370);
            this.motor1Start.Name = "motor1Start";
            this.motor1Start.Size = new System.Drawing.Size(48, 23);
            this.motor1Start.TabIndex = 7;
            this.motor1Start.Text = "Start";
            this.motor1Start.UseVisualStyleBackColor = true;
            this.motor1Start.Click += new System.EventHandler(this.motor1Start_Click);
            // 
            // motor1Stop
            // 
            this.motor1Stop.Location = new System.Drawing.Point(72, 370);
            this.motor1Stop.Name = "motor1Stop";
            this.motor1Stop.Size = new System.Drawing.Size(47, 23);
            this.motor1Stop.TabIndex = 8;
            this.motor1Stop.Text = "Stop";
            this.motor1Stop.UseVisualStyleBackColor = true;
            this.motor1Stop.Click += new System.EventHandler(this.motor1Stop_Click);
            // 
            // motor1Clear
            // 
            this.motor1Clear.Location = new System.Drawing.Point(123, 370);
            this.motor1Clear.Name = "motor1Clear";
            this.motor1Clear.Size = new System.Drawing.Size(46, 23);
            this.motor1Clear.TabIndex = 9;
            this.motor1Clear.Text = "Clear";
            this.motor1Clear.UseVisualStyleBackColor = true;
            this.motor1Clear.Click += new System.EventHandler(this.motor1Clear_Click);
            // 
            // motorPanelLeft
            // 
            this.motorPanelLeft.Controls.Add(this.motor1BackwardsBox);
            this.motorPanelLeft.Controls.Add(this.motor1FowardBox);
            this.motorPanelLeft.Controls.Add(this.decelLabel1);
            this.motorPanelLeft.Controls.Add(this.spdLabel1);
            this.motorPanelLeft.Controls.Add(this.accelLabel1);
            this.motorPanelLeft.Controls.Add(this.motor1Clear);
            this.motorPanelLeft.Controls.Add(this.motor1Stop);
            this.motorPanelLeft.Controls.Add(this.motor1Start);
            this.motorPanelLeft.Controls.Add(this.comboBox6);
            this.motorPanelLeft.Controls.Add(this.motor1Decel);
            this.motorPanelLeft.Controls.Add(this.motor1Accel);
            this.motorPanelLeft.Controls.Add(this.motor1Spd);
            this.motorPanelLeft.Controls.Add(this.motorBox1);
            this.motorPanelLeft.Controls.Add(this.motor1Desc);
            this.motorPanelLeft.Location = new System.Drawing.Point(189, 36);
            this.motorPanelLeft.Name = "motorPanelLeft";
            this.motorPanelLeft.Size = new System.Drawing.Size(190, 410);
            this.motorPanelLeft.TabIndex = 10;
            // 
            // decelLabel1
            // 
            this.decelLabel1.AutoSize = true;
            this.decelLabel1.Location = new System.Drawing.Point(19, 243);
            this.decelLabel1.Name = "decelLabel1";
            this.decelLabel1.Size = new System.Drawing.Size(67, 13);
            this.decelLabel1.TabIndex = 15;
            this.decelLabel1.Text = "Deceleration";
            // 
            // spdLabel1
            // 
            this.spdLabel1.AutoSize = true;
            this.spdLabel1.Location = new System.Drawing.Point(18, 158);
            this.spdLabel1.Name = "spdLabel1";
            this.spdLabel1.Size = new System.Drawing.Size(38, 13);
            this.spdLabel1.TabIndex = 13;
            this.spdLabel1.Text = "Speed";
            // 
            // accelLabel1
            // 
            this.accelLabel1.AutoSize = true;
            this.accelLabel1.Location = new System.Drawing.Point(18, 199);
            this.accelLabel1.Name = "accelLabel1";
            this.accelLabel1.Size = new System.Drawing.Size(66, 13);
            this.accelLabel1.TabIndex = 14;
            this.accelLabel1.Text = "Acceleration";
            // 
            // motorPanelCenter
            // 
            this.motorPanelCenter.Controls.Add(this.decelLabel2);
            this.motorPanelCenter.Controls.Add(this.accelLabel2);
            this.motorPanelCenter.Controls.Add(this.spdLabel2);
            this.motorPanelCenter.Controls.Add(this.dirLabel2);
            this.motorPanelCenter.Controls.Add(this.motor2Clear);
            this.motorPanelCenter.Controls.Add(this.motor2Stop);
            this.motorPanelCenter.Controls.Add(this.motor2Start);
            this.motorPanelCenter.Controls.Add(this.comboBox7);
            this.motorPanelCenter.Controls.Add(this.motor2Decel);
            this.motorPanelCenter.Controls.Add(this.motor2Accel);
            this.motorPanelCenter.Controls.Add(this.motor2Spd);
            this.motorPanelCenter.Controls.Add(this.motor2Dir);
            this.motorPanelCenter.Controls.Add(this.motorBox2);
            this.motorPanelCenter.Controls.Add(this.motor2Desc);
            this.motorPanelCenter.Location = new System.Drawing.Point(407, 36);
            this.motorPanelCenter.Name = "motorPanelCenter";
            this.motorPanelCenter.Size = new System.Drawing.Size(190, 410);
            this.motorPanelCenter.TabIndex = 11;
            // 
            // decelLabel2
            // 
            this.decelLabel2.AutoSize = true;
            this.decelLabel2.Location = new System.Drawing.Point(18, 281);
            this.decelLabel2.Name = "decelLabel2";
            this.decelLabel2.Size = new System.Drawing.Size(67, 13);
            this.decelLabel2.TabIndex = 16;
            this.decelLabel2.Text = "Deceleration";
            // 
            // accelLabel2
            // 
            this.accelLabel2.AutoSize = true;
            this.accelLabel2.Location = new System.Drawing.Point(17, 237);
            this.accelLabel2.Name = "accelLabel2";
            this.accelLabel2.Size = new System.Drawing.Size(66, 13);
            this.accelLabel2.TabIndex = 12;
            this.accelLabel2.Text = "Acceleration";
            // 
            // spdLabel2
            // 
            this.spdLabel2.AutoSize = true;
            this.spdLabel2.Location = new System.Drawing.Point(18, 196);
            this.spdLabel2.Name = "spdLabel2";
            this.spdLabel2.Size = new System.Drawing.Size(38, 13);
            this.spdLabel2.TabIndex = 11;
            this.spdLabel2.Text = "Speed";
            // 
            // dirLabel2
            // 
            this.dirLabel2.AutoSize = true;
            this.dirLabel2.Location = new System.Drawing.Point(18, 155);
            this.dirLabel2.Name = "dirLabel2";
            this.dirLabel2.Size = new System.Drawing.Size(49, 13);
            this.dirLabel2.TabIndex = 10;
            this.dirLabel2.Text = "Direction";
            // 
            // motor2Clear
            // 
            this.motor2Clear.Location = new System.Drawing.Point(123, 370);
            this.motor2Clear.Name = "motor2Clear";
            this.motor2Clear.Size = new System.Drawing.Size(46, 23);
            this.motor2Clear.TabIndex = 9;
            this.motor2Clear.Text = "Clear";
            this.motor2Clear.UseVisualStyleBackColor = true;
            this.motor2Clear.Click += new System.EventHandler(this.motor2Clear_Click);
            // 
            // motor2Stop
            // 
            this.motor2Stop.Location = new System.Drawing.Point(72, 370);
            this.motor2Stop.Name = "motor2Stop";
            this.motor2Stop.Size = new System.Drawing.Size(47, 23);
            this.motor2Stop.TabIndex = 8;
            this.motor2Stop.Text = "Stop";
            this.motor2Stop.UseVisualStyleBackColor = true;
            this.motor2Stop.Click += new System.EventHandler(this.motor2Stop_Click);
            // 
            // motor2Start
            // 
            this.motor2Start.Location = new System.Drawing.Point(20, 370);
            this.motor2Start.Name = "motor2Start";
            this.motor2Start.Size = new System.Drawing.Size(48, 23);
            this.motor2Start.TabIndex = 7;
            this.motor2Start.Text = "Start";
            this.motor2Start.UseVisualStyleBackColor = true;
            this.motor2Start.Click += new System.EventHandler(this.motor2Start_Click);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(21, 330);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(148, 21);
            this.comboBox7.TabIndex = 6;
            // 
            // motor2Decel
            // 
            this.motor2Decel.FormattingEnabled = true;
            this.motor2Decel.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor2Decel.Location = new System.Drawing.Point(21, 294);
            this.motor2Decel.Name = "motor2Decel";
            this.motor2Decel.Size = new System.Drawing.Size(148, 21);
            this.motor2Decel.TabIndex = 5;
            // 
            // motor2Accel
            // 
            this.motor2Accel.FormattingEnabled = true;
            this.motor2Accel.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor2Accel.Location = new System.Drawing.Point(20, 253);
            this.motor2Accel.Name = "motor2Accel";
            this.motor2Accel.Size = new System.Drawing.Size(149, 21);
            this.motor2Accel.TabIndex = 4;
            this.motor2Accel.SelectedIndexChanged += new System.EventHandler(this.motor2Accel_SelectedIndexChanged);
            // 
            // motor2Spd
            // 
            this.motor2Spd.FormattingEnabled = true;
            this.motor2Spd.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor2Spd.Location = new System.Drawing.Point(20, 213);
            this.motor2Spd.Name = "motor2Spd";
            this.motor2Spd.Size = new System.Drawing.Size(149, 21);
            this.motor2Spd.TabIndex = 3;
            this.motor2Spd.SelectedIndexChanged += new System.EventHandler(this.motor2Spd_SelectedIndexChanged);
            // 
            // motor2Dir
            // 
            this.motor2Dir.FormattingEnabled = true;
            this.motor2Dir.Items.AddRange(new object[] {
            "Clockwise",
            "Counterclockwise"});
            this.motor2Dir.Location = new System.Drawing.Point(20, 172);
            this.motor2Dir.Name = "motor2Dir";
            this.motor2Dir.Size = new System.Drawing.Size(149, 21);
            this.motor2Dir.TabIndex = 2;
            this.motor2Dir.SelectedIndexChanged += new System.EventHandler(this.motor2Dir_SelectedIndexChanged);
            // 
            // motorBox2
            // 
            this.motorBox2.FormattingEnabled = true;
            this.motorBox2.Items.AddRange(new object[] {
            "Motor 1"});
            this.motorBox2.Location = new System.Drawing.Point(21, 13);
            this.motorBox2.Name = "motorBox2";
            this.motorBox2.Size = new System.Drawing.Size(148, 21);
            this.motorBox2.TabIndex = 1;
            this.motorBox2.SelectedIndexChanged += new System.EventHandler(this.motorBox2_SelectedIndexChanged);
            // 
            // motor2Desc
            // 
            this.motor2Desc.BackColor = System.Drawing.SystemColors.Window;
            this.motor2Desc.Location = new System.Drawing.Point(21, 35);
            this.motor2Desc.Multiline = true;
            this.motor2Desc.Name = "motor2Desc";
            this.motor2Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.motor2Desc.Size = new System.Drawing.Size(148, 117);
            this.motor2Desc.TabIndex = 0;
            this.motor2Desc.TextChanged += new System.EventHandler(this.motor2Desc_TextChanged);
            // 
            // motorPanelRight
            // 
            this.motorPanelRight.Controls.Add(this.decelLabel3);
            this.motorPanelRight.Controls.Add(this.accelLabel3);
            this.motorPanelRight.Controls.Add(this.spdLabel3);
            this.motorPanelRight.Controls.Add(this.dirLabel3);
            this.motorPanelRight.Controls.Add(this.motor3Clear);
            this.motorPanelRight.Controls.Add(this.motor3Stop);
            this.motorPanelRight.Controls.Add(this.motor3Start);
            this.motorPanelRight.Controls.Add(this.comboBox13);
            this.motorPanelRight.Controls.Add(this.motor3Decel);
            this.motorPanelRight.Controls.Add(this.motor3Accel);
            this.motorPanelRight.Controls.Add(this.motor3Spd);
            this.motorPanelRight.Controls.Add(this.motor3Dir);
            this.motorPanelRight.Controls.Add(this.motorBox3);
            this.motorPanelRight.Controls.Add(this.motor3Desc);
            this.motorPanelRight.Location = new System.Drawing.Point(625, 36);
            this.motorPanelRight.Name = "motorPanelRight";
            this.motorPanelRight.Size = new System.Drawing.Size(190, 410);
            this.motorPanelRight.TabIndex = 12;
            // 
            // decelLabel3
            // 
            this.decelLabel3.AutoSize = true;
            this.decelLabel3.Location = new System.Drawing.Point(18, 281);
            this.decelLabel3.Name = "decelLabel3";
            this.decelLabel3.Size = new System.Drawing.Size(67, 13);
            this.decelLabel3.TabIndex = 17;
            this.decelLabel3.Text = "Deceleration";
            // 
            // accelLabel3
            // 
            this.accelLabel3.AutoSize = true;
            this.accelLabel3.Location = new System.Drawing.Point(17, 237);
            this.accelLabel3.Name = "accelLabel3";
            this.accelLabel3.Size = new System.Drawing.Size(66, 13);
            this.accelLabel3.TabIndex = 15;
            this.accelLabel3.Text = "Acceleration";
            // 
            // spdLabel3
            // 
            this.spdLabel3.AutoSize = true;
            this.spdLabel3.Location = new System.Drawing.Point(18, 196);
            this.spdLabel3.Name = "spdLabel3";
            this.spdLabel3.Size = new System.Drawing.Size(38, 13);
            this.spdLabel3.TabIndex = 14;
            this.spdLabel3.Text = "Speed";
            // 
            // dirLabel3
            // 
            this.dirLabel3.AutoSize = true;
            this.dirLabel3.Location = new System.Drawing.Point(18, 155);
            this.dirLabel3.Name = "dirLabel3";
            this.dirLabel3.Size = new System.Drawing.Size(49, 13);
            this.dirLabel3.TabIndex = 13;
            this.dirLabel3.Text = "Direction";
            // 
            // motor3Clear
            // 
            this.motor3Clear.Location = new System.Drawing.Point(123, 370);
            this.motor3Clear.Name = "motor3Clear";
            this.motor3Clear.Size = new System.Drawing.Size(46, 23);
            this.motor3Clear.TabIndex = 9;
            this.motor3Clear.Text = "Clear";
            this.motor3Clear.UseVisualStyleBackColor = true;
            this.motor3Clear.Click += new System.EventHandler(this.motor3Clear_Click);
            // 
            // motor3Stop
            // 
            this.motor3Stop.Location = new System.Drawing.Point(72, 370);
            this.motor3Stop.Name = "motor3Stop";
            this.motor3Stop.Size = new System.Drawing.Size(47, 23);
            this.motor3Stop.TabIndex = 8;
            this.motor3Stop.Text = "Stop";
            this.motor3Stop.UseVisualStyleBackColor = true;
            this.motor3Stop.Click += new System.EventHandler(this.motor3Pause_Click);
            // 
            // motor3Start
            // 
            this.motor3Start.Location = new System.Drawing.Point(20, 370);
            this.motor3Start.Name = "motor3Start";
            this.motor3Start.Size = new System.Drawing.Size(48, 23);
            this.motor3Start.TabIndex = 7;
            this.motor3Start.Text = "Start";
            this.motor3Start.UseVisualStyleBackColor = true;
            this.motor3Start.Click += new System.EventHandler(this.motor3Start_Click);
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(21, 330);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(148, 21);
            this.comboBox13.TabIndex = 6;
            // 
            // motor3Decel
            // 
            this.motor3Decel.FormattingEnabled = true;
            this.motor3Decel.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor3Decel.Location = new System.Drawing.Point(21, 294);
            this.motor3Decel.Name = "motor3Decel";
            this.motor3Decel.Size = new System.Drawing.Size(148, 21);
            this.motor3Decel.TabIndex = 5;
            // 
            // motor3Accel
            // 
            this.motor3Accel.FormattingEnabled = true;
            this.motor3Accel.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor3Accel.Location = new System.Drawing.Point(20, 253);
            this.motor3Accel.Name = "motor3Accel";
            this.motor3Accel.Size = new System.Drawing.Size(149, 21);
            this.motor3Accel.TabIndex = 4;
            this.motor3Accel.SelectedIndexChanged += new System.EventHandler(this.motor3Accel_SelectedIndexChanged);
            // 
            // motor3Spd
            // 
            this.motor3Spd.FormattingEnabled = true;
            this.motor3Spd.Items.AddRange(new object[] {
            "0",
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.motor3Spd.Location = new System.Drawing.Point(20, 213);
            this.motor3Spd.Name = "motor3Spd";
            this.motor3Spd.Size = new System.Drawing.Size(149, 21);
            this.motor3Spd.TabIndex = 3;
            this.motor3Spd.SelectedIndexChanged += new System.EventHandler(this.motor3Spd_SelectedIndexChanged);
            // 
            // motor3Dir
            // 
            this.motor3Dir.FormattingEnabled = true;
            this.motor3Dir.Items.AddRange(new object[] {
            "Clockwise",
            "Counterclockwise"});
            this.motor3Dir.Location = new System.Drawing.Point(20, 172);
            this.motor3Dir.Name = "motor3Dir";
            this.motor3Dir.Size = new System.Drawing.Size(149, 21);
            this.motor3Dir.TabIndex = 2;
            this.motor3Dir.SelectedIndexChanged += new System.EventHandler(this.motor3Dir_SelectedIndexChanged);
            // 
            // motorBox3
            // 
            this.motorBox3.FormattingEnabled = true;
            this.motorBox3.Items.AddRange(new object[] {
            "Motor 1"});
            this.motorBox3.Location = new System.Drawing.Point(21, 13);
            this.motorBox3.Name = "motorBox3";
            this.motorBox3.Size = new System.Drawing.Size(148, 21);
            this.motorBox3.TabIndex = 1;
            this.motorBox3.SelectedIndexChanged += new System.EventHandler(this.motorBox3_SelectedIndexChanged);
            // 
            // motor3Desc
            // 
            this.motor3Desc.BackColor = System.Drawing.SystemColors.Window;
            this.motor3Desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.motor3Desc.Location = new System.Drawing.Point(21, 35);
            this.motor3Desc.Multiline = true;
            this.motor3Desc.Name = "motor3Desc";
            this.motor3Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.motor3Desc.Size = new System.Drawing.Size(148, 117);
            this.motor3Desc.TabIndex = 0;
            this.motor3Desc.TextChanged += new System.EventHandler(this.motor3Desc_TextChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 17;
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
            this.manualControlToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
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
            // calibrateMotorCheckList
            // 
            this.calibrateMotorCheckList.FormattingEnabled = true;
            this.calibrateMotorCheckList.Items.AddRange(new object[] {
            "Motor 1",
            "Motor 2",
            "Motor 3",
            "Motor 4",
            "Motor 5",
            "Motor 6",
            "Motor 7",
            "Motor 8",
            "Motor 9",
            "Motor 10",
            "Motor 11",
            "Motor 12",
            "Motor 13",
            "Motor 14"});
            this.calibrateMotorCheckList.Location = new System.Drawing.Point(22, 85);
            this.calibrateMotorCheckList.Name = "calibrateMotorCheckList";
            this.calibrateMotorCheckList.Size = new System.Drawing.Size(144, 199);
            this.calibrateMotorCheckList.TabIndex = 18;
            this.calibrateMotorCheckList.SelectedIndexChanged += new System.EventHandler(this.calibrationMotorChecklist_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Label1.Location = new System.Drawing.Point(46, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Calibration";
            this.Label1.Click += new System.EventHandler(this.calibrationLabel1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Motor Selection";
            this.label2.Click += new System.EventHandler(this.selectMotorCalibrationLabel1);
            // 
            // startCalibrationBtn
            // 
            this.startCalibrationBtn.Location = new System.Drawing.Point(38, 312);
            this.startCalibrationBtn.Name = "startCalibrationBtn";
            this.startCalibrationBtn.Size = new System.Drawing.Size(106, 23);
            this.startCalibrationBtn.TabIndex = 21;
            this.startCalibrationBtn.Text = "Start Calibration";
            this.startCalibrationBtn.UseVisualStyleBackColor = true;
            this.startCalibrationBtn.Click += new System.EventHandler(this.startCalibrationBtn_Click);
            // 
            // pauseCalibrationBtn
            // 
            this.pauseCalibrationBtn.Location = new System.Drawing.Point(38, 355);
            this.pauseCalibrationBtn.Name = "pauseCalibrationBtn";
            this.pauseCalibrationBtn.Size = new System.Drawing.Size(106, 23);
            this.pauseCalibrationBtn.TabIndex = 22;
            this.pauseCalibrationBtn.Text = "Pause Calibration";
            this.pauseCalibrationBtn.UseVisualStyleBackColor = true;
            this.pauseCalibrationBtn.Click += new System.EventHandler(this.pauseCalibrationBtn_Click);
            // 
            // stopCalibrationBtn
            // 
            this.stopCalibrationBtn.Location = new System.Drawing.Point(38, 397);
            this.stopCalibrationBtn.Name = "stopCalibrationBtn";
            this.stopCalibrationBtn.Size = new System.Drawing.Size(106, 23);
            this.stopCalibrationBtn.TabIndex = 23;
            this.stopCalibrationBtn.Text = "Stop Calibration";
            this.stopCalibrationBtn.UseVisualStyleBackColor = true;
            this.stopCalibrationBtn.Click += new System.EventHandler(this.stopCalibrationBtn_Click);
            // 
            // motor1FowardBox
            // 
            this.motor1FowardBox.AutoSize = true;
            this.motor1FowardBox.Checked = true;
            this.motor1FowardBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.motor1FowardBox.Location = new System.Drawing.Point(22, 330);
            this.motor1FowardBox.Name = "motor1FowardBox";
            this.motor1FowardBox.Size = new System.Drawing.Size(61, 17);
            this.motor1FowardBox.TabIndex = 18;
            this.motor1FowardBox.Text = "Foward";
            this.motor1FowardBox.UseVisualStyleBackColor = true;
            this.motor1FowardBox.CheckedChanged += new System.EventHandler(this.motor1FowardBox_CheckedChanged);
            // 
            // motor1BackwardsBox
            // 
            this.motor1BackwardsBox.AutoSize = true;
            this.motor1BackwardsBox.Location = new System.Drawing.Point(89, 330);
            this.motor1BackwardsBox.Name = "motor1BackwardsBox";
            this.motor1BackwardsBox.Size = new System.Drawing.Size(79, 17);
            this.motor1BackwardsBox.TabIndex = 19;
            this.motor1BackwardsBox.Text = "Backwards";
            this.motor1BackwardsBox.UseVisualStyleBackColor = true;
            this.motor1BackwardsBox.CheckedChanged += new System.EventHandler(this.motor1BackwardsBox_CheckedChanged);
            // 
            // ManualControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 477);
            this.Controls.Add(this.stopCalibrationBtn);
            this.Controls.Add(this.pauseCalibrationBtn);
            this.Controls.Add(this.startCalibrationBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.calibrateMotorCheckList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.motorPanelRight);
            this.Controls.Add(this.motorPanelCenter);
            this.Controls.Add(this.motorPanelLeft);
            this.Name = "ManualControlForm";
            this.Text = "Manual Control";
            this.Load += new System.EventHandler(this.ManualControlForm_Load);
            this.motorPanelLeft.ResumeLayout(false);
            this.motorPanelLeft.PerformLayout();
            this.motorPanelCenter.ResumeLayout(false);
            this.motorPanelCenter.PerformLayout();
            this.motorPanelRight.ResumeLayout(false);
            this.motorPanelRight.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //motor 1
        private System.Windows.Forms.TextBox motor1Desc;
        private System.Windows.Forms.ComboBox motorBox1;
        private System.Windows.Forms.ComboBox motor1Spd;
        private System.Windows.Forms.ComboBox motor1Accel;
        private System.Windows.Forms.ComboBox motor1Decel;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button motor1Start;
        private System.Windows.Forms.Button motor1Stop;
        private System.Windows.Forms.Button motor1Clear;
        private System.Windows.Forms.Panel motorPanelLeft;
        private System.Windows.Forms.Label spdLabel1;
        private System.Windows.Forms.Label accelLabel1;

        //motor2
        private System.Windows.Forms.Panel motorPanelCenter;
        private System.Windows.Forms.Button motor2Clear;
        private System.Windows.Forms.Button motor2Stop;
        private System.Windows.Forms.Button motor2Start;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox motor2Decel;
        private System.Windows.Forms.ComboBox motor2Accel;
        private System.Windows.Forms.ComboBox motor2Spd;
        private System.Windows.Forms.ComboBox motor2Dir;
        private System.Windows.Forms.ComboBox motorBox2;
        private System.Windows.Forms.TextBox motor2Desc;
        private System.Windows.Forms.Label accelLabel2;
        private System.Windows.Forms.Label spdLabel2;
        private System.Windows.Forms.Label dirLabel2;

        //motor3
        private System.Windows.Forms.Panel motorPanelRight;
        private System.Windows.Forms.Button motor3Clear;
        private System.Windows.Forms.Button motor3Stop;
        private System.Windows.Forms.Button motor3Start;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox motor3Decel;
        private System.Windows.Forms.ComboBox motor3Accel;
        private System.Windows.Forms.ComboBox motor3Spd;
        private System.Windows.Forms.ComboBox motor3Dir;
        private System.Windows.Forms.ComboBox motorBox3;
        private System.Windows.Forms.TextBox motor3Desc;
        private System.Windows.Forms.Label accelLabel3;
        private System.Windows.Forms.Label spdLabel3;
        private System.Windows.Forms.Label dirLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupMotorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox calibrateMotorCheckList;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startCalibrationBtn;
        private System.Windows.Forms.Button pauseCalibrationBtn;
        private System.Windows.Forms.Button stopCalibrationBtn;
        private System.Windows.Forms.Label decelLabel1;
        private System.Windows.Forms.Label decelLabel2;
        private System.Windows.Forms.Label decelLabel3;
        private System.Windows.Forms.CheckBox motor1BackwardsBox;
        private System.Windows.Forms.CheckBox motor1FowardBox;
    }
}