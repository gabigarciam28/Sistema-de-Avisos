using System;
using System.Net;
using System.Web.Http;
using WebServiceAltamira.BL;
using WebServiceAltamira.Models;
using WebServiceAltamira.Client;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.Http.Connections;
using System.Threading.Tasks;
using System.Configuration;

namespace WebServiceAltamira.Controllers
{
    public class AvisosController : ApiController
    {
        private Avisos avisos;
        public AvisosController()
        {
            avisos = new Avisos();
        }

        [HttpPost]
        [Route("api/PostAvisos")]

        public async Task<string> CreateAvisos(AvisosModel model)
        {
            EdicionAvisosModel model1 = new EdicionAvisosModel();
            HubClient client = new HubClient();
            
            string token = client.Authenticate();
            model1.ID = 87; //El id se introducira despues de la insercion del aviso correspondiente en la tabla avisos
            model1.CodGrupo = 2722; //Siempre se tendra que establecer en 2722
            model1.CodGrupoAvisos = 3;//Siempre se tendra que establecer en 3
            model1.Duracion = DateTime.Now.AddDays(1); //Duración en días
            model1.Mensaje = "Tiene próxima la caducidad de contraseña de su usaurio, cambiela inmediatamente desde Ctrl-Alt-Supr, Cambiar Contraseña";
            model1.Nombre = "Recordatorio Password";
            model1.IsCodigo = true;

            LoginRequest ModelLogin = new LoginRequest();
            ModelLogin.Username = ConfigurationManager.AppSettings["MUsername"];
            ModelLogin.Password = ConfigurationManager.AppSettings["MPassword"];


            try
            {   
            var connection = new HubConnectionBuilder()
            .WithUrl(ConfigurationManager.AppSettings["UrlWS"], options => {
                //options.Headers["Foo"] = "Bar";
                options.SkipNegotiation = true;
                options.Transports = HttpTransportType.WebSockets;
                //options.Cookies.Add(new Cookie(/* ... */));
                options.AccessTokenProvider = () => Task.FromResult(token);
            }).Build();
                await connection.StartAsync();
                await connection.InvokeAsync("SendMyAltamiraWSSAsync", model1, 1);
            } catch (Exception)
            {

            }


            if (model == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                if (avisos.PostAvisos(model) != false) {
                    return "Inserción del aviso realizada correctamente";

                } else
                {
                    return "Inserción del aviso no realizada";
                }
                
            }
        }
    }
}