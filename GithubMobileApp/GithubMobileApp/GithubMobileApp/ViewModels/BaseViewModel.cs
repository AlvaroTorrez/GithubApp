using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace GithubMobileApp.ViewModels
{
    public class BaseViewModel<T> : BaseViewModel
    {

        public virtual void Prepare(T date)
        {
            Prepare();
        }
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

        public virtual void Prepare()
        {
            Task.Run(async () => {
                await Initialization();
            });
        }
    }
}
