using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using WebServiceAltamira.BL;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.Controllers
{
    public class GetReferenciasIc2Controller : ApiController
    {
        private ReferenciasIc2 refIc2;

        public GetReferenciasIc2Controller()
        {
            refIc2 = new ReferenciasIc2();
        }
        public ReferenciasIc2Model GetReferencia(int id)
        {
            ReferenciasIc2Model model = refIc2.GetReferenciaIc2ModelById(id);

            return model;
        }

        [HttpPost]
        [Route("api/ReferenciasMasivas")]
        public List<ReferenciasIc2Model> GetReferenciasMasivas(ReferenciasMasivasModel model)
        {
             
            if (model == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {  
                List <ReferenciasIc2Model> model1 = refIc2.GetReferenciasMasivas(model);
                return model1;
            }
        }
    }
}
