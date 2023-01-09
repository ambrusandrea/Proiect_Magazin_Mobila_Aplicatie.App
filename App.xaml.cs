using System;
using Proiect_Magazin_Mobila_Aplicatie.Data;
using System.IO;

namespace Proiect_Magazin_Mobila_Aplicatie;

public partial class App : Application
{
    static FavoriteListDatabase database;
    public static FavoriteListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               FavoriteListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShopList.db3"));
            }
            return database;
        }
    }

    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
