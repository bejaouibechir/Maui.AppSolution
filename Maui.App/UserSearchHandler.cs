namespace Maui.App
{
    public class UserSearchHandler :SearchHandler
    {
        People _people;

        public People Users { get; set; }

        public UserSearchHandler() =>Users = new People();
        

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null; 
            } 
            else
            {
                ItemsSource = Users.Where(user=>user.Name.ToLower()
                .Contains(newValue.ToLower())).ToList();

            }
        }
        
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
            User current = item as User;
            await Shell.Current.DisplayAlert("Display user info",
                $"Id:{current.Id} Name={current.Name} Email={current.Email}", "OK");

        }


    }
}
