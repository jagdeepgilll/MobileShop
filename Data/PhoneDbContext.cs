using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobileShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Data
{
    public class PhoneDbContext : IdentityDbContext
    {
        // Adding tables we are using
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Configration> Configration { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public PhoneDbContext(DbContextOptions<PhoneDbContext> options)
            : base(options)
        {
        }
        public PhoneDbContext()
        {

        }
    }
}
