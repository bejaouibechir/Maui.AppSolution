namespace Maui.App;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += CollectionView_SelectionChanged;
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {
            Detail = new NavigationPage((Page)Activator
                .CreateInstance(item.TargetType));
            if (!((IFlyoutPageController)this).ShouldShowSplitMode)
                IsPresented = false;
        }
    }
}