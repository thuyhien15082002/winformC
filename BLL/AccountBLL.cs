using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        public AccountAccess accountAccess = new AccountAccess();
        public async Task<List<Account>> GetAllAccount()
        {
            return await accountAccess.GetAllAccount();
        }
        public async Task<bool> UpdateAcc(Account account)
        {
            return await accountAccess.UpdateAcc(account);
        }
        public async Task DeleteAccount(int id)
        {
             accountAccess.DeleteAccount(id);
        }
        public async Task<bool> AccExists(string AccountID)
        {
            return await accountAccess.AccExists(AccountID);
        }
    }
}
