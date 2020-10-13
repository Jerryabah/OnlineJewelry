using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public class MockJewelryRepository : IJewelryRepository
    {
        private readonly ICategoryRepository _category = new MockCategoryRepository();
        public IEnumerable<Jewelry> GetAllJewelry()
        {
            return new List<Jewelry>()
            {
                new Jewelry {JewelryId = 1, Name = "Floating Champagne Freshwater Pearl Necklace-1", Price = 46.00M,
                Description = "…..Simplicity is often the most beautiful. This is perfectly seen in this Floating Pearl necklace. " +
                "Single strand of a natural Greek leather, with one floating pearl. Center Pearl is large, measures 12mm. " +
                "Closure pearl measures 11mm. Can be worn with one pearl in front (pictures 1 and 2 ) or both pearls in front as shown in (picture 3 and 4 ). " +
                "Necklace measures 16\". \nGreat piece for this Summer!",
                Category = _category.GetCategoryById(1),
                ImageUrl= "https://i.etsystatic.com/6031807/r/il/6b31f9/1044034963/il_794xN.1044034963_9ljc.jpg",
                IsInStock=true, ImageThumbnailUrl = "https://i.etsystatic.com/6031807/r/il/2659c9/997536070/il_794xN.997536070_mlhl.jpg"},
            new Jewelry {JewelryId = 2, Name = "Black Baroque Pearl Bracelet", Price = 71.00M,
                Description = "Dark,iridescent Peacock Baroque PEARL Bracelet , these pearls are perfect in their imperfections." +
                "Knotted on rich brown leather, with a little space between. Finished off with a round, black, cultured pearl." +
                "Bracelet measures 7 .5\". Pearls measure 22.30 x 13.5 mm.",
                Category = _category.GetCategoryById(2),
                ImageUrl="https://i.etsystatic.com/6031807/r/il/a58548/1783575821/il_794xN.1783575821_orm4.jpg",
                IsInStock=true, ImageThumbnailUrl = "https://i.etsystatic.com/6031807/r/il/595804/1783575633/il_794xN.1783575633_fhvt.jpg"},
            new Jewelry {JewelryId = 3, Name = "TRIPLE TEAR DROP Leather & Green Pistachio Pearls Earrings", Price = 49.00M,
                Description = "Classy & flashy, 3 elegant Freshwater Pistachio Pearls on each earring, dropping down & perfectly positioned on natural Greek leather. " +
                "These Earrings hang approximately 3\" from the 14 kt gold-filled ear wires. The pearls measure 7.5” mm. These are great earrings for any outfit. " +
                "Dress them up for a night out, or out &about with your t - shirt and jeans.",
                Category = _category.GetCategoryById(3),
                ImageUrl="https://i.etsystatic.com/6031807/r/il/d3d079/2279020068/il_794xN.2279020068_pm1c.jpg",
                IsInStock=false, ImageThumbnailUrl = "https://i.etsystatic.com/6031807/r/il/72ac81/2279020042/il_794xN.2279020042_303o.jpg"},

            };
        }

        public Jewelry GetJewelryById(int idjewelry)
        {
            return GetAllJewelry().FirstOrDefault(j => j.JewelryId == idjewelry);
        }
    }
}
