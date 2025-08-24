using System.Text;
using UserEmailApplication.Emails;

namespace UserEmailApplication;

public class TemplateRepository
{
    private static readonly Dictionary<string, object> BodyTemplates = new()
    {
        { "WelcomeEmail", "Welcome to our service, {Name}" },
        { "ConfirmEmail", "Confirm your email address {Name}: {Email}" },
        { "ForgotPasswordEmail", "Use the following URL to recover your password: {RecoverPasswordUrl}" }
    };

    public string GetBody(IEmail email)
    {
        var emailName = email.GetType().Name;

        if (BodyTemplates.TryGetValue(emailName, out var body))
        {
            return FormatTemplate(body, email);
        }
        
        throw new InvalidDataException($"No template found in database for email: {emailName}");
    }

    // todo better to move this method out of the repository
    private static string FormatTemplate(object template, IEmail email)
    {
        var stringValue = template.ToString();
        if (string.IsNullOrEmpty(stringValue))
        {
            return string.Empty;
        }

        var builder = new StringBuilder(stringValue);
        foreach (var pair in email.Parameters())
        {
            builder.Replace($"{{{pair.Key}}}", pair.Value.ToString());
        }
        
        return builder.ToString();
    }
}