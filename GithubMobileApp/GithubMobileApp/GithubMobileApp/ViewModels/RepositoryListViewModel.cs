using GithubMobileApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.ViewModels
{
    public class RepositoryListViewModel : BaseViewModel<User>
    {
        public User User { get; set; }

        public ObservableCollection<GitRepository> GitRepositoriesSource { get; set; }

        public RepositoryListViewModel()
        {
            GitRepositoriesSource = new ObservableCollection<GitRepository>();

            GitRepositoriesSource.Add(new GitRepository
            {
                RepositoryName = "Test name",
                Description = "Test Description",
                ForksCount = 10,
                OpenIssuesCount = 20,
                UrlRepository = "https://github.com/AlvaroTorrez/GithubApp"
            });
        }

        public override void Prepare(User date)
        {
            base.Prepare(date);
            User = date;
        }

        public override async Task Initialization()
        {

        }

    }
}
