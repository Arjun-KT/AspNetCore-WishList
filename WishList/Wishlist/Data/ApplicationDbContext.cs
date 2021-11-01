using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Wishlist.Models;

namespace WishList.Wishlist.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Item> Item {get;set;} 

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
