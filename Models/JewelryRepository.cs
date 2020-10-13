using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public class JewelryRepository : IJewelryRepository
    {
        private readonly AppDbContext _appDbContext;
        public JewelryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Jewelry> GetAllJewelry()
        {
            return _appDbContext.Jewelries.Include(c=>c.Category);
        }

        public Jewelry GetJewelryById(int idjewelry)
        {
            return _appDbContext.Jewelries.FirstOrDefault(j=>j.JewelryId == idjewelry);
        }
    }
}
