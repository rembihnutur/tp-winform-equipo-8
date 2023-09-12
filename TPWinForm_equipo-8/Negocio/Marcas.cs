using dominio;

namespace Negocio
{
    public class Marcas
    {

        public static List<Marca> Listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            List<Marca> marcas = new List<Marca>();

            var lector = acceso.Leer("SELECT Id, Descripcion FROM Marcas ORDER BY Id");

            while (lector.Read())
            {
                Marca aux = new Marca
                {
                    Id = (int)lector["Id"],
                    Descripcion = (string)lector["Descripcion"],
                };

                marcas.Add(aux);
            }

            return marcas;
        }

        public static bool Grabar(Marca marca)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = string.Format("INSERT INTO Marcas (Descripcion) VALUES ('{0}')", marca.Descripcion);
            return acceso.Ejecutar(query) > 0;
        }
    }
}
