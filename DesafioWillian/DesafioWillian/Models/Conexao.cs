﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DesafioWillian.Models
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            string conexao = @"Data Source=DESKTOP-U8NPKH2\SQLEXPRESS;Initial Catalog=DesafioC1Willian;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();

            return connection;
        }

    }
}
