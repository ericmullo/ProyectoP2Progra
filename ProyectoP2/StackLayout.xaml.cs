namespace ProyectoP2;

public partial class StackLayoutPage : ContentPage
{
    public StackLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnNavigateToFlexLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }
}
