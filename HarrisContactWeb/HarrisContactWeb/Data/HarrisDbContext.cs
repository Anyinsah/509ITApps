using HarrisContactWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Data
{
    public class HarrisDbContext : DbContext // HarrisDbContext which inherits objects from DbContext.
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options) // Method that passes through the context options of HarrisDbContext and assignes them options
        {
        }

        public DbSet<PersonalContact> personalContacts { get; set; } // Get and set products set to personalContacts class
        public DbSet<BusinessContact> businessContacts { get; set; } // Get and set products set to businessContacts class



    }
}
