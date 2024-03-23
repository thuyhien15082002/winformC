using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryAccess
    {

        public DBAccessDAL db = new DBAccessDAL();
        public async Task<List<Category>> GetAllCategories()
        {
            return await db.Categories.ToListAsync();
        }
        

        public async Task DeleteCategory(int id)
        {
           
                var categoryToDelete = await db.Categories.FindAsync(id);

                if (categoryToDelete != null)
                {
                    db.Categories.Remove(categoryToDelete);
                    Console.WriteLine($"Removed category {categoryToDelete.CategoryID}");

                    await db.SaveChangesAsync();
                }
            
        }


        public async Task<bool> InsertCategory(Category category)
        {
            //using (var dbContext = new DBAccessDAL())
            //{
                
                var existingCategory = await db.Categories.FirstOrDefaultAsync(c => c.CategoryID == category.CategoryID);

                if (existingCategory != null)
                {
                   
                    return false;
                }
                db.Categories.Add(category);    
                await db.SaveChangesAsync();

                return true; 
            //}
        }


        public async Task<bool> UpdateCategory(Category category)
        {
            //using (var dbContext = new DBAccessDAL())
            //{
                var cate = await db.Categories.FirstOrDefaultAsync(c => c.CategoryID == category.CategoryID);

                if (cate != null)
                {
                    cate.CategoryName = category.CategoryName;
                    cate.Description = category.Description;

                    await db.SaveChangesAsync();
                    return true;
                }

                return false; 
            //}
        }

        // Trong lớp categoryBLL
        public async Task<bool> CategoryExists(string categoryId)
        {
            try
            {
                // Sử dụng phương thức từ DBAccessDAL hoặc ORM của bạn để kiểm tra sự tồn tại
                Category existingCategory = await db.Categories.FirstOrDefaultAsync(c => c.CategoryID == categoryId);

                return existingCategory != null;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                throw new Exception($"Lỗi khi kiểm tra sự tồn tại của danh mục: {ex.Message}");
            }
        }





    }
}
