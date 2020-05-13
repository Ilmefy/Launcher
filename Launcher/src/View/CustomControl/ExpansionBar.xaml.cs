using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Launcher.src.View.CustomControl
{
    /// <summary>
    /// Logika interakcji dla klasy ExpansionBar.xaml
    /// </summary>
    public partial class ExpansionBar : UserControl
    {
        public ExpansionBar()
        {
            InitializeComponent();
        }

        private void Container_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var LastPosition = scrollViewer.VerticalOffset;
            var ExpansionButtonHeight = VanillaButton.ActualHeight;
            //Scrolling Up


            if (e.VerticalChange < 0)
            {
                scrollViewer.ScrollToVerticalOffset(LastPosition - ExpansionButtonHeight);
            }
            //Scrolling Down
            else
            {
                scrollViewer.ScrollToVerticalOffset(LastPosition + ExpansionButtonHeight);
            }
            //if (ItemInScrollViewerVisible(VanillaButton))
            //{
            //    TopScrollDirectionIndicator.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    //TopScrollDirectionIndicator.Visibility = Visibility.Visible;
            //}
            //if (ItemInScrollViewerVisible(BFAButton))
            //{
            //    //BottomScrollDirectionIndicator.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    //BottomScrollDirectionIndicator.Visibility = Visibility.Visible;
            //}
        }
        private bool ItemInScrollViewerVisible(ExpansionButton expansionButton)
        {
            GeneralTransform childTransform = expansionButton.TransformToAncestor(scrollViewer);

            Rect rectangle = childTransform.TransformBounds(new Rect(new Point(0, 0), expansionButton.RenderSize));

            Rect result = Rect.Intersect(new Rect(new Point(0, 0), scrollViewer.RenderSize), rectangle);
            //Not visible
            if (result == Rect.Empty)
            {
                //ScrollDirectionIndicator.Visibility = Visibility.Visible;
                return false;
            }
            else
            {
                return true;
                //  ScrollDirectionIndicator.Visibility = Visibility.Hidden;
            }
        }
    }
}
