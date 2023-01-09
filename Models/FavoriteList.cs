using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Proiect_Magazin_Mobila_Aplicatie.Models
{
    public class FavoriteList
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        [MaxLength(250), Unique]
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
