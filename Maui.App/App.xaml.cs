//#define shell
//#define mainpage
//#define naviguation
//#define flyout
//#define tabbed
#define passparameter


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
		//C'est un cas qui traite le passage des paramètres
		//d'une page à une autre
#if passparameter
		MainPage = new AppShell();
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
#if tabbed
		MainPage = new TabbedPageDemo();
#endif


    }
}
