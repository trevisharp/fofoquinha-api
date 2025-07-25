using Fofoquinha.UseCases;
using Fofoquinha.UseCases.CreateProfile;
using Fofoquinha.UseCases.GetProfileData;
using Microsoft.AspNetCore.Mvc;

namespace Fofoquinha.Endpoints;

public static class ProfileEndpoints
{
    public static void ConfigureProfileEndpoints(this WebApplication app)
    {
        app.MapGet("profile/{username}", async (
            string username,
            [FromServices]GetProfileDataUseCase useCase) =>
        {
            var payload = new GetProfileDataPayload(username);
            var result = await useCase.Do(payload);

            return (result.IsSuccess, result.Reason) switch
            {
                (false, "User not found")  => Results.NotFound(),
                (false, _) => Results.InternalServerError(),
                (true, _) => Results.Ok(result.Data)
            };

        });

        app.MapPost("profile", async (
            [FromBody]CreateProfilePayload payload, 
            [FromServices]CreateProfileUseCase useCase) =>
        {
            var result = await useCase.Do(payload);
            if (result.IsSuccess)
                return Results.Ok();
            
            return Results.BadRequest(result.Reason);
        });
    }
}