using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class PelisNegocio
    {
        #region Listar
        public List<Pelicula> listar()
        {
            List<Pelicula> listaPelis = new List<Pelicula>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = PelisApp_DB; Integrated Security = true";
                comando.CommandType = System.Data.CommandType.Text;
                //Cambio la consulta -incluiye + tablas
                comando.CommandText = "With PlataformasUnicas as (" +
    "Select PP.IdPelicula, STRING_AGG(PL.Nombre, ', ') as Plataformas " +
    "From [Peliculas.Plataformas] PP " +
    "inner join Plataformas PL ON PP.IdPlataforma = PL.Id " +
    "group by PP.IdPelicula), " +
    "GenerosUnicos as (" +
    "Select PC.IdPelicula, STRING_AGG(C.Descripcion, ',') as Generos " +
    "From [Peliculas.Categorias] PC " +
    "inner join Categorias C on PC.IdCategoria = C.Id " +
    "Group By IdPelicula), " +
    "RepartosUnicos as (" +
    "Select PR.IdPelicula, STRING_AGG(CONCAT(R.Nombre, ' ' ,R.Apellido), ', ') as Reparto " +
    "from [Peliculas.Reparto] PR " +
    "inner join Reparto R on PR.IdReparto = R.Id " +
    "group by IdPelicula) " +
    "Select P.Titulo, P.Bio, P.MinutosDuracion as 'Duracion', GU.Generos as 'Genero', " +
    "Cl.Descripcion as 'Clasificacion', MIN(M.MediaURL) as 'Imagen', " +
    "P.FechaEstreno, PU.Plataformas, RU.Reparto " +
    "From Peliculas P " +
    "inner join [Peliculas.Clasificaciones] PCl on P.Id = PCl.IdPelicula " +
    "inner join Clasificaciones Cl on PCl.IdClasificacion = Cl.Id " +
    "inner join Media M on P.Id = M.IdPelicula " +
    "inner join GenerosUnicos GU on P.Id = GU.IdPelicula " +
    "inner join PlataformasUnicas PU on P.Id = PU.IdPelicula " +
    "inner join RepartosUnicos RU on P.Id = RU.IdPelicula " +
    "group by P.Titulo, P.Bio, P.MinutosDuracion, P.FechaEstreno, Cl.Descripcion, PU.Plataformas, " +
    "GU.Generos, RU.Reparto;";

                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pelicula auxiliar = new Pelicula();
                    auxiliar.Titulo = (string)lector["Titulo"];
                    auxiliar.Bio = (string)lector["Bio"];
                    auxiliar.Duracion = (int)lector["Duracion"];
                    auxiliar.FechaEstreno = (DateTime)lector["FechaEstreno"];

                    auxiliar.Media = new Media();
                    auxiliar.Media.MediaURL = (string)lector["Imagen"];

                    auxiliar.Categorias = new Categorias();
                    auxiliar.Categorias.Descripcion = (string)lector["Genero"];

                    auxiliar.Clasificaciones = new Clasificaciones();
                    auxiliar.Clasificaciones.Descripcion = (string)lector["Clasificacion"];

                    auxiliar.Plataformas = new Plataformas();
                    auxiliar.Plataformas.Nombre = (string)lector["Plataformas"];

                    auxiliar.Reparto = new Reparto();
                    auxiliar.Reparto.Nombre = (string)lector["Reparto"];



                    listaPelis.Add(auxiliar);
                }
                return listaPelis;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion


        public void agregar() { }

        public void modificar() { }
    }
}
