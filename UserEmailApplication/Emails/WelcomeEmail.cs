namespace UserEmailApplication.Emails;

public class WelcomeEmail : IEmail
{
    public string Name {get; set;}
    
    public Dictionary<string, object> Parameters()
    {
        return new Dictionary<string, object>()
        {
            { "Name", Name },
        };
    }
}