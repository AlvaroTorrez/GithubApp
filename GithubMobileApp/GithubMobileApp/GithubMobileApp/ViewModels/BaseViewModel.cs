using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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
    }
}
