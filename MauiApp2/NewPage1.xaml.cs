namespace MauiApp2;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();


	}

    private void btnAperte_Clicked(object sender, EventArgs e)
    {
        var nome = txtNome.Text;

        lblCampo.Text = $"Seu nome é {nome}";


    }

    private void btnVoltar1_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}