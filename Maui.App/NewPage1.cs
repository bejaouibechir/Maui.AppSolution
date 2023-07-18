namespace Maui.App;

public class NewPage1 : ContentPage
{
	public NewPage1()
	{
		Button myButton = new Button
		{
          Text = "Cliquez moi svp!!!",
		  Background =Colors.Red,
		  TextColor = Colors.White,
        };
		Label myLabel = new Label
		{ 
			Text = "Ce ci est une application MAUI" ,
			TextColor = Colors.Gold,
		};

		VerticalStackLayout mainLayout = new VerticalStackLayout
		{ 
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
		};

		mainLayout.Children.Add(myLabel);
		mainLayout.Children.Add(myButton);

		myButton.Clicked += (sender, args) => //Expression lambda
		{
            DisplayAlert("Titre", "Le contenu du ticket", "OK");
        };

        Content = mainLayout;

	}

    
}