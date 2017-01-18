using System.Linq;
using FormsPlugin.Iconize;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace AppZed
{
	public class App:Application
	{
		public App()
		{
			var tabbedPage = new TabbedPage();
			tabbedPage.Children.Add(new OnePage { Title = "One", Icon="spanner" });
			tabbedPage.Children.Add(new TwoPage { Title = "Two" });
			tabbedPage.Children.Add(new ThreePage { Title = "Three" });
			MainPage = new IconNavigationPage(tabbedPage);
		}
	}
}
