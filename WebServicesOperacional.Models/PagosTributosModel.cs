using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceAltamira.Models
{
    public class PagosTributosModel
    {
        public Nullable<int> PK_ACTIVO { get; set; }
        public string Periodicidad_IBI { get; set; }
        public Nullable<decimal> IMP_IBI { get; set; }
        public string Periodicidad_Alcantarillado { get; set; }
        public Nullable<decimal> IMP_Alcantarillado { get; set; }
        public string Periodicidad_Basura { get; set; }
        public Nullable<decimal> IMP_Basura { get; set; }
        public string Periodicidad_Vado { get; set; }
        public Nullable<decimal> IMP_Vado { get; set; }
        public Nullable<decimal> Total_imp_otros { get; set; }
        public string periodicidad_otros { get; set; }
    }
}