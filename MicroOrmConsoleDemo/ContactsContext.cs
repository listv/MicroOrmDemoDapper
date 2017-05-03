using System.Data.Entity;

namespace MicroOrmConsoleDemo
{
    class ContactsContext:DbContext
    {
        public ContactsContext(string connectionString)
            :base(connectionString)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
