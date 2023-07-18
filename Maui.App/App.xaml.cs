//#define shell
//#define mainpage
//#define naviguation
#define flyout


namespace Maui.App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if shell
		MainPage = new AppShell();
#endif

#if mainpage
      MainPage = new MainPage();
#endif

#if naviguation
     var navpage = new NavigationPage(new MainPage { Title ="Home"});
        navpage.Title = "Home";
		navpage.BarTextColor = Colors.Gold;
		navpage.BarBackgroundColor = Colors.Red;
     MainPage = navpage;
#endif

#if flyout
   MainPage = new FlyoutPageDemo();
#endif


	}
}
