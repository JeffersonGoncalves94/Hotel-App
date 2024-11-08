
using MauiAppLogin.Models;
using Microsoft.Maui.Controls;

namespace hotel;

public partial class App : Application
{
	public List<Quarto> lista_quartos = new List<Quarto> 
	{
		new Quarto()
	{
		Descricao = "Suíte Super Luxo",
		ValorDiariaAdulto = 110.0,
		ValorDiariaCrianca = 55.0
	}, 
	new Quarto()
	{
		Descricao = "Suíte Luxo",
		ValorDiariaAdulto = 80.0,
		ValorDiariaCrianca = 40.0
	}, 
	new Quarto()
	{
		Descricao = "Suíte Single",
		ValorDiariaAdulto = 50,
		ValorDiariaCrianca = 25
	},
	new Quarto()
	{
		Descricao = "Suíte Crise",
		ValorDiariaAdulto = 25,
		ValorDiariaCrianca = 12.5
	},

	};

	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new hotel.visual.ContratacaoHospedagem());
	}
    protected override Window CreateWindow(IActivationState? activationState)
    {
		var Window = base.CreateWindow(activationState);
		Window.Width = 400;
		Window.Height = 600;

        return Window;
    }
}
