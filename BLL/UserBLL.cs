using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        UserAccess userAccess = new UserAccess();
        public async Task<List<User>> GetAllUser()
        {
            return await userAccess.GetAllUser();
        }

        public async Task<bool> InsertUser(User user)
        {
            return await userAccess.InsertUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await userAccess.DeleteUser(id);
        }

        public async Task<bool> UpdateUser(User user)
        {
            return await userAccess.UpdateUser(user);
        }

        public async Task<bool> UserExists(string UserId)
        {
            return await userAccess.UserExists(UserId);
        }

    } 
}
