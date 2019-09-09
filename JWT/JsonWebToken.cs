namespace Intech.Lib.Web.JWT
{
    public class JsonWebToken
    {
        public string AccessToken { get; set; }
        public bool Authenticated { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }
        public string Message { get; set; }
        public bool Pensionista { get; set; }
    }
}