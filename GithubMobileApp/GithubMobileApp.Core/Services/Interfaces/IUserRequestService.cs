using GithubMobileApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.Core.Services.Interfaces
{
    public interface IUserRequestService
    {
        Task<IEnumerable<User>> RequestAllUsers(Dictionary<string, string> parameters = null);
    }
}
