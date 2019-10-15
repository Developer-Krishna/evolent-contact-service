using EvolentService.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EvolentService.Core.Repository
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
