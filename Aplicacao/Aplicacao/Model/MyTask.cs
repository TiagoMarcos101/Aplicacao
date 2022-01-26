using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Aplicacao
{
   public class MyTask 
    {
        [BsonId(IdGenerator = typeof (CombGuidGenerator))]
        public Guid id { get; set; }

        string _Nomeuser;
        [BsonElement("Nomeuser")]
        public string Name
        {
            get => _Nomeuser; set
            {
                if (_Nomeuser == value)
                    return;
                _Nomeuser = value;

                
            }
        }

        string _password


    }
}
