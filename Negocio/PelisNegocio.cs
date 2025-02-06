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
        public List<Pelicula> listar() 
        {
            List<Pelicula>listaPelis = new List<Pelicula>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = MaxiFlix_DB; Integrated Security = true";
                comando.CommandType = System.Data.CommandType.Text;
                //Cambio la consulta -incluiye + tablas
                comando.CommandText = "Select P.Titulo, P.FechaEstreno, STRING_AGG(C.Descripcion, ', ') as 'Genero', MIN(M.MediaURL) as 'Imagen' from Peliculas P inner join [Peliculas.Categorias] PC on P.Id = PC.IdPelicula inner join Categorias C on PC.IdCategoria = C.Id left join Media M on P.Id = M.IdPelicula Group By  P.Titulo, P.FechaEstreno";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pelicula auxiliar = new Pelicula();
                    auxiliar.Titulo = (string)lector["Titulo"];
                    auxiliar.FechaEstreno = (DateTime)lector["FechaEstreno"];

                    auxiliar.Media = new Media();
                    auxiliar.Media.MediaURL = (string)lector["Imagen"];

                    auxiliar.Categorias = new Categorias();
                    auxiliar.Categorias.Descripcion = (string)lector["Genero"];
                 


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








    }
}
