namespace Fofoquinha.Endpoints;

public static class ProfileEndpoints
{
    public static void ConfigureProfileEndpoints(this WebApplication app)
    {
        app.MapGet("profile/{username}", (string username) =>
        {

        });

        app.MapPost("profile", () =>
        {

        });
    }
}