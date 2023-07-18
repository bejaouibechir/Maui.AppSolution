//#define shell
//#define mainpage
#define newpage1

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
#if newpage1
     MainPage = new NewPage1();
#endif
	}
}
