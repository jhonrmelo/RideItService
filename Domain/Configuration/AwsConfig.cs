namespace Domain.Configuration
{
    public class AwsConfig
    {
        public string Profile { get; set; }
        public string Region { get; set; }
        public Credentials Credentials { get; set; }
    }

    public class Credentials
    {
        public string AccessKeyId { get; set; }
        public string SecretAccessKey { get; set; }
    }
}