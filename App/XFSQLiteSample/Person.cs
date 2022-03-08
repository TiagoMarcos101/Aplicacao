using SQLite;

namespace XFSQLiteSample
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuantCoz { get; set; }
        public int TipoCoz { get; set; }
        
        public string Time { get; set; }


}
}
