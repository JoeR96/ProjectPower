namespace ProjectPowerWebApi.Controllers.Areas.Login.TokenResources
{
    public class AccessTokenModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long Expiration { get; set; }
    }
}
