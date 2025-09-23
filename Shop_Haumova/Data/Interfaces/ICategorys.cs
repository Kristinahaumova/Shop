using Shop_Haumova.Data.Models;
using System.Collections.Generic;

namespace Shop_Haumova.Data.Interfaces
{
    public interface ICategorys
    {
        public IEnumerable<Categorys> AllCategorys { get; }
    }
}
