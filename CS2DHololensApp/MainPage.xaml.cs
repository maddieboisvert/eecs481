using CS2DHololensApp.Common;
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
using Windows.Storage;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CS2DHololensApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel = new MainPageViewModel();

        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = ViewModel;

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string videoID = "PqgKFsK7f-Q";
            string html = @"<iframe width=""700"" height=""395"" src=""https://www.youtube.com/embed/PqgKFsK7f-Q?rel=0&autoplay=1"" frameborder=""0"" allowfullscreen></iframe>";
            HtmlBox.Text = html;
            LoadAsHtml();
        }

        private void LoadAsHtml()
        {
            WebViewControl.NavigateToString(HtmlBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ClickCount++;
        }
    }


    public class MainPageViewModel : BindableBase
    {
        private int _clickCount;
        public int ClickCount
        {
            get { return _clickCount; }
            set { SetProperty(ref _clickCount, value); }
        }
    }
}
