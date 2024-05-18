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
            //baemin
            if (btn.Tag.ToString() == "b1")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b1";
            }
            if (btn.Tag.ToString() == "b2")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b2";
            }
            if (btn.Tag.ToString() == "b3")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b3";
            }
            if (btn.Tag.ToString() == "b4")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b4";
            }
            if (btn.Tag.ToString() == "b5")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b5";
            }
            if (btn.Tag.ToString() == "b6")
            {
                url = "https://biz-member.baemin.com/login";
                tag = "b6";
            }
            //yogiyo
            if (btn.Tag.ToString() == "y1")
            {
                url = "https://ceo.yogiyo.co.kr/login/";
                tag = "y1";
            }
            if (btn.Tag.ToString() == "y2")
            {
                url = "https://ceo.yogiyo.co.kr/login/";
                tag = "y2";
            }
            if (btn.Tag.ToString() == "y3")
            {
                url = "https://ceo.yogiyo.co.kr/login/";
                tag = "y3";
            }
            if (btn.Tag.ToString() == "y4")
            {
                url = "https://ceo.yogiyo.co.kr/login/";
                tag = "y4";
            }
            if (btn.Tag.ToString() == "y5")
            {
                url = "https://ceo.yogiyo.co.kr/login/";
                tag = "y5";
            }
            //coupangeats
            if (btn.Tag.ToString() == "c1")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c1";
            }
            if (btn.Tag.ToString() == "c2")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c2";
            }
            if (btn.Tag.ToString() == "c3")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c3";
            }
            if (btn.Tag.ToString() == "c4")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c4";
            }
            if (btn.Tag.ToString() == "c5")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c5";
            }
            if (btn.Tag.ToString() == "c6")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c6";
            }
            if (btn.Tag.ToString() == "c7")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c7";
            }
            if (btn.Tag.ToString() == "c8")
            {
                url = "https://store.coupangeats.com/merchant/login";
                tag = "c8";
            }
            Webview webview = new Webview(url, tag);
            webview.ShowDialog();
        }
    }
}
