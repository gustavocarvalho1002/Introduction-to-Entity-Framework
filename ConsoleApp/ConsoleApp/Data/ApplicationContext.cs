
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace ConsoleApp.Data
{
    class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3M4K2KV\\SQLEXPRESS;Initial Catalog=ConsoleAppDataBase;Trusted_Connection=True;")
        }
    }
}
