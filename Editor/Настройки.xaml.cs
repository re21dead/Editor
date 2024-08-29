

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Editor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
                Switch javascriptSwitch = new Switch
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };

                javascriptSwitch.Toggled += (sender, e) =>
                {
                    bool isJavascriptEnabled = javascriptSwitch.IsToggled;

                    if (isJavascriptEnabled)
                    {
                        // Включить JavaScript
                    }
                    else
                    {
                        // Выключить JavaScript
                    }
                };

                Content = new StackLayout
                {
                    Children = { javascriptSwitch }
                };
            }
        }
    }