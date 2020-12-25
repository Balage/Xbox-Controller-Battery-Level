using System;
using System.Drawing;
using System.Windows.Forms;
using SharpDX.XInput;
using XboxControllerBattery.Extensions;

namespace XboxControllerBattery
{
    public partial class ControllerControl : UserControl
    {
        public Controller Controller { get; set; }

        private readonly Color ColorIdle = Color.FromArgb(64, 64, 64);
        private readonly Color ColorHover = Color.FromArgb(96, 96, 96);

        private bool _mouseHovering = false;


        public ControllerControl()
        {
            InitializeComponent();

            BackColor = ColorIdle;

            MouseEnter += MouseEnterEvent;
            MouseLeave += MouseLeaveEvent;
            Click += ClickEvent;

            foreach (Control control in Controls)
            {
                control.MouseEnter += MouseEnterEvent;
                control.MouseLeave += MouseLeaveEvent;
                control.Click += ClickEvent;
            }
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            if (Controller?.IsConnected ?? false)
            {
                BackColor = ColorHover;
            }
            _mouseHovering = true;
        }

        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            BackColor = ColorIdle;
            _mouseHovering = false;
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            if (Controller != null && !RubbleTimer.Enabled)
            {
                Controller.TrySetVibration(short.MaxValue, short.MaxValue);
                RubbleTimer.Enabled = true;
            }
        }

        private void RubbleTimer_Tick(object sender, EventArgs e)
        {
            RubbleTimer.Enabled = false;
            Controller.TrySetVibration(0, 0);
        }

        public void SetIndex(int index)
        {
            PlayerIndexIcon.Image = GetPlayerIndexIcon(index);
        }

        private Bitmap GetPlayerIndexIcon(int index)
        {
            switch (index)
            {
                case 0: return Properties.Resources.player0;
                case 1: return Properties.Resources.player1;
                case 2: return Properties.Resources.player2;
                case 3: return Properties.Resources.player3;
                default: return null;
            }
        }

        public void UpdateControllerStatus()
        {
            if (Controller == null)
                return;

            if (Controller.IsConnected)
            {
                var batteryInfo = Controller.GetBatteryInformation(BatteryDeviceType.Gamepad);

                StatusLabel.Text = GetBatteryTypeString(batteryInfo.BatteryType);

                switch (batteryInfo.BatteryType)
                {
                    case BatteryType.Wired:
                        BatteryIcon.Image = Properties.Resources.battery_wired;
                        break;

                    case BatteryType.Alkaline:
                    case BatteryType.Nimh:
                        BatteryIcon.Image = GetBatteryLevelIcon(batteryInfo.BatteryLevel);
                        break;

                    default:
                        BatteryIcon.Image = null;
                        break;
                }

                BackColor = _mouseHovering ? ColorHover : ColorIdle;
            }
            else
            {
                BackColor = ColorIdle;
                StatusLabel.Text = "Not connected";
                BatteryIcon.Image = null;
            }
        }

        private static string GetBatteryTypeString(BatteryType batteryType)
        {
            switch (batteryType)
            {
                case BatteryType.Wired: return "Wired";
                case BatteryType.Alkaline: return "Alkaline battery";
                case BatteryType.Nimh: return "Rechargeable battery";
                case BatteryType.Disconnected: return "Disconnected";
                case BatteryType.Unknown: return "Unknown";
                default: return "";
            }
        }

        private static Bitmap GetBatteryLevelIcon(BatteryLevel batteryLevel)
        {
            switch (batteryLevel)
            {
                case BatteryLevel.Full: return Properties.Resources.battery_full;
                case BatteryLevel.Medium: return Properties.Resources.battery_medium;
                case BatteryLevel.Low: return Properties.Resources.battery_low;
                case BatteryLevel.Empty: return Properties.Resources.battery_empty;
                default: return null;
            }
        }
    }
}