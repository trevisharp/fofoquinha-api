namespace Fofoquinha.UseCases.Login;

public class LoginUseCase
{
    public async Task<Result<LoginResponse>> Do(LoginPayload payload)
    {
        return Result<LoginResponse>.Success(null);
    }
}