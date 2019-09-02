using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pact2.View.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage(WelcomeUser welcomeUser = null)
        {
            InitializeComponent();

            this.Master = new MasterPage();

            if (welcomeUser == null)
                this.Detail = new NavigationPage(new RegisterPage()) { BarBackgroundColor = Color.Red };
            else
                this.Detail = new NavigationPage(welcomeUser) { BarBackgroundColor = Color.Red };
        }
    }
}