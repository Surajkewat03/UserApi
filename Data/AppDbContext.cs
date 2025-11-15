using Microsoft.EntityFrameworkCore;
using UserApi.Models;   // ✔ यह जरूरी है

namespace UserApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Test { get; set; }  

    }
}
