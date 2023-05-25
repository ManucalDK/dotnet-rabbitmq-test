using Microsoft.AspNetCore.Mvc;

namespace BrokerExample.Presentation.EndPoints
{
    public static class MessageApi
    {
        public static void MessageEndpoints(this WebApplication app)
        {
            //Obtener todos los mensajes
            app.MapGet("/Messages", () =>
            {
                return Results.Ok($"Test Get: {Guid.NewGuid().ToString()}");
            });

            //Obtener un mensaje consultado por Id
            app.MapGet("/Messages/{id}", (int id) =>
            {
                return Results.Ok($"Test Get: id = {id} - {Guid.NewGuid().ToString()}");
            });

            //Registrar Mensaje
            app.MapPost("/Messages", async () =>
            {
                var IdMessage = await Task.FromResult(Guid.NewGuid().ToString());
                return Results.Ok($"Mensaje Creado: {IdMessage}");
            });
        }
    }
}
