//#define shell
//#define mainpage
//#define newpage1
#define layout

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
#if layout
     MainPage = new LayoutPageDemo();
#endif

	}
}
