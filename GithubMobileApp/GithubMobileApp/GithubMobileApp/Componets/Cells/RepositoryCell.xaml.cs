using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GithubMobileApp.Componets.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RepositoryCell : ViewCell
    {
        public RepositoryCell()
        {
            InitializeComponent();
        }

        private async void TapOpenBrowserLink(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                await Browser.OpenAsync(label.Text, new BrowserLaunchOptions
                {
                    LaunchMode = BrowserLaunchMode.SystemPreferred,
                    TitleMode = BrowserTitleMode.Show,
                    PreferredToolbarColor = Color.AliceBlue,
                    PreferredControlColor = Color.Violet
                });
            }
        }
    }
}