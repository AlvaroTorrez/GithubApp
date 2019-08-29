using GithubMobileApp.Core.Models;
using GithubMobileApp.Core.Repositories.Interfaces;
using GithubMobileApp.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserRequestService _userRequestService;
        public UserRepository(IUserRequestService userRequestService)
        {
            _userRequestService = userRequestService;
        }
        public async Task<IEnumerable<User>> GetAllUser(int since = 0)
        {
            // In this part we verified if we are online
            // for this exmple we are supost online
            var result = await _userRequestService.RequestAllUsers( new Dictionary<string, string> {
                {"since", since.ToString()}
            });
            return result;
        }
    }
}
