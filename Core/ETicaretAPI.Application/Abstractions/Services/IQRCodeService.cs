namespace ETicaretAPI.Application.Abstractions.Services
{
    public interface IQRCodeService
    {
        byte[] GenerateQRCodeAsync(string text);
    }
}
