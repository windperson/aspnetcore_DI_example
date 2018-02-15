using System.Threading.Tasks;

namespace DependencyInjectionExample.Interfaces
{
    public interface IEmailSender
    {
         Task SendEmailAsync(string email,string subject,string message);
    }
}