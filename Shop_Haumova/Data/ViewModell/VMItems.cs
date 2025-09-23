using Shop_Haumova.Data.Models;
using System.Collections.Generic;

namespace Shop_Haumova.Data.ViewModell
{
    public class VMItems
    {
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<Categorys> Categorys { get; set; }
        public int SelectCategory { get; set; }
    }
}
