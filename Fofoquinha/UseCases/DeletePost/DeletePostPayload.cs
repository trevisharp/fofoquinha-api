namespace Fofoquinha.UseCases.DeletePost;

public record DeletePostPayload(
    Guid PostId,
    Guid UserId
);