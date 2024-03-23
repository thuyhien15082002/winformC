using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL 
    {

        CategoryAccess categoryAccess = new CategoryAccess();
        public async Task<List<Category>> GetAllCategories()
        {
            return await categoryAccess.GetAllCategories();
        }

        public async Task<bool> InsertCategory(Category category)
        {
            return await categoryAccess.InsertCategory(category);
        }

        public async Task DeleteCategory(int id)
        {
            await categoryAccess.DeleteCategory(id);
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            return await categoryAccess.UpdateCategory(category);
        }

        public async Task<bool> CategoryExists(string categoryId)
        {
            return await categoryAccess.CategoryExists(categoryId);
        }
    }
}
