using System;

namespace UserRegistrationSolution
{
    internal class Program
    {
        string firstName = "Sourav";
        string lastName = "Kumar";
        string email = "Souravkumar@giet.edu.in";
        static void Main(string[] args)
        {
            Program p = new Program();

            //WithLambdaExpression
            UserRegistrationWithLambdaExpression userRegistrationWithLambdaExpression = new UserRegistrationWithLambdaExpression();
            if (userRegistrationWithLambdaExpression.RegexCheck(p.firstName, p.lastName, p.email))
                Console.WriteLine("Match found for the first name, last name and email.");
            else
                Console.WriteLine("Match not found for the first name, last name and email.");
            Console.WriteLine();

            //WithoutLambdaExpression
            UserRegistrationWithoutLambdaExpression userRegistrationWithoutLambdaExpression = new UserRegistrationWithoutLambdaExpression();
            if (userRegistrationWithoutLambdaExpression.RegexCheck(p.firstName, p.lastName, p.email))
                Console.WriteLine("Match found for the first name, last name and email.");
            else
                Console.WriteLine("Match not found for the first name, last name and email.");
        }
    }
}
