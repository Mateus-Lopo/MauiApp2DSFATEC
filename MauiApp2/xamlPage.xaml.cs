namespace MauiApp2;

public partial class xamlPage : ContentPage
{
	public xamlPage()
	{
		InitializeComponent();
	}

    private void btnVoltar2_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}