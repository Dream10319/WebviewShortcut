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
            if (btn.Content.ToString() == "Store management")
            {
                url = "https://biz-member.baemin.com/login";
            }
            if (btn.Content.ToString() == "Temperarily suspended")
            {
                url = "https://freelancer.com";
            }
            Webview webview = new Webview(url);
            webview.ShowDialog();
        }
    }
}
