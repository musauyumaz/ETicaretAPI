namespace ETicaretAPI.Application.Exceptions.UserExceptions
{
    public class NotFoundUserException : Exception
    {
        public NotFoundUserException() : base("Kullanıcı Adı veya Şifre Hatalı!") { }
        public NotFoundUserException(string? message) : base(message) { }
        public NotFoundUserException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
