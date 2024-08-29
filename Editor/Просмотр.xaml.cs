using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Editor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            {
                WebView webView = new WebView();
                UrlWebViewSource urlSource = new UrlWebViewSource();
                urlSource.Url = System.IO.Path.Combine(DependencyService.Get<IBaseUrl>().Get(), "Ret.html");
                webView.Source = urlSource;
                this.Content = webView;
            }
        }

        public interface IBaseUrl { string Get(); }
    }
}