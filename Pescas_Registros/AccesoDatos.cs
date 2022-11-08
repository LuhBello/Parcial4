using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using System.Data;
using System;

namespace Pesca_Registros
{
    public class AccesoDatos
    {
        const string nombreDB = "Pescas_db_NoSQL";
        const string idStringConexion = "Pescas_db_NoSQL";

        /// <summary>
        /// Obtiene la cadena de conexión a la DB a partir del archivo de configuración de la App
        /// </summary>
        private static string ObtenerCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        #region CRUD de Pesca

        /// <summary>
        /// Valida si la pesca tiene valores válidos para operaciones CRUD
        /// </summary>
        /// <param name="unaPesca">Objeto pesca</param>
        /// <returns>Verdadero si tiene todos los valores requeridos</returns>
        private static bool ValidaPesca(Pesca unaPesca)
        {
            bool resultado = false;

            if ( unaPesca.Codigo != 0)
                resultado = true;

            return resultado;
        }

        private static bool ValidaCuenca(Cuenca unaCuenca)
        {
            bool resultado = false;

            if ( unaCuenca.Codigo != 0)
                resultado = true;

            return resultado;
        }

        private static bool ValidaMetodo(Metodo unaMetodo)
        {
            bool resultado = false;

            if (unaMetodo.Codigo != 0)
                resultado = true;

            return resultado;
        }

        /// <summary>
        /// Obtiene el siguiente valor para ser utilizado en las acciones de inserción de las colecciones
        /// </summary>
        /// <param name="nombreContador">nombre del contador asociado a la colección</param>
        /// <returns>el siguiente valor del contador</returns>
        private static int ObtieneSiguienteValorContador(string nombreContador)
        {
            int siguienteValor = 0;

            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Obtenemos el valor actual del contador
            var miColeccion = miDB.GetCollection<Contador>("contador");
            var filtroContador = new BsonDocument { { "nombre", nombreContador } };

            var elContador = miColeccion.Find(filtroContador).FirstOrDefault();

            siguienteValor = elContador.Valor++;

            //Actualizamos el contador con ese valor
            miColeccion.ReplaceOne(unContador => unContador.Nombre == elContador.Nombre, elContador);
            return siguienteValor;
        }

        private static void ComprobarConsecutivo(string nombreContador)
        {

        }

        /// <summary>
        /// Obtiene el detalle de las pescas registradas en la DB
        /// </summary>
        /// <returns>DataTable con la información requerida</returns>
        public static DataTable ObtenerDetallePescas()
        {

            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Pesca>("pescas");
            var lasPescas = miColeccion.Find(new BsonDocument()).ToList();

            //Aqui creamos la dataTable de resultados
            DataTable tablaResultado = new DataTable();

            //Aqui le definimos las columnas que utilizará
            tablaResultado.Columns.Add(new DataColumn("codigo", typeof(int)));
            tablaResultado.Columns.Add(new DataColumn("nombre_cuenca", typeof(string)));
            tablaResultado.Columns.Add(new DataColumn("nombre_metodo", typeof(string)));
            tablaResultado.Columns.Add(new DataColumn("fecha", typeof(string)));
            tablaResultado.Columns.Add(new DataColumn("peso_total", typeof(int)));

            DataRow filaPesca;

            foreach (Pesca unaPesca in lasPescas)
            {
                filaPesca = tablaResultado.NewRow();

                filaPesca["codigo"] = unaPesca.Codigo;
                filaPesca["nombre_cuenca"] = unaPesca.Nombre_Cuenca;
                filaPesca["nombre_metodo"] = unaPesca.Nombre_Metodo;
                filaPesca["fecha"] = unaPesca.Fecha.ToShortDateString();
                filaPesca["peso_total"] = unaPesca.Peso_Total;

                tablaResultado.Rows.Add(filaPesca);
            }

            return tablaResultado;
        }
        

        /// <summary>
        /// Completa el objeto pesca con los códigos correspondientes a los nombres contenidos en los atributos
        /// </summary>
        /// <param name="unaPesca">Objeto para completar</param>
        /*private static void CompletaCodigosPesca(Pesca unaPesca)
        {
            unaPesca.Codigo_Cuenca = ObtieneCodigoCuenca(unaPesca.Nombre_Cuenca);
            unaPesca.Codigo_Metodo = ObtieneCodigoMetodo(unaPesca.Nombre_Metodo);
        }

        /// <summary>
        /// Completa el objeto pesca con los nombres correspondientes a los codigos contenidos en los atributos
        /// </summary>
        /// <param name="unaPesca">Objeto para completar</param>
        private static void CompletaNombresPesca(Pesca unaPesca)
        {
            unaPesca.Nombre_Cuenca = ObtieneNombreCuenca(unaPesca.Codigo_Cuenca);
            unaPesca.Nombre_Metodo = ObtieneNombreMetodo(unaPesca.Codigo_Metodo);
        }*/






