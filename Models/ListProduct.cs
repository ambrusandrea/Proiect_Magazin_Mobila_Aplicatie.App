using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Proiect_Magazin_Mobila_Aplicatie.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(FavoriteList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}
