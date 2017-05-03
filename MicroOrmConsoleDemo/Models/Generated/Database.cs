




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `contactsDB`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace contactsDB
{

	public partial class contactsDBDB : Database
	{
		public contactsDBDB() 
			: base("contactsDB")
		{
			CommonConstruct();
		}

		public contactsDBDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			contactsDBDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static contactsDBDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new contactsDBDB();
        }

		[ThreadStatic] static contactsDBDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static contactsDBDB repo { get { return contactsDBDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.Contacts")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class Contact : contactsDBDB.Record<Contact>  
    {



		[Column] public int Id { get; set; }





		[Column] public string FirstName { get; set; }





		[Column] public string LastName { get; set; }





		[Column] public string Email { get; set; }





		[Column] public string Company { get; set; }





		[Column] public string Title { get; set; }



	}

    

	[TableName("dbo.MSreplication_options")]




	[ExplicitColumns]

    public partial class MSreplication_option : contactsDBDB.Record<MSreplication_option>  
    {



		[Column] public string optname { get; set; }





		[Column] public bool value { get; set; }





		[Column] public int major_version { get; set; }





		[Column] public int minor_version { get; set; }





		[Column] public int revision { get; set; }





		[Column] public int install_failures { get; set; }



	}

    

	[TableName("dbo.spt_fallback_db")]




	[ExplicitColumns]

    public partial class spt_fallback_db : contactsDBDB.Record<spt_fallback_db>  
    {



		[Column] public string xserver_name { get; set; }





		[Column] public DateTime xdttm_ins { get; set; }





		[Column] public DateTime xdttm_last_ins_upd { get; set; }





		[Column] public short? xfallback_dbid { get; set; }





		[Column] public string name { get; set; }





		[Column] public short dbid { get; set; }





		[Column] public short status { get; set; }





		[Column] public short version { get; set; }



	}

    

	[TableName("dbo.spt_fallback_dev")]




	[ExplicitColumns]

    public partial class spt_fallback_dev : contactsDBDB.Record<spt_fallback_dev>  
    {



		[Column] public string xserver_name { get; set; }





		[Column] public DateTime xdttm_ins { get; set; }





		[Column] public DateTime xdttm_last_ins_upd { get; set; }





		[Column] public int? xfallback_low { get; set; }





		[Column] public string xfallback_drive { get; set; }





		[Column] public int low { get; set; }





		[Column] public int high { get; set; }





		[Column] public short status { get; set; }





		[Column] public string name { get; set; }





		[Column] public string phyname { get; set; }



	}

    

	[TableName("dbo.spt_fallback_usg")]




	[ExplicitColumns]

    public partial class spt_fallback_usg : contactsDBDB.Record<spt_fallback_usg>  
    {



		[Column] public string xserver_name { get; set; }





		[Column] public DateTime xdttm_ins { get; set; }





		[Column] public DateTime xdttm_last_ins_upd { get; set; }





		[Column] public int? xfallback_vstart { get; set; }





		[Column] public short dbid { get; set; }





		[Column] public int segmap { get; set; }





		[Column] public int lstart { get; set; }





		[Column] public int sizepg { get; set; }





		[Column] public int vstart { get; set; }



	}

    

	[TableName("dbo.spt_monitor")]




	[ExplicitColumns]

    public partial class spt_monitor : contactsDBDB.Record<spt_monitor>  
    {



		[Column] public DateTime lastrun { get; set; }





		[Column] public int cpu_busy { get; set; }





		[Column] public int io_busy { get; set; }





		[Column] public int idle { get; set; }





		[Column] public int pack_received { get; set; }





		[Column] public int pack_sent { get; set; }





		[Column] public int connections { get; set; }





		[Column] public int pack_errors { get; set; }





		[Column] public int total_read { get; set; }





		[Column] public int total_write { get; set; }





		[Column] public int total_errors { get; set; }



	}


}
