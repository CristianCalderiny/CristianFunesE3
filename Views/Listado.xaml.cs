namespace PM2E3ALEKS.Views;
using PM2E3ALEKS.Controllers;
using PM2E3ALEKS.Models;
using System.Windows.Input;
public partial class Listado : ContentPage
{
	public Listado()
	{
		InitializeComponent();
	}
    //
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        viewListado.Header = "Cargando...";
        viewListado.ItemsSource = await App.db.SelectAll();
        viewListado.Header = string.Empty;
    }
    //
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Notas nota = args.SelectedItem as Notas;
        await Navigation.PushAsync(new Detalle(nota));
    }
}