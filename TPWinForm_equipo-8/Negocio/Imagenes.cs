using dominio;

namespace Negocio
{
    public class Imagenes
    {

        public static List<Imagen> Listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            List<Imagen> imagenes = new List<Imagen>();

            var lector = acceso.Leer("SELECT IdArticulo, ImagenUrl FROM imagenes ORDER BY Id");

            while (lector.Read())
            {
                Imagen aux = new Imagen
                {
                    IdArticulo = (int)lector["IdArticulo"],
                    Url = (string)lector["ImagenUrl"],
                };

                imagenes.Add(aux);
            }

            return imagenes;
        }

        public static bool Grabar(Marca marca)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = string.Format("INSERT INTO imagenes (IdArticulo, ImagenUrl) VALUES ('{0}')", marca.Descripcion);
            return acceso.Ejecutar(query) > 0;
        }
    }
}
