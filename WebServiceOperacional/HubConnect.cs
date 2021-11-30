using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace SignalRChatClient
{
    public partial class MainWindow
    {
        HubConnection connection;
        public MainWindow()
        {

            connection = new HubConnectionBuilder()
                .WithUrl("http://localhost:53353/ChatHub")
                .Build();

            connection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0,5) * 1000);
                await connection.StartAsync();
            };
        }

       

        private async void EnviarMensaje()
        {
            try
            {
                await connection.InvokeAsync("SendMessage", 
                    "", "");
            }
            catch (Exception)
            {                
                            
            }
        }
    }
}