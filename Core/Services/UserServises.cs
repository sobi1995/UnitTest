using Core.Context;
using Core.Doman;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserServises : IUserServises
    {
        private readonly ApplicationContext _context;
        public UserServises(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<User> Create(User user)
        {
            _context.Add(user);
            _context.Entry(user).State = EntityState.Added;
            await  _context.SaveChangesAsync();
            return user;
        }

        public async  Task<int> Delete(int  id)
        {
            var user = await _context.User.FindAsync(id);
            _context.Entry(user).State = EntityState.Deleted;
            return await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.User.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> Update(User user)
        {
            var _user = await _context.User.FindAsync(user.Id);
            _user.Age = user.Age;
            _user.FullName = user.FullName;
            _user.PhoneNumber = user.PhoneNumber;
           
            _context.Entry(user).State = EntityState.Unchanged;

            return await _context.SaveChangesAsync();
        }
    }
}
