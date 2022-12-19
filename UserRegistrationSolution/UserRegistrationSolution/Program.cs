using System;

namespace UserRegistrationSolution
{
    internal class Program
    {
        string firstName = "Sourav";
        string lastName = "Kumar";
        static void Main(string[] args)
        {
            Program p = new Program();

            //WithLambdaExpression
            UserRegistrationWithLambdaExpression userRegistrationWithLambdaExpression = new UserRegistrationWithLambdaExpression();
            if (userRegistrationWithLambdaExpression.RegexCheck(p.firstName, p.lastName))
                Console.WriteLine("Match found for the first name and last name.");
            else
                Console.WriteLine("Match not found for the first name and last name.");

            //WithoutLambdaExpression
            UserRegistrationWithoutLambdaExpression userRegistrationWithoutLambdaExpression = new UserRegistrationWithoutLambdaExpression();
            if (userRegistrationWithoutLambdaExpression.RegexCheck(p.firstName, p.lastName))
                Console.WriteLine("Match found for the first name and last name.");
            else
                Console.WriteLine("Match not found for the first name and last name.");
        }
    }
}
