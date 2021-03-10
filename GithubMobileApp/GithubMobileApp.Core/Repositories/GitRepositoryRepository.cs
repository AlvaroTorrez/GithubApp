using GithubMobileApp.Core.Models;
using GithubMobileApp.Core.Repositories.Interfaces;
using GithubMobileApp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.Core.Repositories
{
    public class GitRepositoryRepository : IGitRepositoryRepository
    {
        private IRepositoryRequestService _repositoryRequestService;
        public GitRepositoryRepository(IRepositoryRequestService repositoryRequestService)
        {
            _repositoryRequestService = repositoryRequestService;
        }
        public async Task<IEnumerable<GitRepository>> GetAllRepositoriesByUser(string user)
        {
            var result = await _repositoryRequestService.RequestAllRepositoriesByUserName(user, new Dictionary<string, string>());
            return result;
        }
    }
}
