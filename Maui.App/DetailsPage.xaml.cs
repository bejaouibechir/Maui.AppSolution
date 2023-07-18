namespace Maui.App;

[QueryProperty(nameof(UserId), "Id")]
public partial class DetailsPage : ContentPage
{
    public int UserId { get; set; } //1

    public People _people;
    public DetailsPage()
	{
		InitializeComponent();
        _people = new People();

		
	}


    private void loadInfo()
    {
        /*Select id,name,email,image from people where
           id = UserId
         */
        User current = _people.Where(u => u.Id == UserId)
            .FirstOrDefault();
        if (current == null)
        {
            return;
        }
        else
        {
            imgUser.Source = current.Image;
            lblId.Text = current.Id.ToString();
            lblName.Text = current.Name;
            lblEmail.Text = current.Email;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        loadInfo();
    }
}