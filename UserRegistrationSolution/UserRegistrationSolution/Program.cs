using System;

namespace UserRegistrationSolution
{
    internal class Program
    {
        string firstName = "Sourav";
        static void Main(string[] args)
        {
            Program p = new Program();

            //WithLambdaExpression
            UserRegistrationWithLambdaExpression userRegistrationWithLambdaExpression = new UserRegistrationWithLambdaExpression();
            if (userRegistrationWithLambdaExpression.RegexCheck(p.firstName))
                Console.WriteLine("Match found for the first name.");
            else
                Console.WriteLine("Match not found for the first name.");

            //WithoutLambdaExpression
            UserRegistrationWithoutLambdaExpression userRegistrationWithoutLambdaExpression = new UserRegistrationWithoutLambdaExpression();
            if (userRegistrationWithoutLambdaExpression.RegexCheck(p.firstName))
                Console.WriteLine("Match found for the first name.");
            else
                Console.WriteLine("Match not found for the first name.");
        }
    }
}
