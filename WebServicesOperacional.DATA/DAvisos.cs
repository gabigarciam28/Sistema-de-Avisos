//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServicesOperacional.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class DAvisos
    {
        public int ID { get; set; }
        public int CodGrupoAvisos { get; set; }
        public Nullable<int> CodGrupo { get; set; }
        public int CodTipoAviso { get; set; }
        public string Icono { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string Mensaje { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public string Html { get; set; }
        public bool IsCodigo { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}