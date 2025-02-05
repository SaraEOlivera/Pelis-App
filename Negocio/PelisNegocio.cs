using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    internal class PelisNegocio
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
                comando.CommandText = "Select Titulo, Bio, MinutosDuracion as Duracion from Peliculas";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pelicula auxiliar = new Pelicula();
                    auxiliar.Titulo = (string)lector["Titulo"];
                    auxiliar.Bio = (string)lector["Bio"];
                    auxiliar.Duracion = (int)lector["MinutosDuracion"];

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
