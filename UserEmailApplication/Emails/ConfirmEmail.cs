namespace UserEmailApplication.Emails;

public class ConfirmEmail : IEmailStrategy
{
    public EmailType EmailType => EmailType.ConfirmEmail;
    
    public EmailMessage GetMessage()
    {
        return new EmailMessage
        {
            Subject = "Confirm your email",
            Body = "Your account has been confirmed."
        };
    }
}