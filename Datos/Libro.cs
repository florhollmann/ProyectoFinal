using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Libro
    {
        //metodo agregar (Lo recibe de logica)
        public void Agregar(Entidades.Libro libro)
        {
            string strConexion = @"Server=CPX-9D16UJP0XPA\TRAINING; database=proyectoFinal; Integrated Security= true";
            string strSQL = @"insert Libros(IsbnLibro, NombreLibro, NombreAutor, ApellidoAutor)
                            values(@IsbnLibro, @NombreLibro, @NombreAutor, @ApellidoAutor)";
            SqlConnection objConexion = new SqlConnection();
            // objConexion es un instancia de la clase SQLCONNECTION
            objConexion.ConnectionString = strConexion;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;
            objCommand.Connection = objConexion;

            //Todavia no puedo ejecutar estos comandos porque faltan los parametros!
            //Cuales son los valores de @IsbnLibro? 
            //Los parametros son propiedades
            //parameters:
            objCommand.Parameters.AddWithValue("@IsbnLibro", libro.IsbnLibro);
            objCommand.Parameters.AddWithValue("@NombreLibro", libro.NombreLibro);
            objCommand.Parameters.AddWithValue("@NombreAutor", libro.NombreAutor);
            objCommand.Parameters.AddWithValue("@ApellidoAutor", libro.ApellidoAutor);

            //abro la conexion
            objConexion.Open();
            objCommand.ExecuteNonQuery();
            objConexion.Close();
        }

        }
    }