        /// <summary>
        /// Obtiene la información de una pesca
        /// </summary>
        /// <param name="codigoPesca">ID que identifica una pesca</param>
        /// <returns></returns>
        public static Pesca ObtenerPesca(int codigoPesca)
        {
        string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
        var clienteDB = new MongoClient(cadenaConexion);
        var miDB = clienteDB.GetDatabase(nombreDB);

        var miColeccion = miDB.GetCollection<Pesca>("pescas");
        var filtroPesca = new BsonDocument { { "codigo", codigoPesca } };

        var unaPesca = miColeccion.Find(filtroPesca).FirstOrDefault();

        return unaPesca;
        }

        public static string ObtieneObjectIdPesca(int codigoPesca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Pesca>("pescas");
            var filtroPesca = new BsonDocument { { "codigo", codigoPesca } };

            var unaPesca = miColeccion.Find(filtroPesca).FirstOrDefault();

            return unaPesca.Id;
        }

        /// <summary>
        /// Guarda la información del objeto pesca en la DB
        /// </summary>
        /// <param name="laPesca">Objeto pesca</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void GuardarPesca(Pesca laPesca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Aqui le asignamos el siguiente consecutivo para la Pesca
            laPesca.Codigo = ObtieneSiguienteValorContador("pescas");

            var miColeccion = miDB.GetCollection<Pesca>("pescas");
            miColeccion.InsertOne(laPesca);
        }

        /// <summary>
        /// Actualiza la información de la pesca en la DB
        /// </summary>
        /// <param name="laPesca">Objeto pesca</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void ActualizarPesca(Pesca laPesca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la Pesca existente para obtener el ObjectId
            Pesca PescaExistente = ObtenerPesca(laPesca.Codigo);
            laPesca.Id = PescaExistente.Id;

