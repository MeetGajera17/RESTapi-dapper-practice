using DapperDemoData.Models;

namespace DapperDemoApi.Services
{
    public interface IUserService
    {
        Person GetUserByUsername(string username);
        Person ValidateUser(string username, string password);
        Person GetUserById(int id);
    }
}

