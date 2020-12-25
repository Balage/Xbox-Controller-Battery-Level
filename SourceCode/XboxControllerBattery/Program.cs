using System;
using System.Windows.Forms;
using SharpDX.XInput;
using XboxControllerBattery.Helpers;

namespace XboxControllerBattery
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller[] controllers;
            try
            {
                controllers = ControllerHelper.InitAndGetControllers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DirectX not found. This application needs DirectX 9 or newer installed on your computer.\n\n({ex.Message})", "DirectX not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm(controllers));
        }
    }
}