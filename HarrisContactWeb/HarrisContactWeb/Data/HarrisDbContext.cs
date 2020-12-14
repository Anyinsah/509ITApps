using HarrisContactWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarrisContactWeb.Data
{
    public class HarrisDbContext : DbContext
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalContact> personalContacts { get; set; }
        public DbSet<BusinessContact> businessContacts { get; set; }



    }
}
