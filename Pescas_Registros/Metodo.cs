using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesca_Registros

{
    public class Metodo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("id_metodo")]
        public int Codigo { get; set; }

        [BsonElement("metodo_nombre")]
        public string Nombre { get; set; }

        public Metodo()
        {
            Codigo = 0;
            Nombre = "";

        }
    }
}
