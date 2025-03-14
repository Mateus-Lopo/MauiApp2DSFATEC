namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        

        

        private void btnBem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }

        private void btnFoto_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage2());
        }

        private void btncalc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage3());
        }

        private void btnCodigo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CodigoPage());
        }

        private void btnXaml_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new xamlPage());
        }
    }

}
