namespace XboxControllerBattery
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.ControllerControl3 = new XboxControllerBattery.ControllerControl();
            this.ControllerControl2 = new XboxControllerBattery.ControllerControl();
            this.ControllerControl1 = new XboxControllerBattery.ControllerControl();
            this.ControllerControl0 = new XboxControllerBattery.ControllerControl();
            this.SuspendLayout();
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyrightLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.Gray;
            this.CopyrightLabel.Location = new System.Drawing.Point(5, 349);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(287, 20);
            this.CopyrightLabel.TabIndex = 4;
            this.CopyrightLabel.Text = "Copyright 2019 Balázs Vecsey, www.vbstudio.hu";
            this.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyrightLabel.Click += new System.EventHandler(this.CopyrightLabel_Click);
            this.CopyrightLabel.MouseEnter += new System.EventHandler(this.CopyrightLabel_MouseEnter);
            this.CopyrightLabel.MouseLeave += new System.EventHandler(this.CopyrightLabel_MouseLeave);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VersionLabel.ForeColor = System.Drawing.Color.Gray;
            this.VersionLabel.Location = new System.Drawing.Point(298, 349);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(136, 20);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "VersionLabel";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 500;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // ControllerControl3
            // 
            this.ControllerControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControllerControl3.Controller = null;
            this.ControllerControl3.Location = new System.Drawing.Point(10, 262);
            this.ControllerControl3.Name = "ControllerControl3";
            this.ControllerControl3.Size = new System.Drawing.Size(419, 84);
            this.ControllerControl3.TabIndex = 3;
            // 
            // ControllerControl2
            // 
            this.ControllerControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControllerControl2.Controller = null;
            this.ControllerControl2.Location = new System.Drawing.Point(10, 178);
            this.ControllerControl2.Name = "ControllerControl2";
            this.ControllerControl2.Size = new System.Drawing.Size(419, 84);
            this.ControllerControl2.TabIndex = 2;
            // 
            // ControllerControl1
            // 
            this.ControllerControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControllerControl1.Controller = null;
            this.ControllerControl1.Location = new System.Drawing.Point(10, 94);
            this.ControllerControl1.Name = "ControllerControl1";
            this.ControllerControl1.Size = new System.Drawing.Size(419, 84);
            this.ControllerControl1.TabIndex = 1;
            // 
            // ControllerControl0
            // 
            this.ControllerControl0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControllerControl0.Controller = null;
            this.ControllerControl0.Location = new System.Drawing.Point(10, 10);
            this.ControllerControl0.Name = "ControllerControl0";
            this.ControllerControl0.Size = new System.Drawing.Size(419, 84);
            this.ControllerControl0.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 370);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ControllerControl3);
            this.Controls.Add(this.ControllerControl2);
            this.Controls.Add(this.ControllerControl1);
            this.Controls.Add(this.ControllerControl0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xbox Controller Battery Level";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private ControllerControl ControllerControl0;
        private ControllerControl ControllerControl1;
        private ControllerControl ControllerControl2;
        private ControllerControl ControllerControl3;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Timer RefreshTimer;
    }
}

