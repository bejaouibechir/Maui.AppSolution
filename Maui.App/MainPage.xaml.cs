namespace Maui.App;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

	}

    int id = 0; 

    async private void Button_Clicked(object sender, EventArgs e)
    {
        bool result = int.TryParse(entryId.Text, out id);
        if (result == false) id = 1;

        await Shell.Current.GoToAsync($"DetailsPage?Id={id}");


    }
}





