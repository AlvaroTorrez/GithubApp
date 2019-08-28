using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GithubMobileApp.Core.Models
{
    public class GitRepository : BaseModel
    {
        [JsonProperty("html_url")]
        public string UrlRepository { get; set; }

        [JsonProperty("name")]
        public string RepositoryName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        [JsonProperty("forks_count")]
        public int ForksCount { get; set; }
    }
}
