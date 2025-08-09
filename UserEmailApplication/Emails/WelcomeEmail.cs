namespace UserEmailApplication.Emails;

public class WelcomeEmail : IEmailStrategy
{
    public EmailType EmailType => EmailType.WelcomeEmail;

    public EmailMessage GetMessage()
    {
        return new EmailMessage
        {
            Subject = "Welcome",
            Body = "Welcome to our service."
        };
    }
}