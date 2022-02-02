using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLite;
namespace Aplicacao
{ 

    public  class SQLDB
{
     [PrimaryKey]
     [AutoIncrement]
        public int Id { get; set; }
        public string Fname { get; set; }

        public string Passwd { get; set; }
         public int Lugtot { get; set; }


}
}