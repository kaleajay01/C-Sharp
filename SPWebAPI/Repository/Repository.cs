using System.Security.Cryptography;
using Dapper;
using MySqlConnector;

using SPWebAPI.Entities;
using SPWebAPI.Repository.IRepositoryn;

namespace SPWebAPI.Repository;

public class Repository : IRepository
{
    private readonly string _connectionString;

    public Repository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public List<User> GetAllUsers()
    {
        using (var connection = new MySqlConnection(_connectionString))
        {

            string sql = """SELECT * from users""";
            var users = connection.Query<User>(sql);

            return users.ToList();
        }
    }

    public User GetUserById(int id)
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            string sql = """select * from users where id = @id""";
            var user = connection.QuerySingle<User>(sql, new { id = id });

            return (User)user;
        }
    }

    public bool AddUser(User user)
    {
        bool status = false;
        using (var connection = new MySqlConnection(_connectionString))
        {
            string sql = """INSERT INTO users (username, password, email, address) values (@username, @password, @email, @address)""";
            connection.Execute(sql, new { username = user.username, password = user.password, email = user.email, address = user.address });
            status = true;

        }
        return status;
    }

    public bool RemoveUser(int id)
    {
        bool status = false;
        using (var connection = new MySqlConnection(_connectionString))
        {
            string sql = """DELETE FROM users WHERE id=@id""";
            connection.Execute(sql, new { id = id });
            status = true;
        }
        return status;
    }

    public bool UpdateUser(int id, User user)
    {
        bool status = false;
        using (var connection = new MySqlConnection(_connectionString))
        {
            string sql = """Update users set username = @username, password = @password, email = @email, address = @address WHERE id = @id""";
            connection.Execute(sql, new { id = id, username = user.username, password = user.password, email = user.email, address = user.address });
            status = true;
        }
        return status;
    }


}
