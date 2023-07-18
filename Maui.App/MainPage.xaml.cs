namespace Maui.App;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new SecondPage());
    }

    /*Mode modal qui empêche la naviguation d'une manière oridinaire
      pour forcer l'utilisateur à prendre une décision quelquon que*/
    async private void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SecondPage());
    }
}





