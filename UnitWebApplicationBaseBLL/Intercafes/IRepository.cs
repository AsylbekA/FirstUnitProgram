using System.Collections.Generic;
using UnitWebApplicationBLL.Models;

namespace UnitWebApplicationBLL.Intercafes
{
    public interface IRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Create(User user);
    }
}
