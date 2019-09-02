using Pact2.Helper;
using Pact2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pact2.ModelView
{
    public class UserModelView : INotifyPropertyChanged
    {
        public static List<User> Users = new List<User>();

        public INavigation Navigation { get; set; }
        public User User { get; set; } = new User();

        public string ConfirmatedPassword { get; set; }

        public string Result { get; set; } = string.Empty;

        public ICommand RegisterCommand { get; set; }

        public UserModelView(INavigation navigation)
        {
            Navigation = navigation;

            RegisterCommand = new Command(async () =>
            {
                if (IsValidUser())
                {
                    RegisterUser();

                    this.Result = "User Registered";

                    await Navigation.PopAsync();
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;



        private void RegisterUser()
        {
            Users.Add(User);

            /// TODO: IT IS NECESSARY TO CREATE A PROCESS TO REGISTER FOR SOME SERVICE OR DATABASE
        }

        private bool IsValidUser()
        {
            if (string.IsNullOrEmpty(User.UserName))
            {
                this.Result = "Not Registered: Name not valid.";
                return false;
            }

            if (!RegexValidator.ValidEmail(User.Email))
            {
                this.Result = "Not Registered Email not valid.";
                return false;
            }

            if (string.IsNullOrEmpty(ConfirmatedPassword) || ConfirmatedPassword != User.Password)
            {
                this.Result = "Not Registered: Password are not the same or not valid.";
                return false;
            }

            if (Users.Any(e => e.UserName == User.UserName))
            {
                this.Result = "Not Registered: Usuario existente";
                return false;
            }
            return true;
        }

        public static bool ExistsUserLogin(User user)
        {
            return Users.Any(e => e.UserName == user.UserName && e.Password == user.Password);
        }
    }
}
