using System;
using System.Collections.Generic;
using System.IO;
using RegLoginApp.Tables;
using SQLite.Net;
using Xamarin.Forms;
using SQLite;
using SQLitePCL;



namespace RegLoginApp.Views
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");

            var db = new SQLite.SQLiteConnection(dbpath); 
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryPhoneNumber.Text

            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations", "User Registration Succesfull", "yes", "cancel");
            });

        }
    }
}
