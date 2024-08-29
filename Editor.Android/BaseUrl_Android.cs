using HEditor.Droid;
using Xamarin.Forms;
using static Editor.Page1;


[assembly: Dependency(typeof(BaseUrl_Android))]
namespace HEditor.Droid    // пространство имен может отличаться
{
    public class BaseUrl_Android : IBaseUrl
        {
            public string Get()
            {
                return "file:///android_asset/";
            }
        }
    }
