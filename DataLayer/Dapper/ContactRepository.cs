using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dapper
{
    public class ContactRepository : IContactRepository
    {
        private IDbConnection db = new SqlConnection(System.ConfigurationManager.ConnectionStrings["contactsDB"].ConnectionString);
        public Contact Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetFullContact(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
