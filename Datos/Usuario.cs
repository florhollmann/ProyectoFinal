using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Usuario
    {
        //metodo agregar (Lo recibe de logica)
        public void Agregar(Entidades.Usuario usuario)
        {
            string strConexion = @"Server=CPX-9D16UJP0XPA\TRAINING; database=proyectoFinal; Integrated Security= true";
            string strSQL = "insert Usuarios(Nombre, Apellido, Email) values(@Nombre, @Apellido, @Email)";

            SqlConnection objConexion = new SqlConnection();
            objConexion.ConnectionString = strConexion;
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strSQL;
            objCommand.Connection = objConexion;


            objCommand.Parameters.AddWithValue("@Nombre", usuario.NombreUsuario);
            objCommand.Parameters.AddWithValue("@Apellido", usuario.ApellidoUsuario);
            objCommand.Parameters.AddWithValue("@Email", usuario.EmailUsuario);


            objConexion.Open();
            objCommand.ExecuteNonQuery();
            objConexion.Close();

        }
    }    
}
