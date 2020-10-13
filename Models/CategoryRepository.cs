using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _appDbContext.Categories;
        }

        public Category GetCategoryById(int idCategory)
        {
            return _appDbContext.Categories.FirstOrDefault(c => c.CategoryId == idCategory);
        }
    }
}
