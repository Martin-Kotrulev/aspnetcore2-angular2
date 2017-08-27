using Newtonsoft.Json;

namespace App.Controllers.Resources
{
    public class TokenResource
    {
        public string Username { get; set; }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "id_token")]
        public string IdToken { get; set; }
    }
}