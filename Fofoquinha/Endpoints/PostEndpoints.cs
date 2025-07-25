using Fofoquinha.UseCases.DeletePost;
using Fofoquinha.UseCases.PublishPost;
using Microsoft.AspNetCore.Mvc;

namespace Fofoquinha.Endpoints;

public static class PostEndpoints
{
    public static void ConfigurePostEndpoints(this WebApplication app)
    {
        app.MapGet("post/{id}", (string id) =>
        {

        });

        app.MapPost("post", async (
            [FromBody]PublishPostPayload payload,
            [FromServices]PublishPostUseCase useCase) =>
        {
            var result = await useCase.Do(payload);
            
            return (result.IsSuccess, result.Reason) switch
            {
                (false, "Post not found") => Results.NotFound(),
                (false, _) => Results.BadRequest(),
                (true, _) => Results.Ok(result.Data)
            };
        });

        app.MapDelete("post/{id}", async (string id, 
            [FromServices]DeletePostUseCase useCase) =>
        {
            var postId = Guid.Parse(id);
            Guid userId = Guid.Empty; // ????
            var payload = new DeletePostPayload(postId, userId);
            var result = await useCase.Do(payload);

            return (result.IsSuccess, result.Reason) switch
            {
                (false, "Post not found") => Results.NotFound(),
                (false, _) => Results.BadRequest(),
                (true, _) => Results.Ok()
            };
        });
    }
}