﻿using System;
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
            throw new NotImplementedException();
        }

        public Contact Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            return this.db.Query<Contact>("SELECT * FROM Contacts").ToList();
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
