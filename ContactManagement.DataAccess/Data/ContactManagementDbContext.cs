using ContactManagement.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagement.DataAccess.Data
{
    public class ContactManagementDbContext : DbContext
    {
        public ContactManagementDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
