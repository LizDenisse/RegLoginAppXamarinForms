using System;
namespace RegLoginApp.Tables
{
    public class RegUserTable
    {
       
            public Guid UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

    }
}