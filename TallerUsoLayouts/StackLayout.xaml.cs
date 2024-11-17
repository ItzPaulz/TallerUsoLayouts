

namespace TallerUsoLayouts;

public partial class StackLayout : ContentPage
{

    public StackLayout()
    {
        InitializeComponent();
    }

    private async void BotonPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayout());
    }
}