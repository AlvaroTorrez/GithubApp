using GithubMobileApp.Core.Models;
using GithubMobileApp.Core.Repositories.Interfaces;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace GithubMobileApp.ViewModels
{
    public class RepositoryListViewModel : BaseViewModel<User>
    {
        public User User { get; set; }

        public ObservableCollection<GitRepository> GitRepositoriesSource { get; set; }

        private IGitRepositoryRepository _gitRepositoryRepository;

        public RepositoryListViewModel(IGitRepositoryRepository gitRepositoryRepository)
        {
            _gitRepositoryRepository = gitRepositoryRepository;
            GitRepositoriesSource = new ObservableCollection<GitRepository>();
        }

        public override void Prepare(User date)
        {
            base.Prepare(date);
            User = date;
        }

        public override async Task Initialization()
        {
            var repositoriesResult = await _gitRepositoryRepository.GetAllRepositoriesByUser(User.UserName);
            GitRepositoriesSource = new ObservableCollection<GitRepository>(repositoriesResult);
        }

    }
}
