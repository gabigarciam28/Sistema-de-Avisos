using System.Web.Http;
using WebServiceAltamira.BL;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.Controllers
{
    [Authorize]
    public class GetPagoComunidadesController : ApiController
    {
        private PagosComunidades pagosComu;

        public GetPagoComunidadesController()
        {
            pagosComu = new PagosComunidades();
        }
        public PagosComunidadesModel GetPagos(int id)
        {
            PagosComunidadesModel model = pagosComu.GetPagoComunidadesModelById(id);

            return model;
        }
    }
}