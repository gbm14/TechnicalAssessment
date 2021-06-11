using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TechnicalAssessment.Models
{
    public class BookmarksContext : DbContext
    {
        public BookmarksContext(DbContextOptions<BookmarksContext> options)
                : base(options)
        {
        }

        public DbSet<Bookmarks> Bookmarks { get; set; }
    }
}
