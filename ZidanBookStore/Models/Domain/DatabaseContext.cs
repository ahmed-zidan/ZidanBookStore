using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZidanBookStore.Models.Domain
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {
                
        }

        public DbSet<Auther> authers { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Publisher> publishers { get; set; }
    }
}
