using Fofoquinha.Models;
using Fofoquinha.Services.Password;
using Fofoquinha.Services.Profiles;
using Fofoquinha.UseCases.CreateProfile;

namespace Fofoquinha.UseCases;

public class CreateProfileUseCase(
    IProfilesService profilesService,
    IPasswordService passwordService
)
{
    public async Task<Result<CreateProfileResponse>> Do(CreateProfilePayload payload)
    {
        var profile = new Profile {
            Bio = payload.Bio,
            Email = payload.Email,
            Username = payload.Username,
            Password = passwordService.Hash(payload.Password)
        };

        await profilesService.Create(profile);

        return Result<CreateProfileResponse>.Success(new());
    }
}