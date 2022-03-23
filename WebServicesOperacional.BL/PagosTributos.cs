using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceAltamira.DATA;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.BL
{
    public class PagosTributos
    {
        private Operacional_AAMEntities AltamiraEntities;
        public PagosTributos()
        {
            this.AltamiraEntities = new Operacional_AAMEntities();
        }

        public PagosTributosModel GetPagoTributosModelById(int id)
        {
            GET_TRIBUTOS pagoTributo = AltamiraEntities.GET_TRIBUTOS.FirstOrDefault(e => e.ID_INMUEBLE == id);

            PagosTributosModel pagoTributoModel = new PagosTributosModel();

            pagoTributoModel.PK_ACTIVO = pagoTributo.PK_ACTIVO;
            pagoTributoModel.Periodicidad_IBI = pagoTributo.Periodicidad_IBI;
            pagoTributoModel.IMP_IBI = pagoTributo.IMP_IBI;
            pagoTributoModel.Periodicidad_Alcantarillado = pagoTributo.Periodicidad_Alcantarillado;
            pagoTributoModel.IMP_Alcantarillado = pagoTributo.IMP_Alcantarillado;
            pagoTributoModel.Periodicidad_Basura = pagoTributo.Periodicidad_Basura;
            pagoTributoModel.IMP_Basura = pagoTributo.IMP_Basura;
            pagoTributoModel.Periodicidad_Vado = pagoTributo.Periodicidad_Vado;
            pagoTributoModel.IMP_Vado = pagoTributo.IMP_Vado;
            pagoTributoModel.Total_imp_otros = pagoTributo.Total_imp_otros;
            pagoTributoModel.periodicidad_otros = pagoTributo.periodicidad_otros;

            return pagoTributoModel;
        }
    }
}