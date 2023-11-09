
using Newtonsoft.Json;

namespace ServicesDomain.Views.User
{
    public class UserCreationView
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("From")]
        public string From { get; set; }
    }
}
