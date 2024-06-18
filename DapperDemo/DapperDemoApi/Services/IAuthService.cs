using DapperDemoData.Models;

namespace DapperDemoApi.Services
{
    public interface IAuthService
    {
        string GenerateToken(Person user);
    }
}