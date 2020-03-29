using System;
using System.Collections.Generic;
using System.IO;
using RegLoginApp.Tables;
using SQLite.Net;
using Xamarin.Forms;
using SQLite;
using SQLitePCL;

using Xamarin.Forms;

namespace RegLoginApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            var user = new RegUserTable();
            MyLabel.Text = user.UserName;


        }

       async void Logout(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new LoginPage());
          
        }

        //public string GetName()
        //{
        //    string dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
        //    var db = new SQLite.SQLiteConnection(dbpath);
        //    string USn= db.

        //}
    }
}
