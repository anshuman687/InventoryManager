using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using InverntoryManager.Pages;
using Xamarin.Forms;

namespace InverntoryManager.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public LoginViewModel()
        {
            Title = "Log In";
        }

        // This Commond to click then Navigate to Service URL Screen
        public Command ServiceURLCommond
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new ServiceURLPage(), true);
                });
            }
        }

        // This Commond to click then Navigate to Service URL Screen
        public Command PasswordShowCommond
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new ServiceURLPage(), true);
                });
            }
        }

        // This Commond Use For Login
        public Command LogInCommond
        {
            get
            {
                return new Command(LoginFunction);
            }
        }

        private void LoginFunction(object obj)
        {
            try
            {
                Application.Current.MainPage = new MasterDetailPage1();
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
            finally
            {
                
            }
            
        }
    }
}
