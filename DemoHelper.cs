using System.Threading;

namespace WorkRoad
{
    internal class DemoHelper
    {
        public static void Pause(int secondsToPause = 7000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}