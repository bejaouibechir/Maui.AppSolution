namespace Maui.App;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Titre", "Le contenu du ticket", "OK");
    }
}





