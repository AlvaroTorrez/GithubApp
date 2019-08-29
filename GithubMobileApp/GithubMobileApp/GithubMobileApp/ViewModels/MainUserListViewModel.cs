using GithubMobileApp.Core.Models;
using GithubMobileApp.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.ViewModels
{
    public class MainUserListViewModel : BaseViewModel
    {
        public ObservableCollection<User> UserList { get; set; }
        public readonly IUserRepository _userRepository;
        public MainUserListViewModel(IUserRepository userRepository)
        {
            UserList = new ObservableCollection<User>();
            _userRepository = userRepository;
            //*************** Temp Mock **********************;
/*
            UserList.Add(new User {
                UserName = "Juan",
                AvatarUrl = "https://avatars2.githubusercontent.com/u/790012?s=200&v=4",
                UserUrl = "https://github.com/AlvaroTorrez"
            });

            UserList.Add(new User
            {
                UserName = "Pepe",
                AvatarUrl = "https://avatars2.githubusercontent.com/u/790012?s=200&v=4",
                UserUrl = "https://github.com/AlvaroTorrez"
            });

            UserList.Add(new User
            {
                UserName = "Rosa",
                AvatarUrl = "https://avatars2.githubusercontent.com/u/790012?s=200&v=4",
                UserUrl = "https://github.com/AlvaroTorrez"
            });

            UserList.Add(new User
            {
                UserName = "Elemer",
                AvatarUrl = "https://avatars2.githubusercontent.com/u/790012?s=200&v=4",
                UserUrl = "https://github.com/AlvaroTorrez"
            });*/
        }

        public override async Task Initialization()
        {
            var users = await _userRepository.GetAllUser();
            UserList = new ObservableCollection<User>(users);
        }
    }
}
