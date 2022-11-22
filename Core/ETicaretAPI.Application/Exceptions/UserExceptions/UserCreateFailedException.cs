namespace ETicaretAPI.Application.Exceptions.UserExceptions
{
    public class UserCreateFailedException : Exception
    {
        public UserCreateFailedException() : base("Kullanıcı Oluşturulurken Beklenmeyen Bir Hata İle Karşılaşıldı!") { }
        public UserCreateFailedException(string? message) : base(message) { }
        public UserCreateFailedException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
