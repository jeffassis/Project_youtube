using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Youtube.project.connect
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            //string conexao
            string vcon = ConfigurationManager.ConnectionStrings["project_youtube"].ConnectionString;
            return new MySqlConnection(vcon);
        }
    }
}
