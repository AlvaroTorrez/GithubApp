using GithubMobileApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GithubMobileApp.ViewModels
{
    public class MainUserListViewModel : BaseViewModel
    {
        public ObservableCollection<User> UserList { get; set; }

        public MainUserListViewModel()
        {
            UserList = new ObservableCollection<User>();

            //*************** Temp Mock **********************;

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
            });
        }
    }
}
