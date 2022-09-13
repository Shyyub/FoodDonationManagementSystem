using FoodDonationManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.DataAccess
{
    public class DonarContext:DbContext
    {
        public DonarContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SchoolModel> schoolModels { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolModel>().HasData(new SchoolModel
            {
                DonarId = 1,
                DonarName = "Shyyub",
                DonarCity = "Delhi",
                DonarAddress = "Davangere"
            }
            );
        }
    }
}
