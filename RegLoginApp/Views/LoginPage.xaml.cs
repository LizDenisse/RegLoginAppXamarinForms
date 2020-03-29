using System;
using System.Collections.Generic;
using System.IO;
using SQLitePCL;
using SQLite;
using Xamarin.Forms;
using RegLoginApp.Tables;

namespace RegLoginApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text));

            if(myquery!=null)
            {
                App.Current.MainPage = new NavigationPage(new HomePage()); 
            }

       else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed User Name and Password", "Yes", "Cancel");      
                    if (result)
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                });
            }
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

    }
}
