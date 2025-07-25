using Fofoquinha.UseCases.CreateProfile;

namespace Fofoquinha.UseCases;

public class CreateProfileUseCase
{
    public async Task<Result<CreateProfileResponse>> Do(CreateProfilePayload payload)
    {
        return Result<CreateProfileResponse>.Success(new());
    }
}