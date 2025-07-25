namespace Fofoquinha.UseCases.PublishPost;

public record PublishPostPayload(
    string Title,
    string Content,
    Guid ProfileID,
    DateTime Date
);