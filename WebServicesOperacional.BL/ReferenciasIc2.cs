using System.Collections.Generic;
using System.Linq;
using WebServiceAltamira.DATA;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.BL
{
    public class ReferenciasIc2
    {
        private DCOMEntities dcomEntities;
        public ReferenciasIc2()
        {
            this.dcomEntities = new DCOMEntities();
        }

        public ReferenciasIc2Model GetReferenciaIc2ModelById(int id)
        {
            ReferenciasIc2Model referenciaIc2Model = new ReferenciasIc2Model();


            var referenciaIc2 = dcomEntities.vwReferenciasIC2.FirstOrDefault(e => e.IDINMUEBLE == id);

            referenciaIc2Model.IDINMUEBLE = referenciaIc2.IDINMUEBLE;
            referenciaIc2Model.ESTANDAR = referenciaIc2.ESTANDAR;
            referenciaIc2Model.ALTERNATIVA = referenciaIc2.ALTERNATIVA;


            return referenciaIc2Model;
        }

        public List<ReferenciasIc2Model> GetReferenciasMasivas(ReferenciasMasivasModel model)
        {

            List<ReferenciasIc2Model> lista = new List<ReferenciasIc2Model>();

            
            foreach (int valor in model.IDINMUEBLE)
            {
                ReferenciasIc2Model referenciaIc2Model = new ReferenciasIc2Model();
                var referenciaIc2 = dcomEntities.vwReferenciasIC2.FirstOrDefault(e => e.IDINMUEBLE == valor);

                referenciaIc2Model.IDINMUEBLE = referenciaIc2.IDINMUEBLE;
                referenciaIc2Model.ESTANDAR = referenciaIc2.ESTANDAR;
                referenciaIc2Model.ALTERNATIVA = referenciaIc2.ALTERNATIVA;

                lista.Add(referenciaIc2Model);
            }
            
            return lista;
        }
    }
}