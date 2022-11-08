using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Pesca_Registros

{
    public class Pesca
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("codigo")]
        public int Codigo { get; set; }
       
        [BsonElement("nombre_cuenca")]
        public string Nombre_Cuenca { get; set; }

        [BsonElement("nombre_metodo")]
        public string Nombre_Metodo { get; set; }
        
        [BsonElement("peso_total")]
        public double Peso_Total { get; set; }

        [BsonElement("fecha")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Obtiene la cadena de caracteres que describe la siembra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                $"Código Pesca: {Codigo} " + Environment.NewLine +
                $"Nombre Cuenca: {Nombre_Cuenca} " + Environment.NewLine +
                $"Nombre Metodo: {Nombre_Metodo} " + Environment.NewLine +
                $"Peso Total: {Peso_Total.ToString("0.00")} " + Environment.NewLine +
                $"Fecha_Pesca: {Fecha} ");
        }
    }
}
