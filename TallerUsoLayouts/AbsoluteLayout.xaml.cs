namespace TallerUsoLayouts;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private async void BotonPage4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayout());
    }
}