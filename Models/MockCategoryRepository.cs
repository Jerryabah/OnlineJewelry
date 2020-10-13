using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategory()
        {
            return new List<Category>()
            {

                new Category{CategoryId=1,CategoryName="Necklace", CategoryDescription = "multi-variety of pearls, leather and torquoise Necklaces"},
                new Category{CategoryId=2,CategoryName="Bracelet", CategoryDescription = "Finest quality of pearls, leather and torquoise Bracelets"},
                new Category{CategoryId=3,CategoryName="Earrings", CategoryDescription = "Finest quality of pearls, leather and torquoise Earrings"},
                //new Category{CategoryId=4,CategoryName="Silk Ribbon Bracelet", CategoryDescription = "Finest quality of pearls, leather and torquoise Silk Ribbon Bracelets"},
                //new Category{CategoryId=5,CategoryName="Anklet", CategoryDescription = "multi-variety of pearls, leather and torquoise Anklet"},
                //new Category{CategoryId=6,CategoryName="Ring", CategoryDescription = "Finest quality of pearls, leather and torquoise Ring"},

            };
        }

        public Category GetCategoryById(int idCategory)
        {
            return GetAllCategory().FirstOrDefault(c => c.CategoryId == idCategory);
        }
    }
}
