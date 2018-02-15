using System.Threading.Tasks;

namespace DependencyInjectionExample.Interfaces
{
    public interface ISmsSender
    {
         Task SendSmsAsync(string number, string message);
    }
}