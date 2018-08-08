using System;
using System.Collections.Generic;
using System.Linq;


namespace PointOfSalesApp.Model
{
    interface IModel
    {
         int id { get; set; }
         string name { get; set; }
         string username { get; set; }
         string userPassword { get; set; }
         string designation { get; set; }
         string contact { get; set; }
         string email { get; set; }
         Nullable<int> birthdate { get; set; }
         Nullable<int> age { get; set; }
         string emergencyContact { get; set; }
         string emergencycontactNum { get; set; }
         string userImage { get; set; }

        int validateLogin();
        bool validateInputs();
    }
}
