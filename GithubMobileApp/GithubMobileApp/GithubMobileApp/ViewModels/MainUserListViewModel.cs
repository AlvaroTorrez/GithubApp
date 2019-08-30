using GithubMobileApp.Core.Models;
using GithubMobileApp.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GithubMobileApp.ViewModels
{
    public class MainUserListViewModel : BaseViewModel
    {
        public ObservableCollection<User> UserList { get; set; }
        public bool IsBusy { get; set; }

        public bool IsBackUserListEnabled { get; set; }

        public ICommand BackUserList { get; set; }
        public ICommand NextUserList { get; set; }

        private List<int> _initialIndexes;

        public readonly IUserRepository _userRepository;
        public MainUserListViewModel(IUserRepository userRepository)
        {
            UserList = new ObservableCollection<User>();
            _userRepository = userRepository;
            IsBusy = false;
            _initialIndexes = new List<int>();
            BackUserList = new Command(OnBackUserList);
            NextUserList = new Command(OnNextUserList);
            IsBackUserListEnabled = false;
        }

        private async void OnNextUserList(object obj)
        {
            IsBusy = true;
            _initialIndexes.Add(UserList.First().Id - 1);
            if (_initialIndexes.Count > 0)
            {
                IsBackUserListEnabled = true;
            }
            var users = await _userRepository.GetAllUser(UserList.Last().Id);
            UserList = new ObservableCollection<User>(users);
            IsBusy = false;
        }

        private async void OnBackUserList(object obj)
        {
            IsBusy = true;
            var users = await _userRepository.GetAllUser(_initialIndexes.Last());
            UserList = new ObservableCollection<User>(users);
            _initialIndexes.RemoveAt(_initialIndexes.Count - 1);
            if (_initialIndexes.Count == 0)
            {
                IsBackUserListEnabled = false;
            }
            IsBusy = false;
        }

        public override async Task Initialization()
        {
            IsBusy = true;
            var users = await _userRepository.GetAllUser();
            UserList = new ObservableCollection<User>(users);
            IsBusy = false;
        }
    }
}
