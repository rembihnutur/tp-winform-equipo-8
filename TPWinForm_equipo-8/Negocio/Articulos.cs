using dominio;

namespace Negocio
{
    public class Articulos
    {

        public static List<Articulo> Listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            List<Articulo> articulos = new List<Articulo>();

            var lector = acceso.Leer("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca FROM Articulos a INNER JOIN Categorias c ON c.Id = a.IdCategoria INNER JOIN Marcas m ON m.Id = a.IdMarca ORDER BY a.Id");

            while (lector.Read())
            {
                Articulo aux = new Articulo
                {
                    Id = (int)lector["Id"],
                    Codigo = (string)lector["Codigo"],
                    Nombre = (string)lector["Nombre"],
                    Descripcion = (string)lector["Descripcion"],
                    IdCategoria = (int)lector["IdCategoria"],
                    Categoria = (string)lector["Categoria"],
                    Marca = (string)lector["Marca"],
                    IdMarca = (int)lector["IdMarca"],
                    Imagenes = new List<Imagen>(),
                };

                articulos.Add(aux);
            }

            return articulos;
        }

        public static List<Imagen> Imagenes(int id)
        {
            AccesoDatos acceso = new AccesoDatos();
            var lector = acceso.Leer("SELECT Url FROM Imagenes WHERE IdArticulo = " + id);
            List<Imagen> imagenes = new List<Imagen>();

            while (lector.Read())
            {
                Imagen img = new Imagen()
                {
                    IdArticulo = id,
                    Url = (string)lector["Url"],
                };

                imagenes.Add(img);
            }

            return imagenes;
        }

        public static bool Grabar(Articulo articulo)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = string.Format("INSERT INTO Articulos (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio) VALUES ('{0}','{1}','{2}',{3},{4},{5})", articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.IdCategoria, articulo.IdMarca, articulo.Precio);
            return acceso.Ejecutar(query) > 0;
        }
    }
}
