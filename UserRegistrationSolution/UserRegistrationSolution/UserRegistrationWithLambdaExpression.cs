using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationSolution
{
    internal class UserRegistrationWithLambdaExpression
    {
        const string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        const string LAST_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL_PATTERN = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        const string PHONE_PATTERN = "^[0-9]{2}[ ]{1}[0-9]{10}";
        public bool RegexCheck(string firstName, string lastName, string email, string phoneNumber) => (Regex.IsMatch(firstName, FIRST_NAME_PATTERN) && Regex.IsMatch(lastName, LAST_NAME_PATTERN)  && Regex.IsMatch(email, EMAIL_PATTERN) && Regex.IsMatch(phoneNumber, PHONE_PATTERN)) ? true : false;
    }
}
