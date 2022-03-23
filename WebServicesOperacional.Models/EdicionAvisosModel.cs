using System;

namespace WebServiceAltamira.Models
{
    public class EdicionAvisosModel 
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime Duracion { get; set; }
        public string Mensaje { get; set; }
        //public string Html { get; set; }
        //public string HtmlDecode
        //{
        //    get
        //    {
        //        return HttpUtility.HtmlDecode(Html);
        //    }
        //}
        public int? CodGrupo { get; set; }
        public int CodGrupoAvisos { get; set; }
        public bool IsCodigo { get; set; }
        public string MensajeOld { get; set; }
        public int? IDold { get; set; }


    }
}
