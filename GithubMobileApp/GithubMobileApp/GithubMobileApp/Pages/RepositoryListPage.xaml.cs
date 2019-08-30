using GithubMobileApp.Core.Models;
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
    public partial class RepositoryListPage : ContentPage
    {
        public RepositoryListPage(User userInfo)
        {
            InitializeComponent();

            var viewModel = DependencyService.Resolve<RepositoryListViewModel>();

            BindingContext = viewModel;

            viewModel.Prepare(userInfo);
        }
    }
}