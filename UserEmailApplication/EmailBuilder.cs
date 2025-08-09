using UserEmailApplication.Emails;

namespace UserEmailApplication;

public class EmailBuilder
{
    private readonly Dictionary<EmailType, IEmailStrategy> _strategies;

    public EmailBuilder(IEnumerable<IEmailStrategy> strategies)
    {
        _strategies = strategies.ToDictionary(s => s.EmailType);
    }

    public EmailMessage Build(EmailType emailType)
    {
        if (_strategies.TryGetValue(emailType, out var strategy))
        {
            return strategy.GetMessage();
        }

        throw new ArgumentException($"No email strategy found for {emailType}");
    }
}