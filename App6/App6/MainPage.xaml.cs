using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;

namespace App6
{
    [MarkupExtensionReturnType(ReturnType = typeof(UIElement))]
    public class ChildElementExtension : MarkupExtension
    {
        public ChildElementExtension()
        {
        }

        protected override object ProvideValue() => new TextBlock { Text = "asd" };
    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //var res = sp.Resources.Single();
        }
    }
}
