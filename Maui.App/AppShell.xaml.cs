namespace Maui.App;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
       
        //Table de routage
        
        Routing.RegisterRoute(nameof(MainPage),typeof(MainPage));
        Routing.RegisterRoute(nameof(ContactsPage),typeof(ContactsPage));
        Routing.RegisterRoute(nameof(TodoListPage),typeof(TodoListPage));
        Routing.RegisterRoute(nameof(ReminderPage),typeof(ReminderPage));
        Routing.RegisterRoute(nameof(DetailsPage),typeof(DetailsPage)); 
        //Equvalent à
        //Routing.RegisterRoute("MainPage", typeof(MainPage));
    }
}
