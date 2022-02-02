using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Aplicacao.VC;
namespace Aplicacao
{
   public class Database
    {
        public SQLiteAsyncConnection _database;
        public Database(string dbpath)
        {
            _database = new SQLiteAsyncConnection(dbpath);
            _database.CreateTableAsync<SQLDB>();
        }
        public Task<List<SQLDB>> GetUserAsync()


        {
            return _database.Table<SQLDB>().ToListAsync();
        }
        public Task<int> SaveUserAsync(SQLDB user)
        {
            return _database.InsertAsync(user);
        }
    }
}
