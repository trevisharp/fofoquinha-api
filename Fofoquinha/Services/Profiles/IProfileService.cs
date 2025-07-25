using Fofoquinha.Models;

namespace Fofoquinha.Services.Profiles;

public interface IProfilesService
{
    Task<Profile> FindByLogin(string login);
    Task<Guid> Create(Profile profile);
}