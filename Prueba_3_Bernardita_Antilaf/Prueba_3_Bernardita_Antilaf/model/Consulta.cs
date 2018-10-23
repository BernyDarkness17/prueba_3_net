using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_3_Bernardita_Antilaf.model {
    public class Consulta {
        private int idPeli;
        private String nombrePe;
        private int idActor;
        private String nombreActor;
        private String nomPaisActor;

        public int IdPeli { get => idPeli; set => idPeli = value; }
        public string NombrePe { get => nombrePe; set => nombrePe = value; }
        public int IdActor { get => idActor; set => idActor = value; }
        public string NombreActor { get => nombreActor; set => nombreActor = value; }
        public string NomPaisActor { get => nomPaisActor; set => nomPaisActor = value; }
    }
}