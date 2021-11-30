using System.Web.Http;
using WebServiceAltamira.BL;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.Controllers
{
    [Authorize]
    public class GetPagoTributosController : ApiController
    {
        private PagosTributos pagosTrib;

        public GetPagoTributosController()
        {
            pagosTrib = new PagosTributos();
        }
        public PagosTributosModel GetPagos(int id)
        {
            PagosTributosModel model = pagosTrib.GetPagoTributosModelById(id);

            return model;
        }
    }
}