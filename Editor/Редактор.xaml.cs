using System;
using System.IO;
using Xamarin.Forms;

namespace Editor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void PreviewButton_Clicked(object sender, EventArgs e)
        {
            string htmlContent = htmlEditor.Text;
            var webViewPage = new WebViewPage(htmlContent);
            await Navigation.PushModalAsync(new NavigationPage(webViewPage));
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            string htmlContent = htmlEditor.Text;

            // Сохранение HTML-контента в файл
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "savedFile.html");
            File.WriteAllText(filePath, htmlContent);

            await DisplayAlert("Файл сохранен", "HTML-контент был сохранен как файл", "OK");
        }

        public class WebViewPage : ContentPage
        {
            public WebViewPage(string htmlContent)
            {
                NavigationPage.SetHasNavigationBar(this, true);

                var webView = new WebView
                {
                    Source = new HtmlWebViewSource { Html = htmlContent },
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };

                // Add WebView to the ContentPage
                Content = webView;
            }
        }
    }
}

