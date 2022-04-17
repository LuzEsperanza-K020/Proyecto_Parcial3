using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class UsuariosDao
    {
        private const string ConnString = "server=(localdb)\\MSSQLLocalDB;database=ProyectoP3; Trusted_Connection=True";
        private const string sqlLogin = "select * from Usuarios where username = @nombreUsuarios;";

        public Usuarios buscarUsuarioPorUsername(string username, string password)
        {
            Usuarios user = null;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConnString;
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sqlLogin;
                command.Connection = connection;
                SqlParameter usernameParameter = new SqlParameter("@nombreUsuarios", username);
                command.Parameters.Add(usernameParameter);
                SqlDataReader dr = command.ExecuteReader();
                Console.WriteLine("Se encontro registro" + dr.HasRows);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if(password == dr.GetString("password"))
                        {
                            user = new Usuarios();
                            user.Id = dr.GetInt32("id");
                            user.Password = dr.GetString("password");
                            user.Nombre = dr.GetString("Nombre");
                            break;
                        }
                    }
                }
            }
            return user;
        }
    }
}
