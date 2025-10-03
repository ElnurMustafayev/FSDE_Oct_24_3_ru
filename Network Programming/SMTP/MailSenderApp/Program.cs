using System.Net;
using System.Net.Mail;

var client = new SmtpClient(Environment.GetEnvironmentVariable("SMTP_SERVER_DOMAINNAME")!, 2525)
{
    Credentials = new NetworkCredential(
        userName: Environment.GetEnvironmentVariable("SMTP_USERNAME")!,
        password: Environment.GetEnvironmentVariable("SMTP_PASSWORD")!),
    EnableSsl = true
};

string mailMessageHtmlBody = await File.ReadAllTextAsync("kindly_ask_professor.html");

mailMessageHtmlBody = mailMessageHtmlBody
    .Replace("{{professor_name}}", "Elnur")
    .Replace("{{student_name}}", "Bob");

var mailMessage = new MailMessage(
    from: "bob@mycompany.com",
    to: "elnur.mustafayeev@gmail.com"
)
{
    Subject = "New student",
    Body = mailMessageHtmlBody,
    IsBodyHtml = true,
};

client.Send(mailMessage);
System.Console.WriteLine("Mail sent");