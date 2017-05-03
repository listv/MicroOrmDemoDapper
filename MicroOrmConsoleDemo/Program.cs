using System;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
//using Dapper;
//using ServiceStack.OrmLite;
//using PetaPoco;
//using Massive;
using Simple.Data;

namespace MicroOrmConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Micro ORM Demo";
            var connectionString = ConfigurationManager.ConnectionStrings["contactsDB"].ConnectionString;

            // EntityFramework
            //var context = new ContactsContext(connectionString);
            ////var contacts = context.Contacts.ToList();
            //var contacts = context.Contacts.Where(c => c.Id == 1).ToList();

            // Dapper
            //SqlConnection db = new SqlConnection(connectionString);
            ////var contacts = db.Query<Contact>("SELECT * FROM Contacts");
            //var contacts = db.Query<Contact>("SELECT * FROM Contacts WHERE Id = @Id", new { Id = 1 });

            // OrmLite
            //var dbFactory = new OrmLiteConnectionFactory(connectionString, SqlServerDialect.Provider);
            //IDbConnection db = dbFactory.OpenDbConnection();
            ////var contacts = db.SqlList<Contact>("SELECT * FROM Contacts");
            //var contacts = db.Where<Contact>(new { Id = 1 }).ToList();

            // PetaPoco
            //Database db = new Database("contactsDB");
            ////var contacts = db.Query<Contact>("SELECT * FROM Contacts");
            //var contacts = db.Query<Contact>("SELECT * FROM Contacts WHERE Id = @Id", new { Id = 1 }).ToList();

            // Massive. Does not work. Package seems to be absent in NPM.
            //dynamic contactsTable = new DynamicModel("contactsDB", "Contacts", "Id");
            ////dynamic contacts = contactsTable.All();
            //dynamic contacts = contactsTable.FindBy(Id: 1);
            //foreach (dynamic item in contacts)
            //    Console.WriteLine(item.FirstName + " " + item.LastName);

            // Simple.Data
            dynamic db = Database.OpenNamedConnection("contactsDB");
            //dynamic contacts = db.Contacts.All().ToList();
            dynamic contacts = db.Contacts.FindAllById(1);

            foreach (dynamic item in contacts)
                Console.WriteLine(item.FirstName + " " + item.LastName);

            //foreach (var item in contacts)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }
}
