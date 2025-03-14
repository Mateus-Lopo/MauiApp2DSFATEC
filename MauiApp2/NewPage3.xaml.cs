namespace MauiApp2;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private void txtGasolina_Completed(object sender, EventArgs e)
    {
		if(txtGasolina.Text?.Length > 0)
		{
			imgResultado.Source = ImageSource.FromFile("gasolina.png");
		}
		else
		{
			imgResultado.Source = ImageSource.FromFile("etanol.png");
		}
    }

    private void btnCalc_Clicked(object sender, EventArgs e)
    {
		string etanol = txtAlcool.Text;
		string gaso = txtGasolina.Text;

		if(double.TryParse(etanol, out double precoAlcool) && double.TryParse(gaso, out double presoGaso))
		{
			double conta = precoAlcool / presoGaso;

			if(conta <= 0.7)
			{
				lblResultado.Text = "Abasteça com Etanol";
				imgResultado.Source = "etanol.png";
			}
			else
			{
				lblResultado.Text = "Abasteça com gasolina";
				imgResultado.Source = "gasolina.png";
			}
		}
		else
		{
			lblResultado.Text = "Coloque algo correto";
		}
    }

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}