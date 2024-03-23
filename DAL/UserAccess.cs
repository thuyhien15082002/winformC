using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAccess
    {
        public DBAccessDAL db = new DBAccessDAL();
        public async Task<List<User>> GetAllUser()
        {
            return await db.Users.ToListAsync();
        }


        public async Task DeleteUser(int id)
        {

            var UserToDelete = await db.Users.FindAsync(id);

            if (UserToDelete != null)
            {
                db.Users.Remove(UserToDelete);
                Console.WriteLine($"Removed User {UserToDelete.UserID}");

                await db.SaveChangesAsync();
            }

        }


        public async Task<bool> InsertUser(User user)
        {
            //using (var dbContext = new DBAccessDAL())
            //{

            var existingUser = await db.Users.FirstOrDefaultAsync(c => c.UserID == user.UserID);

            if (existingUser != null)
            {

                return false;
            }
            db.Users.Add(user);
            await db.SaveChangesAsync();

            return true;
            //}
        }


        public async Task<bool> UpdateUser(User user)
        {
            
            var users = await db.Users.FirstOrDefaultAsync(c => c.UserID == user.UserID);

            if (users != null)
            {
                users.UserName = user.UserName;
                users.Password = user.Password;
                users.Role = user.Role;
                


                await db.SaveChangesAsync();
                return true;
            }

            return false;
            
        }

        // Trong lớp UserBLL
        public async Task<bool> UserExists(string UserId)
        {
            try
            {
                // Sử dụng phương thức từ DBAccessDAL hoặc ORM của bạn để kiểm tra sự tồn tại
                User existingUser = await db.Users.FirstOrDefaultAsync(c => c.UserID == UserId);

                return existingUser != null;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                throw new Exception($"Lỗi khi kiểm tra sự tồn tại của danh mục: {ex.Message}");
            }
        }
    }

}

