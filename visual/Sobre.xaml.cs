namespace hotel.Visual;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();

	}
	private async void btnSobre_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Sobre());
	}
}