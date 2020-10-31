using Core.Doman;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Context
{
    public class ApplicationContext  : DbContext
    {
        public DbSet<User> User { get; set; }

        public ApplicationContext (DbContextOptions options) : base(options)
        {
        }

        internal Task FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
