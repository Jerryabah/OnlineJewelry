using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJewelry.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int idCategory);


    }
}
