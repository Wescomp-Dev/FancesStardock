using System.Windows.Forms;

namespace NoFences.Model
{

    public class ScreenWin
    {
        public static int PixelScreen = Screen.PrimaryScreen.BitsPerPixel;

        public static int WidthScreen = Screen.PrimaryScreen.Bounds.Width;

        public static int HeigthScreen = Screen.PrimaryScreen.Bounds.Height;
    }

}
