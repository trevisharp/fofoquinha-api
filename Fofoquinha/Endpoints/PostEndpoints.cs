namespace Fofoquinha.Endpoints;

public static class PostEndpoints
{
    public static void ConfigurePostEndpoints(this WebApplication app)
    {
        app.MapGet("post/{id}", (string id) =>
        {

        });

        app.MapPost("post", () =>
        {

        });

        app.MapDelete("post/{id}", (string id) =>
        {

        });
    }
}