            var miColeccion = miDB.GetCollection<Pesca>("pescas");
            miColeccion.ReplaceOne(documento => documento.Codigo == laPesca.Codigo, laPesca);
        }


        /// <summary>
        /// Borra la información de la pesca de la DB
        /// </summary>
        /// <param name="codigoPesca">Codigo de la pesca a borrar</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void BorrarPesca(int codigoPesca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la Pesca existente para obtener el ObjectId
            Pesca PescaExistente = ObtenerPesca(codigoPesca);

            var miColeccion = miDB.GetCollection<Pesca>("pescas");
            miColeccion.DeleteOne(documento => documento.Id == PescaExistente.Id);
        }

        /// <summary>
        /// Obtiene lista con información ampliada de la pesca
        /// </summary>
        /// <returns>Lista con información de la pesca</returns>
        public static List<string> ObtieneListaInfoPescas()
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Pesca>("pescas");
            var lasPescas = miColeccion.Find(new BsonDocument()).ToList();

            //Aqui creamos la lista de resultados
            List<string> listaResultado = new List<string>();
            string registroPesca;

            foreach (Pesca unaPesca in lasPescas)
            {
                registroPesca = $"{unaPesca.Codigo} - " +
                    $"{unaPesca.Nombre_Cuenca} - " +
                    $"{unaPesca.Nombre_Metodo} - " +
                    $"{unaPesca.Peso_Total} - " +
                    $"{unaPesca.Fecha.ToShortDateString()}";

                listaResultado.Add(registroPesca);
            }

            return listaResultado;
        }

        #endregion CRUD de Pesca



        #region CRUD de Cuencas

        /// <summary>
        /// Obtiene la información de una pesca
        /// </summary>
        /// <param name="codigoPesca">ID que identifica una pesca</param>
        /// <returns></returns>
        private static Cuenca ObtenerCuenca(int codigoCuenca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
            var filtroCuenca = new BsonDocument { { "id", codigoCuenca } };

            var unaCuenca = miColeccion.Find(filtroCuenca).FirstOrDefault();

            return unaCuenca;
        }

        public static string ObtieneObjectIdCuenca(int codigoCuenca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
            var filtroCuenca = new BsonDocument { { "id", codigoCuenca } };

            var unaCuenca = miColeccion.Find(filtroCuenca).FirstOrDefault();

            return unaCuenca.Id;
        }

        /// <summary>
        /// Obtiene el nombre de los cuencas registrados en la DB
        /// </summary>
        /// <returns>Lista con el nombre de los cuencas</returns>
        public static List<string> ObtieneListaCuencas()
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
            var losCuencas = miColeccion.Find(new BsonDocument()).ToList();

            List<string> nombresCuencas = new List<string>();

            foreach (Cuenca unCuenca in losCuencas)
                nombresCuencas.Add(unCuenca.Nombre);

            return nombresCuencas;
        }

        public static List<string> ObtieneListaInfoCuencas()
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
            var lasCuencas = miColeccion.Find(new BsonDocument()).ToList();

            //Aqui creamos la lista de resultados
            List<string> listaResultado = new List<string>();
            string registroCuenca;

            foreach (Cuenca unaCuenca in lasCuencas)
            {
                registroCuenca = $"{unaCuenca.Codigo} - " +
                    $"{unaCuenca.Nombre}";

                listaResultado.Add(registroCuenca);
            }

            return listaResultado;
        
        }

        /// <summary>
        /// Guarda la información del objeto pesca en la DB
        /// </summary>
        /// <param name="laCuenca">Objeto pesca</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void GuardarCuenca(Cuenca laCuenca)
        {
        string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
        var clienteDB = new MongoClient(cadenaConexion);
        var miDB = clienteDB.GetDatabase(nombreDB);

        //Aqui le asignamos el siguiente consecutivo para la Pesca
        laCuenca.Codigo = ObtieneSiguienteValorContador("cuencas");

        var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
        miColeccion.InsertOne(laCuenca);
    }

        /// <summary>
        /// Actualiza la información de la cuenca en la DB
        /// </summary>
        /// <param name="laCuenca">Objeto Cuenca</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void ActualizarCuenca(Cuenca laCuenca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la Pesca existente para obtener el ObjectId
            Cuenca PescaExistente = ObtenerCuenca(laCuenca.Codigo);
            laCuenca.Id = PescaExistente.Id;

            var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
            miColeccion.ReplaceOne(documento => documento.Codigo == laCuenca.Codigo, laCuenca);
        }

        /// <summary>
        /// Borra la información de la pesca de la DB
        /// </summary>
        /// <param name="codigoCuenca">Codigo de la pesca a borrar</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void BorrarCuenca(int codigoCuenca)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la Pesca existente para obtener el ObjectId
            Cuenca CuencaExistente = ObtenerCuenca(codigoCuenca);

            var miColeccion = miDB.GetCollection<Cuenca>("cuencas");
            miColeccion.DeleteOne(documento => documento.Id == CuencaExistente.Id);
        }



        #endregion CRUD de Cuencas


        #region CRUD de Metodos

        /// <summary>
        /// Obtiene la lista de los Metodos disponibles para las pescas
        /// </summary>
        /// <returns>Lista de Strings con los nombres de los Metodos</returns>
        public static List<string> ObtieneListaMetodos()
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            var losMetodos = miColeccion.Find(new BsonDocument()).ToList();

            List<string> nombresMetodos = new List<string>();

            foreach (Metodo unMetodo in losMetodos)
                nombresMetodos.Add(unMetodo.Nombre);

            return nombresMetodos;
        }

        private static Metodo ObtenerMetodo(int codigoMetodo)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            var filtroMetodo = new BsonDocument { { "id_metodo", codigoMetodo } };

            var unMetodo = miColeccion.Find(filtroMetodo).FirstOrDefault();

            return unMetodo;
        }

        public static string ObtieneObjectIdMetodo(int codigoMetodo)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            var filtroMetodo = new BsonDocument { { "id_metodo", codigoMetodo } };

            var unaMetodo = miColeccion.Find(filtroMetodo).FirstOrDefault();

            return unaMetodo.Id;
        }

        public static List<string> ObtieneListaInfoMetodos()
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            var losMetodos = miColeccion.Find(new BsonDocument()).ToList();

            //Aqui creamos la lista de resultados
            List<string> listaResultado = new List<string>();
            string registroMetodo;

            foreach (Metodo unMetodo in losMetodos)
            {
                registroMetodo = $"{unMetodo.Codigo} - " +
                    $"{unMetodo.Nombre}";

                listaResultado.Add(registroMetodo);
            }

            return listaResultado;
        
        }


        /// <summary>
        /// Guarda la información del objeto pesca en la DB
        /// </summary>
        /// <param name="elMetodo">Objeto pesca</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void GuardarMetodo(Metodo elMetodo)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

        //Aqui le asignamos el siguiente consecutivo para la Pesca
        elMetodo.Codigo = ObtieneSiguienteValorContador("metodos");

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            miColeccion.InsertOne(elMetodo);
        }

        /// <summary>
        /// Actualiza la información de la cuenca en la DB
        /// </summary>
        /// <param name="elMetodo">Objeto Cuenca</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void ActualizarMetodo(Metodo elMetodo)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);
            
            //Ubicamos el Metodo existente para obtener el ObjectId
            Metodo MetodoExistente = ObtenerMetodo(elMetodo.Codigo);
            elMetodo.Id = MetodoExistente.Id;

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            miColeccion.ReplaceOne(documento => documento.Codigo == elMetodo.Codigo, elMetodo);
        }

        /// <summary>
        /// Borra la información de la pesca de la DB
        /// </summary>
        /// <param name="codigoMetodo">Codigo de la pesca a borrar</param>
        /// <param name="mensajeError">En caso de falla, se obtiene el mensaje de error</param>
        /// <returns>Valor booleano con el resultado de la operación</returns>
        static public void BorrarMetodo(int codigoMetodo)
        {
            string cadenaConexion = ObtenerCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            var miDB = clienteDB.GetDatabase(nombreDB);

            //Ubicamos la Pesca existente para obtener el ObjectId
            Metodo MetodoExistente = ObtenerMetodo(codigoMetodo);

            var miColeccion = miDB.GetCollection<Metodo>("metodos");
            miColeccion.DeleteOne(documento => documento.Id == MetodoExistente.Id);
        }

        #endregion CRUD de Metodos

    }
}
