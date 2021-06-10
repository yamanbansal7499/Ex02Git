using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ex02_git_.Models;

namespace Ex02_git_.Data
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext (DbContextOptions<PlayerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ex02_git_.Models.Player> Player { get; set; }
    }
}
