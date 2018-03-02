
namespace Client_Web_Api.Model
{
    class EquiposModel
    {
        public string Id { get; set; }
        public string sNombre { get; set; }
        public string sEstadio { get; set; }
        public string uEstadio { get; set; }
        public string uEscudo { get; set; }

        public EquiposModel(string sNombre, string sEstadio,string uEstadio, string uEscudo)
        {
            this.sNombre = sNombre;
            this.sEstadio = sEstadio;
            this.uEstadio = uEstadio;
            this.uEscudo = uEscudo;
        }
    }
}
