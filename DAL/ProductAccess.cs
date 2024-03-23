using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductAccess
    {
        public DBAccessDAL db = new DBAccessDAL();
        public async Task<List<Product>> GetAllProduct()
        {
            return await db.Products.ToListAsync();
        }
    }
}
