using Core_WebSitem_API.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_WebSitem_API.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SELVITOPCU\\SQLEXPRESS;database=CoreWebSitemDB2; integrated security=true;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category> Categories { get; set; }
    }
}
