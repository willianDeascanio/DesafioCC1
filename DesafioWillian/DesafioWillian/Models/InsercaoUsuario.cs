using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DesafioWillian.Models
{
    public class InsercaoUsuario
    {
        public static void InsereUsuario(string nome, int idade, string email)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();
            command.CommandText = $"INSERT usuarios values (@nome, @idade, @email)";

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@idade", idade);
            command.Parameters.AddWithValue("@email", email);

            command.ExecuteNonQuery();


        }
    }
}
