using Core.Doman;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
  public  interface IUserServises
    {
        public Task<User> Create(User user);
        public Task<int> Update(User user);
        public Task<int> Delete(int id);
        public Task<User> GetById(int id);
        public Task<List<User>> GetAll();
    }
}
