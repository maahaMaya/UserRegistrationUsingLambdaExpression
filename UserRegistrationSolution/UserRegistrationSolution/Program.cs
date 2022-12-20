using System;

namespace UserRegistrationSolution
{
    internal class Program
    {
        string firstName = "Sourav";
        string lastName = "Kumar";
        string email = "Souravkumar@giet.edu.in";
        string phoneNumber = "91 1234567890";
  
        static void Main(string[] args)
        {
            Program p = new Program();

            //WithLambdaExpression
            UserRegistrationWithLambdaExpression userRegistrationWithLambdaExpression = new UserRegistrationWithLambdaExpression();
            if (userRegistrationWithLambdaExpression.RegexCheck(p.firstName, p.lastName, p.email, p.phoneNumber))
                Console.WriteLine("Match found for the first name, last name, email and phoneNumber.");
            else
                Console.WriteLine("Match not found for the first name, last name, email and phoneNumber.");
            Console.WriteLine();

            //WithoutLambdaExpression
            UserRegistrationWithoutLambdaExpression userRegistrationWithoutLambdaExpression = new UserRegistrationWithoutLambdaExpression();
            if (userRegistrationWithoutLambdaExpression.RegexCheck(p.firstName, p.lastName, p.email, p.phoneNumber))
                Console.WriteLine("Match found for the first name, last name, email and phoneNumber.");
            else
                Console.WriteLine("Match not found for the first name, last name, email and phoneNumber.");
        }
    }
}
