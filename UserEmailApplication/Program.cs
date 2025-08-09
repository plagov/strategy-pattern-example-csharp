using UserEmailApplication.Emails;

namespace UserEmailApplication;

public static class Program
{
    public static void Main(string[] args)
    {
        var emailStrategies = new List<IEmailStrategy>
        {
            new ConfirmEmail(),
            new ForgotPasswordEmail(),
            new WelcomeEmail()
        };

        var emailBuilder = new EmailBuilder(emailStrategies);

        var userService = new UserService(emailBuilder);

        Console.WriteLine("Will print the confirm email now");
        userService.PrintConfirmEmail();

        Console.WriteLine("Will print the forgot password email now");
        userService.PrintForgotPasswordEmail();
        
        Console.WriteLine("Will print the welcome email now");
        userService.PrintWelcomeEmail();
    }
}