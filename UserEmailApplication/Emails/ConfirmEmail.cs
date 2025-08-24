namespace UserEmailApplication.Emails;

public class ConfirmEmail : IEmail
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public Dictionary<string, object> Parameters()
    {
        return new Dictionary<string, object>()
        {
            { "Name", Name },
            { "Email", Email }
        };
    }
}