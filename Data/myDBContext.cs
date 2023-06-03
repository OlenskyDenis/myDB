using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myDB.Models;

namespace myDB.Data
{
    public class myDBContext : DbContext
    {
        public myDBContext (DbContextOptions<myDBContext> options)
            : base(options)
        {
        }

        public DbSet<myDB.Models.Publication> Publication { get; set; } = default!;
    }
}
