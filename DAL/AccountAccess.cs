using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountAccess
    {
        public DBAccessDAL db = new DBAccessDAL();
        public async Task<List<Account>> GetAllAccount()
        {
            return await db.Accounts.ToListAsync();
        }
        public async Task DeleteAccount(int id)
        {
            var AccToDelete = await db.Accounts.FindAsync(id);

            if (AccToDelete != null)
            {
                db.Accounts.Remove(AccToDelete);
                Console.WriteLine($"Removed User {AccToDelete.AccountID}");

                await db.SaveChangesAsync();
            }
        }

        public async Task<bool> UpdateAcc( Account account)
        {
            var accounts = await db.Accounts.FirstOrDefaultAsync(c => c.AccountID == account.AccountID);

            if (accounts != null)
            {
                accounts.AccountName = account.AccountName;
                accounts.Phone = account.Phone;
                accounts.DateOfBirth = account.DateOfBirth;
                accounts.Gender = account.Gender;



                await db.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> AccExists(string AccountID)
        {
            try
            {
                // Sử dụng phương thức từ DBAccessDAL hoặc ORM của bạn để kiểm tra sự tồn tại
                Account existingAcc = await db.Accounts.FirstOrDefaultAsync(c => c.AccountID == AccountID);

                return existingAcc != null;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                throw new Exception($"Lỗi khi kiểm tra sự tồn tại của khách hàng: {ex.Message}");
            }
        }
    }
}
