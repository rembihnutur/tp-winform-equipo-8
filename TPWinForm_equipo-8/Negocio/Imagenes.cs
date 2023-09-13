using dominio;

namespace Negocio
{
    public class Imagenes
    {

        public static List<Imagen> Listar()
        {

            AccesoDatos acceso = new AccesoDatos();
            List<Imagen> imagenes = new List<Imagen>();

            var lector = acceso.Leer("SELECT Id, IdArticulo, ImagenUrl FROM Imagenes ORDER BY Id");

            while (lector.Read())
            {
                Imagen aux = new Imagen
                {
                    Id = (int)lector["Id"],
                    IdArticulo = (int)lector["IdArticulo"],
                    Url = (string)lector["ImagenUrl"],
                };

                imagenes.Add(aux);
            }

            return imagenes;
        }

        public static bool Grabar(Imagen imagen)
        {
            AccesoDatos acceso = new AccesoDatos();
            string query = string.Format("INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES ({0},'{1}')", imagen.IdArticulo, imagen.Url);
            return acceso.Ejecutar(query) > 0;
        }
    }
}
