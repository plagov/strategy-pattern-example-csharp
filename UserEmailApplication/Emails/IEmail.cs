namespace UserEmailApplication.Emails;

public interface IEmail
{
    public Dictionary<string, object> Parameters();
}