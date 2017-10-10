namespace Proof_Productions
{
    partial class Form1
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
            this.clockwiseButton = new System.Windows.Forms.Button();
            this.counterclockwiseButton = new System.Windows.Forms.Button();
            this.estopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockwiseButton
            // 
            this.clockwiseButton.Location = new System.Drawing.Point(13, 13);
            this.clockwiseButton.Name = "clockwiseButton";
            this.clockwiseButton.Size = new System.Drawing.Size(159, 23);
            this.clockwiseButton.TabIndex = 0;
            this.clockwiseButton.Text = "Rotate clockwise";
            this.clockwiseButton.UseVisualStyleBackColor = true;
            this.clockwiseButton.Click += new System.EventHandler(this.ClockwiseClick);
            // 
            // counterclockwiseButton
            // 
            this.counterclockwiseButton.Location = new System.Drawing.Point(13, 43);
            this.counterclockwiseButton.Name = "counterclockwiseButton";
            this.counterclockwiseButton.Size = new System.Drawing.Size(159, 23);
            this.counterclockwiseButton.TabIndex = 1;
            this.counterclockwiseButton.Text = "Rotate counterclockwise";
            this.counterclockwiseButton.UseVisualStyleBackColor = true;
            this.counterclockwiseButton.Click += new System.EventHandler(this.CounterClockwiseClick);
            // 
            // estopButton
            // 
            this.estopButton.BackColor = System.Drawing.Color.Red;
            this.estopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estopButton.ForeColor = System.Drawing.Color.White;
            this.estopButton.Location = new System.Drawing.Point(213, 148);
            this.estopButton.Name = "estopButton";
            this.estopButton.Size = new System.Drawing.Size(176, 101);
            this.estopButton.TabIndex = 2;
            this.estopButton.Text = "EMERGENCY STOP";
            this.estopButton.UseVisualStyleBackColor = false;
            this.estopButton.Click += new System.EventHandler(this.EstopButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 261);
            this.Controls.Add(this.estopButton);
            this.Controls.Add(this.counterclockwiseButton);
            this.Controls.Add(this.clockwiseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clockwiseButton;
        private System.Windows.Forms.Button counterclockwiseButton;
        private System.Windows.Forms.Button estopButton;
    }
}

