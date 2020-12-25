using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SharpDX.XInput;

namespace XboxControllerBattery
{
    public partial class MainForm : Form
    {
        private readonly IList<Controller> _controllers;
        private readonly IList<ControllerControl> _controls;

        public MainForm(IList<Controller> controllers)
        {
            InitializeComponent();

            _controllers = controllers;
            _controls = new List<ControllerControl>
            {
                ControllerControl0,
                ControllerControl1,
                ControllerControl2,
                ControllerControl3
            };

            for (var i = 0; i < _controls.Count; i++)
            {
                _controls[i].Controller = _controllers[i];
                _controls[i].SetIndex(i);
                _controls[i].UpdateControllerStatus();
            }

            BackColor = Color.FromArgb(64, 64, 64);
            VersionLabel.ForeColor = Color.FromArgb(96, 96, 96);
            CopyrightLabel.ForeColor = VersionLabel.ForeColor;

            Icon = Properties.Resources.xbox_battery_icon5;

            VersionLabel.Text = $"v{Application.ProductVersion.ToString()}";
        }

        private void FormLoad(object sender, EventArgs e)
        {
            RefreshTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (var control in _controls)
                {
                    control.UpdateControllerStatus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"XInput error, try installing the latest DirectX version from Microsoft's website.\n\n({ex.Message})", "XInput error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                Dispose();
            }
        }

        private void CopyrightLabel_MouseEnter(object sender, EventArgs e)
        {
            CopyrightLabel.Font = new Font(CopyrightLabel.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void CopyrightLabel_MouseLeave(object sender, EventArgs e)
        {
            CopyrightLabel.Font = new Font(CopyrightLabel.Font, FontStyle.Bold);
        }

        private void CopyrightLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://vbstudio.hu");
        }
    }
}