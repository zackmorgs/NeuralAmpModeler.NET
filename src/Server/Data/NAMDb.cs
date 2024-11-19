using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class NAMDb(DbContextOptions<NAMDb> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<NAMFile> NAMFiles { get; set; }
    }
}
