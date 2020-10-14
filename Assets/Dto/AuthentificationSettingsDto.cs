namespace Assets.Dto
{
    public class AuthentificationSettingsDto
    {
        public const string name = "AuthentificationSettings";
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}

