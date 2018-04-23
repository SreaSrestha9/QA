using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DemoPage.PageObjects
{
    class PersonalityTestPageObject
    {
        public static string foodList = "label.favfoodLabel~div label"; 

        public static string elementsList = "div.form-group > label";

        public static string fullName = "div .fullnameInput";

        public static string gender = "div.radio input";

        public static string email = "div .form-group input[type=email]";

        public static string username = "label.usernameLabel + input";

        public static string password = "label.passwordLabel + input";

        public static string city = "label.cityLabel + input";

        public static string state = "label.stateLabel + input";

        public static string zipCode = "label.zipcodeLabel + input";

        public static string contactNo = "label.contactLabel + input";

        public static string introdution = "label.introLabel + textarea";

        public static string hobbies = "label.hobbiesLabel + textarea";

        public static string favFood = "div .checkbox input.foodOption";

        public static string skills = "label.skillLabel + select";

        public static string country = "div .form-group.col-lg-6.no-extra-padding:nth-child(2) label + select";


     public static string fav = "div.form-group div.checkbox label input.favOption";

        /* public static string favB = "div .form-group label .itemA";

         public static string favC = "div .form-group label .itemA";

         public static string favD = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "div .form-group label .itemA";

         public static string favE = "";

         public static string favE = "";*/

        public static string submitBtn = "button.submitButton";

        public static string resetBtn = "button.btn-info";


    }
}
