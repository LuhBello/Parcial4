using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesca_Registros
{
    public class Cuenca
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("id")]
        public int Codigo { get; set; }

        [BsonElement("nombre_cuenca")]
        public string Nombre { get; set; }
        public Cuenca()
        {
            Codigo = 0;
            Nombre = "";

        }
    }
}
