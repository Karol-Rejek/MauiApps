using System;
using System.Collections.Generic;
using System.Text;

namespace SocialAppSimulator.src.Models
{

    public enum UserType
    {
        Regular,
        Admin
    }

    public struct PersonalData
    {
        public string name;
        public string surname;
        public int age;
    }

    public struct Data
    {
        public string name;
        public string email;
        public string password;
    }

    public class User
    {
        //----------Variables_&_Properties----------
        string IdHex;

        UserType userType;
        Data userData;

        //----------Constructors----------
        public User(UserType userType, Data userData)
        {
            IdHex = GenerateUserID(userType, userData.name);
            this.userType = userType;
            this.userData = userData;
        }

        //----------Metods----------
        private string GenerateUserID(UserType userType, string name)
        {
            //Impementation that generate user id in hex format

            return string.Empty;
        }

    }
}
