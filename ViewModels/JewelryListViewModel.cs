using OnlineJewelry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.ViewModels
{
    public class JewelryListViewModel
    {
        public IEnumerable<Jewelry> Jewelries { get; set; }
    }
}
