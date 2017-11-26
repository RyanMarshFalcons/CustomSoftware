using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvd.Data.Model
{
    public enum MovieGenre { Action, Comedy, Documentary, Drama, Family, Horror, Mystery, Thriller, War, Western};
    public class DVD
    {
        public int DVD_ID { get; set; }
        public string Title { get; set; }
        public MovieGenre Genre { get; set; }
        public int QuantityInStock { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsDeleted { get; set; }
    }
}
