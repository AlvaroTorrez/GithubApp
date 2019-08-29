using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.ViewModels
{
    public class BaseViewModel<T> : BaseViewModel
    {

    }

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnAppearing()
        {

        }

        public virtual async Task Initialization()
        {
        }
    }
}
