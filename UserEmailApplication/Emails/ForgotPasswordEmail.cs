namespace UserEmailApplication.Emails;

public class ForgotPasswordEmail : IEmail
{
    public string RecoverPasswordUrl { get; set; }

    public Dictionary<string, object> Parameters()
    {
        return new Dictionary<string, object>()
        {
            { "RecoverPasswordUrl", RecoverPasswordUrl }
        };
    }
}