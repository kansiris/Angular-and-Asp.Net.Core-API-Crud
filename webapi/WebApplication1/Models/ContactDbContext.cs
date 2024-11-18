using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public partial class ContactDbContext : DbContext
    {
        public ContactDbContext() { }

        public ContactDbContext(DbContextOptions<ContactDbContext> options):base(options) { }
        public virtual DbSet<TblContact> TblContact { get; set; }

    }
}
