// -----------------------------------------------------------------------------------------------
//  UserData.cs by Thomas Thorin, Copyright (C) 2022.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace TDDFirst
{
    using System.Text.RegularExpressions;

    public class UserData
    {
        public bool IsPasswordOK(string password)
        {
            //if (password == null || password.Length <= 6 || password.Length > 25) return false;

            //bool lower = false;
            //bool upper = false;
            //bool special = false;
            //for (int i = 0; i < password.Length; i++)
            //{
            //    if (char.IsLower(password[i])) lower = true;
            //    else if (char.IsUpper(password[i])) upper = true;
            //    else if ("!.:$%&()=/".Contains(password[i])) special = true;
            //}

            //return lower && upper && special;
            Regex rx = new Regex(@"^(?=.*?[!.:$%&()=/])(?=.*?[a-zåäö])(?=.*?[A-ZÅÄÖ])(?=\S+$).{7,25}$");
            return password != null && rx.IsMatch(password.Trim());
        }

        public bool IsEmailOk(string email)
        {
            var rx = new Regex(@"^(?=[a-zåäö.@_-]{6,60}$)(?=^[a-zåäö._-]{1,50}@)([a-zåäö]([a-zåäö0-9-_]+)?(\.[a-zåäö]([a-zåäö0-9-_]+)?)?)@[a-zåäö]([a-zåäö0-9_-]+)?\.[a-zåäö]{2,}$");
            return email != null && rx.IsMatch(email.Trim());
        }

        public bool IsPhoneOk(string phone)
        {
            Regex rx = new Regex(@"^\+[0-9]+?$");
            return phone != null && rx.IsMatch(phone.Trim());
        }
    }
}
