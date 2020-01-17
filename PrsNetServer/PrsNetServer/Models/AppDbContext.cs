using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrsNetServer.Controllers;

namespace PrsNetServer.Models
    {
    public class AppDbContext : DbContext
        {
        public AppDbContext(DbContextOptions<AppDbContext> context)
            : base(context) { }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Request> Requests { get; set; }


        public AppDbContext() {

            }


        public DbSet<PrsNetServer.Controllers.Request> Request { get; set; }
        }
    }
