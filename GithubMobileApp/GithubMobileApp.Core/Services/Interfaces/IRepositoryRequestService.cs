using GithubMobileApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.Core.Services.Interfaces
{
    public interface IRepositoryRequestService
    {
        Task<IEnumerable<GitRepository>> RequestAllRepositoriesByUserName(string userName, Dictionary<string, string> parameters = null);
    }
}
