using Newtonsoft.Json;

namespace App.Controllers.Resources
{
    public class TokenResource
    {
        public string Username { get; set; }

        [JsonProperty(PropertyName = "access_token", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "id_token", NullValueHandling = NullValueHandling.Ignore)]
        public string IdToken { get; set; }

        [JsonProperty(PropertyName = "token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}