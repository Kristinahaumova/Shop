using Shop_Haumova.Data.Models;
using System.Collections.Generic;

namespace Shop_Haumova.Data.Interfaces
{
    public interface IItems
    {
        public IEnumerable<Items> AllItems { get; }
        public int Add(Items Item);
    }
}
