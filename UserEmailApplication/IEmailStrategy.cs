using UserEmailApplication.Emails;

namespace UserEmailApplication;

public interface IEmailStrategy
{
    EmailType EmailType { get; }
    EmailMessage GetMessage();
}