using dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class Articulos
    {

        public static List<Articulo> Listar()
        {
            

                AccesoDatos acceso = new AccesoDatos();
                List<Articulo> articulos = new List<Articulo>();

            var lector = acceso.Leer("SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.IdCategoria, c.Descripcion as Categoria, a.IdMarca, m.Descripcion as Marca FROM Articulos a LEFT OUTER JOIN Categorias c ON c.Id = a.IdCategoria LEFT OUTER JOIN Marcas m ON m.Id = a.IdMarca ORDER BY a.Id");

            while (lector.Read())
            {
                Articulo aux = new Articulo
                {
                    Id = (int)lector["Id"],
                    Codigo = (string)lector["Codigo"],
                    Nombre = (string)lector["Nombre"],
                    Precio = (decimal)lector["Precio"],
                    Descripcion = (string)lector["Descripcion"],
                    IdCategoria = lector["IdCategoria"] != DBNull.Value ? (int)lector["IdCategoria"] : -1,
                    Categoria = lector["Categoria"] != DBNull.Value ? (string)lector["Categoria"] : "",
                    Marca = lector["Marca"] != DBNull.Value ? (string)lector["Marca"] : "",
                    IdMarca = lector["IdMarca"] != DBNull.Value ? (int)lector["IdMarca"] : -1,
                    Imagenes = Imagenes.ByArticuloId((int)lector["Id"]),
                };

                    articulos.Add(aux);
                }

                return articulos;
            
           
        }

        public static bool Existe(string codigo)
        {
            AccesoDatos acceso = new AccesoDatos();
            var lector = acceso.Leer("SELECT Id FROM Articulos WHERE Codigo = '" + codigo + "'");

            return lector.Read();
        }

        public static bool Grabar(Articulo articulo)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = string.Format("INSERT INTO Articulos (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio) VALUES ('{0}','{1}','{2}',{3},{4},{5})", articulo.Codigo, articulo.Nombre, articulo.Descripcion, articulo.IdCategoria, articulo.IdMarca, articulo.Precio);
            return acceso.Ejecutar(query) > 0;
        }

        public static bool Editar(Articulo articulo)
        {
            AccesoDatos acceso = new AccesoDatos();
            
            string query = string.Format("UPDATE Articulos SET Codigo='" + articulo.Codigo + "', Nombre='" + articulo.Nombre + "', Descripcion='" + articulo.Descripcion + "', IdCategoria='" + articulo.IdCategoria + "', IdMarca='" + articulo.IdMarca + "', Precio='" + articulo.Precio + "' WHERE Id='" + articulo.Id + "'");
            return acceso.Ejecutar(query) > 0;
        }
    }
}
