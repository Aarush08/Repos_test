using CMSShoppingCart.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSShoppingCart.Infrastructure
{
    public class CMSShoppingCartContext : DbContext
    {
        public CMSShoppingCartContext(DbContextOptions<CMSShoppingCartContext> options) : base(options)
        {
                        
        }

        //this way we can access the table columns 
        public DbSet<Page> Pages { get; set; }
    }
}
