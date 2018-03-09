using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Web_Api.Model
{
    class JugadoresModel
    {
        public string Id { get; set; }
        public string sNombre { get; set; }
        public int iEdad { get; set; }
        public string sPosicion { get; set; }
        public EquiposModel sEquipo { get; set; }
        public string sNacionalidad { get; set; }
        public string uNacionalidad { get; set; }
        public JugadoresModel(string sNombre, int sEdad, string sPosicion, EquiposModel sEquipo, string sNacionalidad, string uNacionalidad)
        {
            this.sNombre = sNombre;
            this.iEdad = sEdad;
            this.sPosicion = sPosicion;
            this.sEquipo = sEquipo;
            this.sNacionalidad = sNacionalidad;
            this.uNacionalidad = uNacionalidad;
        }

    }
}
