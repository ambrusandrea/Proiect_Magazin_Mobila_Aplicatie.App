using Proiect_Magazin_Mobila_Aplicatie.Models;
namespace Proiect_Magazin_Mobila_Aplicatie;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var flist = (FavoriteList)BindingContext;
        flist.Date = DateTime.UtcNow;
        await App.Database.SaveFavoriteListAsync(flist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var flist = (FavoriteList)BindingContext;
        await App.Database.DeleteShopListAsync(flist);
        await Navigation.PopAsync();
    }
    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage((FavoriteList)
       this.BindingContext)
        {
            BindingContext = new Product()
        });

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var favoritel = (FavoriteList)BindingContext;

        listView.ItemsSource = await App.Database.GetListProductsAsync(favoritel.ID);
    }

}