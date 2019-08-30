using GithubMobileApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.Core.Repositories.Interfaces
{
    public interface IGitRepositoryRepository
    {
        Task<IEnumerable<GitRepository>> GetAllRepositoriesByUser(string user);
    }
}
