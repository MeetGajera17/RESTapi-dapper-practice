using Dapper;
using DapperDemoApi.Services;
using DapperDemoData.Models;
using System.Data;

namespace DapperDemoApi.Services
{
    public class UserService : IUserService
    {
        private readonly IDbConnection _dbConnection;

        public UserService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Person GetUserByUsername(string name)
        {
            var user = _dbConnection.QuerySingleOrDefault<Person>("SELECT * FROM Person WHERE Name = @Name", new { Name = name });
            return user;
        }

        public Person ValidateUser(string username, string email)
        {
            var person = GetUserByUsername(username);
            if (person == null || person.Email != email) // Use hashed password comparison in real application
            {
                return null;
            }
            return person;
        }

        public Person GetUserById(int id)
        {
            return _dbConnection.QuerySingleOrDefault<Person>("SELECT * FROM Person WHERE Id = @Id", new { Id = id });
        }


    }
}

