namespace MauiApp2;

public partial class NewPage2 : ContentPage
{
    int count = 0;
    public NewPage2()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void bntVoltar2_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}