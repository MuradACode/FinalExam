using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Feature> Features { get; set; }
        public DbSet<Hero> Hero { get; set; }
        public DbSet<AchivementTop> TopAchivements { get; set; }
        public DbSet<AchivementBottom> BottomAchivements { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        public DbSet<Settings> Settings { get; set; }
    }
}
