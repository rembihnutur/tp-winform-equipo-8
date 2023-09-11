using dominio;

namespace Negocio
{
    public class Categorias
    {

        public static List<Categoria> Listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            List<Categoria> categorias = new List<Categoria>();

            var lector = acceso.Leer("SELECT Id, Descripcion FROM Categorias ORDER BY Id");

            while (lector.Read())
            {
                Categoria aux = new Categoria
                {
                    Id = (int)lector["Id"],
                    Descripcion = (string)lector["Descripcion"],
                };

                categorias.Add(aux);
            }

            return categorias;
        }

        public static bool Grabar(Categoria categoria)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = string.Format("INSERT INTO Categorias (Descripcion) VALUES ('{0}')", categoria.Descripcion);
            return acceso.Ejecutar(query) > 0;
        }
    }
}
