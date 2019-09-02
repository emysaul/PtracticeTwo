using Pact2.Model;
using Pact2.View.MasterDetail;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pact2.ModelView
{
    public class LoginUserModelView : INotifyPropertyChanged
    {
        public User User { get; set; } = new User();

        public string Result { get; set; } = string.Empty;

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public LoginUserModelView()
        {
            LoginCommand = new Command(async () =>
           {
               if (UserModelView.ExistsUserLogin(User))
                   await App.Current.MainPage.Navigation.PushAsync(new MainPage(new WelcomeUser()));
               else
                   Result = "Usuario o contraseña no valido";
           });

            RegisterCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
