using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dapper
{
    public class ContactRepository : IContactRepository
    {
        //  private IDbConnection db = new SqlConnection(System.ConfigurationManager.ConnectionStrings["contactsDB"].ConnectionString);
        // Home SqlServer connection string
        //string connectionString = @"Data Source=DESKTOP-S4RCJLC\SQLSRV;Initial Catalog=ContactsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
        private static string connectionString = @"Data Source=OLEKSANDR-KUZIA\SQLEXPRESS;Initial Catalog=ContactsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True";
        private IDbConnection db = new SqlConnection(connectionString);
        public Contact Add(Contact contact)
        {
            var sql = "INSERT INTO Contacts(FirstName, LastName, Email, Company, Title) VALUES(@FirstName, @LastName, @Email, @Company, @Title);" +
                "SELECT CAST(SCOPE_IDENTITY() AS int);";
            var id = this.db.Query<int>(sql, contact).Single();
            contact.Id = id;
            return contact;
        }

        public Contact Find(int id)
        {
            var contact= this.db.Query<Contact>("SELECT * FROM Contacts WHERE Id=@Id", new { id }).SingleOrDefault();
            return contact;
        }

        public List<Contact> GetAll()
        {
            return db.Query<Contact>("SELECT * FROM Contacts").ToList();
        }

        public Contact GetFullContact(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            this.db.Execute("DELETE FROM Contacts WHERE Id = @Id", new { Id = id });
        }

        public void Save(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact contact)
        {
            var sql =
                "UPDATE Contacts " +
                "SET FirstName = @FirstName, " +
                "    LastName  = @LastName, " +
                "    Email     = @Email, " +
                "    Company   = @Company, " +
                "    Title     = @Title " +
                "WHERE  Id = @Id;";
            this.db.Execute(sql, contact);
            return contact;
        }
    }
}
