using GithubMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GithubMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainUserListPage : ContentPage
    {
        public MainUserListPage()
        {
            InitializeComponent();

            var viewModel = DependencyService.Resolve<MainUserListViewModel>();
            BindingContext = viewModel;

            viewModel.Initialization();
        }
    }
}