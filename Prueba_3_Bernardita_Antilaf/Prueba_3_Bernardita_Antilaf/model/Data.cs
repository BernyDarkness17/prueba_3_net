using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba_3_Bernardita_Antilaf.model {
    public class Data : Conexion {
        private List<Consulta> lista;
        public Data() : base("bd_peliculas") {
            lista = new List<Consulta>();   
        }

        public List<Consulta> read() {
            List<Consulta> algo = new List<Consulta>();
            Consulta a;

            DataTable dt = Ejecutar("SELECT;");

            for (int i = 0; i < dt.Rows.Count; i++) {
                a = new Consulta();

                a.IdPeli = int.Parse(dt.Rows[i][0].ToString());
                a.NombrePe = dt.Rows[i][1].ToString();
                a.IdActor = int.Parse(dt.Rows[i][2].ToString());
                a.NombreActor = dt.Rows[i][3].ToString();
                a.NomPaisActor = dt.Rows[i][4].ToString();

                algo.Add(a);
            }
            return algo;
        }
    }
}