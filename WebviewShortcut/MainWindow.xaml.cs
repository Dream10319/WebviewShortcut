using System.Windows;
using System.Windows.Controls;

namespace WebviewShortcut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Go_Webview(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string url = "";
            string tag = "";
            if (btn.Content.ToString() == "Store management")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b1";
            }
            if (btn.Content.ToString() == "Temperarily suspended")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b2";
            }
            if (btn.Content.ToString() == "Menu discount management")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b3";
            }
            if (btn.Content.ToString() == "Review management")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b4";
            }
            if (btn.Content.ToString() == "Notice")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b5";
            }
            if (btn.Content.ToString() == "Order details")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b6";
            }
            Webview webview = new Webview(url, tag);
            webview.ShowDialog();
        }
    }
}
