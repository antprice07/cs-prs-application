using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrsNetServer.Models {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> context)
            : base(context) { }

        public virtual DbSet<User> Users { get; set; }

        public AppDbContext() {

            }
        }
    }
