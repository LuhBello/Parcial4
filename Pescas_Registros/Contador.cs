﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesca_Registros
{
    public class Contador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("valor")]
        public int Valor { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        public Contador()
        {
            Valor = 0;
            Nombre = "";
        }
    }
}
