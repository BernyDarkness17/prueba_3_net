using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Prueba_3_Bernardita_Antilaf.model {
    public class Conexion {
        private SqlConnection con; // Connection
        private SqlCommand sen;	// Statement
        public SqlDataReader rs; // ResultSet

        public Conexion(String bd) {
            con = new SqlConnection(
                "Data Source=localhost;" +
                "Initial Catalog=" + bd + "; " +
                "User id=sa; " +
                "Password=123456;"
            );
        }

        public DataTable Ejecutar(String query) {
            Console.WriteLine("QUERY=" + query);
            DataTable dt = null;

            con.Open();
            sen = new SqlCommand(query, con);

            if (query.ToLower().Contains("select")) {
                rs = sen.ExecuteReader();
                dt = new DataTable();
                dt.Load(rs);
            } else { //insert, update, delete
                sen.ExecuteNonQuery();
            }
            Cerrar();

            return dt;
        }

        public void Cerrar() {
            con.Close();
        }
    }
}