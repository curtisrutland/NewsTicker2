using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NewsTicker.Entities
{
  public class NewsTickerContext : DbContext
  {
    public DbSet<NewsItem> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=news.db");
    }
  }

}