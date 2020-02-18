using Microsoft.EntityFrameworkCore;
using System;


namespace Memory
{
    public class Building : DbContext
    {
        //public buildingDBContext(DbContextOptions<Building> options)
        //    : base(options)
        //{ }
        public DbSet<Models.BuildingModel> Buildings { get; set; }
    }
}
