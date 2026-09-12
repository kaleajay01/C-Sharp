using SPWebAPI.Entities;

namespace SPWebAPI.Repository.IRepositoryn;

public interface IRepository
{
    public List<User> GetAllUsers();
    public User GetUserById(int id);
    public bool AddUser(User user);
    public bool RemoveUser(int id);
    public bool UpdateUser(int id , User user);
}