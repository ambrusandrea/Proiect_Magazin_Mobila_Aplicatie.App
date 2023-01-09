using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Proiect_Magazin_Mobila_Aplicatie.Models;

namespace Proiect_Magazin_Mobila_Aplicatie.Data
{
    public class FavoriteListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public FavoriteListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<FavoriteList>().Wait();
        }
        public Task<List<FavoriteList>> GetShopListsAsync()
        {
            return _database.Table<FavoriteList>().ToListAsync();
        }
        public Task<FavoriteList> GetShopListAsync(int id)
        {
            return _database.Table<FavoriteList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveShopListAsync(FavoriteList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteShopListAsync(FavoriteList slist)
        {
            return _database.DeleteAsync(slist);
        }

    }
}
