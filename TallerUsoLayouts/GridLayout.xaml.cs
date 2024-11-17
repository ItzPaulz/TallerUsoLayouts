namespace TallerUsoLayouts;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private async void BotonPage1_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayout());
    }
}