namespace UserEmailApplication.Emails;

public class ForgotPasswordEmail : IEmailStrategy
{
    public EmailType EmailType => EmailType.ForgotPasswordEmail;
    
    public EmailMessage GetMessage()
    {
        return new EmailMessage()
        {
            Subject = "Reset Password",
            Body = "This is the email to reset your password."
        };
    }
}