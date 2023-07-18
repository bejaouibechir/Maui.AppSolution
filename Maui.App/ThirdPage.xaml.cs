namespace Maui.App;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//C'est incorrect
		//Navigation.PushAsync(new SecondPage());
		//C'est correct
		Navigation.PopAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		//Naviguation vers la page initiale
		//Retour direct de la troisième page vers la page initiale
		Navigation.PopToRootAsync();
    }
}