namespace MauiApp2;

public class CodigoPage : ContentPage
{
	public CodigoPage()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { 
					HorizontalOptions = LayoutOptions.End, 
					VerticalOptions = LayoutOptions.Start, 
					Text = "Bem vindo ao"
				},
				new Label
				{
					HorizontalOptions = LayoutOptions.End,
					VerticalOptions = LayoutOptions.End,
					Text = "ao .NET MAUI"
				}
			}
		};
	}
}