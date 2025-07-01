using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAplplicasionUTNSeguro.Models;

namespace WebAplplicasionUTNSeguro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAplplicasionUTNSeguro.Models.Mascota> Mascotas { get; set; } = default!;
    }
}
