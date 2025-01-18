using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.Data;
public class MenuContext : DbContext
{
    public DbSet<MenuModel> Menu { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=menu.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}