using Flurl;
using Flurl.Http;
using GithubMobileApp.Core.Models;
using GithubMobileApp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.Core.Services
{
    public class RepositoryRequestService : IRepositoryRequestService
    {
        public async Task<IEnumerable<GitRepository>> RequestAllRepositoriesByUserName(string userName, Dictionary<string, string> parameters = null)
        {  
            var currentEndPoint = string.Format("{0}/{1}/repos", EndPoints.USER_END_POINT, userName);
            currentEndPoint = currentEndPoint.SetQueryParams(parameters);
            IEnumerable<GitRepository> result = null;
            try
            {
                result = await currentEndPoint.WithHeader("User-Agent", "request").GetJsonAsync<IEnumerable<GitRepository>>();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            return result;
        }
    }
}
