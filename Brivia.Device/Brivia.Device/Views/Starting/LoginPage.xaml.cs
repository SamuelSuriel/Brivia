using Brivia.Device.Models;
using Brivia.Device.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Brivia.Device.Views.Starting
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            var user = UserService.SearchUser(this.loginLbl.Text, this.passwordLbl.Text);
            if (user == null)
            {
                DisplayAlert("Error", "¡El usuario no pudo ser encontrado!", "OK");
                return;
            }
            Application.Current.MainPage = new SelectCategory();
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Register();
        }
    }
}