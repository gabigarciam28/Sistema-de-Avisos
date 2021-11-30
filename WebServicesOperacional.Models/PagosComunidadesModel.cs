using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceAltamira.Models
{
    public class PagosComunidadesModel
    {
        public Nullable<int> PK_ACTIVO { get; set; }
        public Nullable<decimal> IMP_TOTAL_CUOTA { get; set; }
        public string Periodicidad_Cuota { get; set; }
        public Nullable<decimal> IMP_TOTAL_DERRAMA { get; set; }
        public string Periodicidad_Derrama { get; set; }
    }
}