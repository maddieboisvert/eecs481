using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CS2DHololensApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VideoSelectionPage : Page
    {
        public VideoSelectionPage()
        {
            this.InitializeComponent();
        }

        private void vid1Thumb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VideoPage), "PqgKFsK7f-Q");
        }

        private void vid2Thumb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VideoPage), "4EEtubB74lM");
        }

        private void vid3Thumb_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VideoPage), "_t6-2CVwDCU");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.Frame.ForwardStack.Count > 0)
            {
                this.Frame.ForwardStack.RemoveAt(0);
            }
        }
    }
}
