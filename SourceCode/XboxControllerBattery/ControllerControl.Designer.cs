namespace XboxControllerBattery
{
    partial class ControllerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PlayerIndexIcon = new System.Windows.Forms.PictureBox();
            this.BatteryIcon = new System.Windows.Forms.PictureBox();
            this.RubbleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIndexIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(75, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(225, 84);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "StatusLabel";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerIndexIcon
            // 
            this.PlayerIndexIcon.Location = new System.Drawing.Point(5, 12);
            this.PlayerIndexIcon.Name = "PlayerIndexIcon";
            this.PlayerIndexIcon.Size = new System.Drawing.Size(60, 60);
            this.PlayerIndexIcon.TabIndex = 4;
            this.PlayerIndexIcon.TabStop = false;
            // 
            // BatteryIcon
            // 
            this.BatteryIcon.Location = new System.Drawing.Point(300, 0);
            this.BatteryIcon.Name = "BatteryIcon";
            this.BatteryIcon.Size = new System.Drawing.Size(119, 84);
            this.BatteryIcon.TabIndex = 2;
            this.BatteryIcon.TabStop = false;
            // 
            // RubbleTimer
            // 
            this.RubbleTimer.Interval = 300;
            this.RubbleTimer.Tick += new System.EventHandler(this.RubbleTimer_Tick);
            // 
            // ControllerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.PlayerIndexIcon);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BatteryIcon);
            this.Name = "ControllerControl";
            this.Size = new System.Drawing.Size(419, 84);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIndexIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatteryIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox BatteryIcon;
        public System.Windows.Forms.Label StatusLabel;
        public System.Windows.Forms.PictureBox PlayerIndexIcon;
        private System.Windows.Forms.Timer RubbleTimer;
    }
}
