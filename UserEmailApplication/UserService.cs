using UserEmailApplication.Emails;

namespace UserEmailApplication;

public class UserService(EmailBuilder emailBuilder)
{
    public void PrintConfirmEmail()
    {
        var emailMessage = emailBuilder.Build(EmailType.ConfirmEmail);
        Console.WriteLine($"Subject: {emailMessage.Subject}");
        Console.WriteLine($"Body: {emailMessage.Body}");
    }

    public void PrintForgotPasswordEmail()
    {
        var emailMessage = emailBuilder.Build(EmailType.ForgotPasswordEmail);
        Console.WriteLine($"Subject: {emailMessage.Subject}");
        Console.WriteLine($"Body: {emailMessage.Body}");
    }

    public void PrintWelcomeEmail()
    {
        var emailMessage = emailBuilder.Build(EmailType.WelcomeEmail);
        Console.WriteLine($"Subject: {emailMessage.Subject}");
        Console.WriteLine($"Body: {emailMessage.Body}");
    }
}