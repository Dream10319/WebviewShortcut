using CefSharp;
using CefSharp.Wpf;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;

namespace WebviewShortcut
{
    /// <summary>
    /// Interaction logic for Webview.xaml
    /// </summary>
    public partial class Webview : Window
    {
        
        public Webview(string url)
        {
            InitializeComponent();

            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/Resources/loading.gif");
            image.EndInit();
            ImageBehavior.SetAnimatedSource(loadingImage, image);

            Browser.Address = url;
            
            Dispatcher.InvokeAsync(async () =>
            {
                await Task.Delay(2000); // Delay to ensure all elements are loaded
                // JavaScript to fill the form and click the login button
                string script = "";
                if (Browser.Address == "https://biz-member.baemin.com/login")
                {
                    string username = "Yang8034";
                    string password = "Yhs1137@";
                    script = $@"
                        document.querySelector('input[data-testid=""id""]').value = '{username}';
                        document.querySelector('input[data-testid=""password""]').value = '{password}';
                        document.querySelector('button.Button__StyledButton-sc-1cxc4dz-0.hlLPsc').click();
                    ";
                    Browser.ExecuteScriptAsync(script);
                    await Task.Delay(2000);
                    Browser.Address = "https://self.baemin.com/shops/basic";
                    Browser.Visibility = Visibility.Visible;
                    loadingImage.Visibility = Visibility.Hidden;
                }
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            Browser.Dispose();
            Cef.GetGlobalCookieManager().DeleteCookies("", "");
            base.OnClosed(e);
        }
    }
}
