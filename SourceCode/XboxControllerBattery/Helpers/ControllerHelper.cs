using SharpDX.XInput;

namespace XboxControllerBattery.Helpers
{
    public static class ControllerHelper
    {
        public static Controller[] InitAndGetControllers()
        {
            return new Controller[]
            {
                new Controller(UserIndex.One),
                new Controller(UserIndex.Two),
                new Controller(UserIndex.Three),
                new Controller(UserIndex.Four)
            };
        }
    }
}