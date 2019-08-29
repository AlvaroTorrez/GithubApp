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
    public class UserRequestService : IUserRequestService
    {
        public async Task<IEnumerable<User>> RequestAllUsers(Dictionary<string, string> parameters = null)
        {
            var currentEndPoint = EndPoints.USER_END_POINT;
            currentEndPoint = currentEndPoint.SetQueryParams(parameters);
            IEnumerable<User> result = null;
            try
            {
                result = await currentEndPoint.WithHeader("User-Agent", "request").GetJsonAsync<IEnumerable<User>>();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }
            
            return result;
        }
    }
}
