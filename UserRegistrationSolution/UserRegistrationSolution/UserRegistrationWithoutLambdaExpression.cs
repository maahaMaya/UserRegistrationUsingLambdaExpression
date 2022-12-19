﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationSolution
{
    internal class UserRegistrationWithoutLambdaExpression
    {
        const string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public bool RegexCheck(string firstName)
        {
            return (Regex.IsMatch(firstName, FIRST_NAME_PATTERN)) ? true : false;
        }
    }
}