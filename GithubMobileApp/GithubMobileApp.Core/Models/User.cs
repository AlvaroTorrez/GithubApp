using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GithubMobileApp.Core.Models
{
    public class User : BaseModel
    {
        [JsonProperty("login")]
        public string UserName { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("html_url")]
        public string UserUrl { get; set; }
    }
}
