namespace UserEmailApplication;

public class EmailService
{
    public void SendEmail(string body)
    {
        Console.WriteLine($"Send email with body: {body}");
    }
}