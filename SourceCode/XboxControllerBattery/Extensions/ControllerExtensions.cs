using SharpDX.XInput;

namespace XboxControllerBattery.Extensions
{
    public static class ControllerExtensions
    {
        public static void TrySetVibration(this Controller controller, short leftMotorSpeed, short rightMotorSpeed)
        {
            if (controller.IsConnected)
            {
                controller.SetVibration(new Vibration
                {
                    LeftMotorSpeed = leftMotorSpeed,
                    RightMotorSpeed = rightMotorSpeed
                });
            }
        }
    }
}