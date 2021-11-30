using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.IO;
using System.Net;
using WebServiceAltamira.Models;

namespace WebServiceAltamira.Client
{
    public class HubClient
    {

        public HubClient()
        {
            
        }

        public String Authenticate()
        {
            HubModel Hub = new HubModel();
            try
            {
                //AUTENTICACION EN WEB API
                LoginRequest ModelLogin = new LoginRequest();
                ModelLogin.Username = "AltamiraAAMHub";
                ModelLogin.Password = ".Altamira$22.";

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(ModelLogin);
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();

                var http = (HttpWebRequest)WebRequest.Create(new Uri("https://uatdashboardapi.myaltamira.es/Users/Authenticate"));
                http.Accept = "application/json";
                http.ContentType = "application/json";
                http.Method = "POST";

                Byte[] bytes = encoding.GetBytes(json);

                Stream newStream = http.GetRequestStream();
                newStream.Write(bytes, 0, bytes.Length);
                newStream.Close();

                var response = http.GetResponse();

                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream);
                var result_ = new HubModel();

                String auth = sr.ReadToEnd().Replace("\"", "");

                return auth;

            }
            catch (Exception)
            {
                return "No se ha podido realizar la autenticación correctamente. Introduzca los creedenciales correctamente";
            }

        }

        public Boolean ChatHub(String token)
        {
            HubModel Hub = new HubModel();
            try
            {
                HubConnection connection;
                connection = new HubConnectionBuilder().WithUrl("http://localhost:53353/ChatHub").Build();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}