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

        public virtual Task Initialization()
        {
            return Task.CompletedTask;
        }

        public virtual void Prepare()
        {
            Task.Run(async () => {
                try
                {
                    await Initialization();
                }
                catch (System.OperationCanceledException ex)
                {
                    Console.WriteLine($"Text load cancelled: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            });
        }
    }
}
