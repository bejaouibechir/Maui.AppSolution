namespace Maui.App;

public partial class TestPage : ContentPage
{
	public TestPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new SecondPage());
    }
}