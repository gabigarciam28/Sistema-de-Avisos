using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceAltamira.DATA;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.BL
{
    public class PagosComunidades
    {
        private Operacional_AAMEntities AltamiraEntities;
        public PagosComunidades()
        {
            this.AltamiraEntities = new Operacional_AAMEntities();
        }

        public PagosComunidadesModel GetPagoComunidadesModelById(int id)
        {
            GET_COMUNIDADES pagoComunidad = AltamiraEntities.GET_COMUNIDADES.FirstOrDefault(e => e.ID_INMUEBLE == id);

            PagosComunidadesModel pagoComunidadModel = new PagosComunidadesModel();

            pagoComunidadModel.PK_ACTIVO = pagoComunidad.PK_ACTIVO;
            pagoComunidadModel.IMP_TOTAL_CUOTA = pagoComunidad.IMP_TOTAL_CUOTA;
            pagoComunidadModel.Periodicidad_Cuota = pagoComunidad.Periodicidad_Cuota;
            pagoComunidadModel.IMP_TOTAL_DERRAMA = pagoComunidad.IMP_TOTAL_DERRAMA;
            pagoComunidadModel.Periodicidad_Derrama = pagoComunidad.Periodicidad_Derrama;

            return pagoComunidadModel;
        }
    }
}