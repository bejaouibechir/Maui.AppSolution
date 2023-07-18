namespace Maui.App;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ThirdPage());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //Il faut s'assurer de la d�cision prise par le l'utilisateur
        Navigation.PopModalAsync();
    }

    /* Cette fonctionalit� permet d'inserer une page d'une mani�re exceptionelle
     * dans la pile des  pages
        */
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.InsertPageBefore(new TestPage(), this);
    }
}