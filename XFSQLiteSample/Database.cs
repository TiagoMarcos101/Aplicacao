using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace XFSQLiteSample
{
    public class Database
    {

        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
        public Task<int> UpdatePersonAsync(Person person)
        {
            return _database.UpdateAsync(person);
        }
        public Task<int> DeletePersonAsync(Person person)
        {
            return _database.DeleteAsync(person);
        }
        /*
        public Task<List<Person>> QuerydbAsync()
        {

            return _database.QueryAsync<Person>("SELECT * FROM Person");

        }
        */
        public Task<List<Person>> Query2Async()
        {
            return _database.QueryAsync<Person>("SELECT Name FROM Person Where QuantCoz >= 1");

        }
        public Task<List<Person>> Query3Async()
        {
            return _database.QueryAsync<Person>("SELECT Name FROM Person Where QuantCoz = 0");

        }
        public Task<List<Person>> Query4Async()
        {
            return _database.QueryAsync<Person>("SELECT Name FROM Person");
        }
        

    }
}
