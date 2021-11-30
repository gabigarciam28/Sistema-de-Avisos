using System;

namespace WebServiceAltamira.Models
{
    public class AvisosModel
    {
        public int CodGrupoAvisos { get; set; }
        public int CodGrupo { get; set; }
        public int CodTipoAviso { get; set; }
        public string Icono { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Mensaje { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Html { get; set; }
        public bool IsCodigo { get; set; }

    }
}
