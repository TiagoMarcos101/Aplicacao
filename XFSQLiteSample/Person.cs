using SQLite;

namespace XFSQLiteSample
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }

        public int LugTot { get; set; }
    }
}
