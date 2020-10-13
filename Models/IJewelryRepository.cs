using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public interface IJewelryRepository
    {
        IEnumerable<Jewelry> GetAllJewelry();
        //IEnumerable<Jewelry> GetJewelryOnSale { get; }
        Jewelry GetJewelryById(int idjewelry);

    }
}
