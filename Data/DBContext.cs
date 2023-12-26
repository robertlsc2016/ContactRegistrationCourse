using ContactRegistrationCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactRegistrationCourse.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<ContactModel> Contacts { get; set; }
    }
}
