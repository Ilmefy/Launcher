using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Launcher.src.View
{
    public static class UIInteraction
    {
        public static void LightenOnMouseEnter(System.Windows.Controls.Label sender)
        {
            //   SolidColorBrush solidColorBrush = (SolidColorBrush)sender.Background;

            SolidColorBrush solidColorBrush = (SolidColorBrush)MainWindow.Instance.TopBar.Background;


            System.Drawing.Color c = ControlPaint.Light(System.Drawing.Color.FromArgb(solidColorBrush.Color.A, solidColorBrush.Color.R, solidColorBrush.Color.G, solidColorBrush.Color.B));
            sender.Background = new SolidColorBrush(Color.FromArgb(c.A, c.R, c.G, c.B));
        }
    }
}
