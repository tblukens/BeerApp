using System.Collections.Generic;
using System.Threading.Tasks;
using BeerApp.API.Models;

namespace BeerApp.API.Data
{
    public interface IBeerRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}