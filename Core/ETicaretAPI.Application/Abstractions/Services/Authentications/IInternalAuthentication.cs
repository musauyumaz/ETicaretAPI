namespace ETicaretAPI.Application.Abstractions.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<DTOs.Token> LoginAsync(string usernameOrEmail,string password, int accessTokenLifetime);
        Task<DTOs.Token> RefreshTokenLoginAsync(string refreshToken);
    }
    
}
