using ApiProject_Sep9Fri.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiProject_Sep9Fri.Data
{
    public class DataBase:DbContext
    {
        public DataBase(DbContextOptions<DataBase>options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
