using UserEmailApplication.Emails;

namespace UserEmailApplication;

public static class Program
{
    public static void Main(string[] args)
    {
        var repository = new TemplateRepository();
        var emailService = new EmailService();

        var welcomeEmail = new WelcomeEmail { Name = "John Doe" };
        var forgotPasswordEmail = new ForgotPasswordEmail { RecoverPasswordUrl = "https://example.com/recover_email" };
        var confirmEmail = new ConfirmEmail() { Email = "dev@null.io", Name = "Adam Smith" };

        Console.WriteLine("Send welcome email");
        emailService.SendEmail(repository.GetBody(welcomeEmail));

        Console.WriteLine("Send forgot password email");
        emailService.SendEmail(repository.GetBody(forgotPasswordEmail));

        Console.WriteLine("Send confirmation email");
        emailService.SendEmail(repository.GetBody(confirmEmail));
    }
}