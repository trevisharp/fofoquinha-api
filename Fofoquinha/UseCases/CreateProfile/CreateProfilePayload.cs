namespace Fofoquinha.UseCases.CreateProfile;

public record CreateProfilePayload(
    string Username,
    string Email,
    string Password,
    string RepeatPassword,
    string Bio
);