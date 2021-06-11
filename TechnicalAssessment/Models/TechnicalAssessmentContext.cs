using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TechnicalAssessment.Models
{
    public class TechnicalAssessmentContext : DbContext
    {
         public DbSet<Bookmarks> Bookmarks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:technicalassessmentgbm14.database.windows.net,1433;Initial Catalog=TechnicalAssesmentBBDD;Persist Security Info=False;User ID=gbm14;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
