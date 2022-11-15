# Pescas_db_NoSQL
Aplicaciones tipo Desktop para demostrar conectividad con MongoDB.

- Framework: .NET 4.8.x
- Tipo proyecto: Windows Forms
- DB: MongoDB

# Forma de Ejecución
- Como la bd tiene auntenticación, es mejor hacer los pasos desde la creación del contenedor,
usando la imagen de 'mongodb:latest'. Entonces los comandos son:

```
docker run --name mongodb_pescas -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=Upb12332 -p 27017:27017 -d mongo:latest]]
```
- Luego se hace la conexión el MongoDB Compass,
```
usr:mongoadmin
pass:Upb12332
```
- Proceda a entrar en la CLI de MongoDB Compass e ingresar:

```
use Pescas_db_NoSQL
db.createCollection('pescas')
db.createCollection('metodos')
db.createCollection('cuencas')
db.createCollection('contador')

db.contador.insert({nombre: "pescas", valor: 1})
db.contador.insert({name: "cuencas", valor: 1})
db.contador.insert({name: "metodos", valor: 1})
```

- Por último, procesa a importar cada uno de los documentos de cada colección, desde sus respectivos archivos JSON.
Con esto, se debería ejecutar correctamente.
-- Los archivos son los usado en la Base de datos del profesor, sin embargo, están dentro del repo en la carpeta "Archivos". 
 

# COMPARACIÓN SQL VS NoSQL

Desde mi punto de vista, SQL es muy estricto, tuve muchas dificultades en un inicio para que pudiera funcionar el proyecto, sin embargo, también fue más manejable,
no hubo un momento en donde me quedara en blanco, pues había completa comprensión de todo lo sucedía, aunque las sentencias eran muy largas en comparación con el NoSQL. Con ese último, 
tuve una dificultad, pero esta fue en su comprensión, puesto que no había manera que la entendiera con un pensamiento espacial, ya que es mucho más astracta. Pero, en la NoSQL, pude notar 
que puede ser facilmente elástica. En lo personal, prefiero tener el control total de lo que sucede en mi código aunque eso me cueste rendimiento u optimización, sin embargo, este fue el primer proyecto,
por lo que puede que luego de usar un motor de bd en otros proyectos, pueda ver el gran beneficio. Cabe aclarar que esta solo fue mi persepción en un proyecto relativamente pequeño, en proyecto grande, 
lo más probable es que mi opinión sea diferente.

