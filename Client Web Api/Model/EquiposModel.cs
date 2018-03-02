
using System;

namespace Client_Web_Api.Model
{
    class EquiposModel
    {
        public string Id { get; set; }
        public string sNombre { get; set; }
        public string sEstadio { get; set; }
        public Uri uEstadio { get; set; }
        public Uri uEscudo { get; set; }

        public EquiposModel(string sNombre, string sEstadio, Uri uEstadio, Uri uEscudo)
        {
            this.sNombre = sNombre;
            this.sEstadio = sEstadio;
            this.uEstadio = uEstadio;
            this.uEscudo = uEscudo;
        }
    }
}
