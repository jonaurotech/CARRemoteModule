using System.Collections.Generic;
using System.Linq;
using CAR.Inventory;
using System.Data.Entity;
using System.Collections;
using CAR;

namespace CAR.Inventory
{
    class UserRepository
    {
       UsersContext context = new UsersContext();
        public void Add(Users u)
        {
            context.Users.Add(u);
            context.SaveChanges();
        }

        public void Edit(Users u)
        {
            context.Entry(u).State = System.Data.Entity.EntityState.Modified;
        }

        public Users FindByUSER_PIV_BADGE_NUM(string USER_PIV_BADGE_NUM)
        {
            var result = (from r in context.Users
                          where r.USER_PIV_BADGE_NUM == USER_PIV_BADGE_NUM
                          select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetUsers()
        {
            return context.Users;
        }
        public void Remove(string USER_PIV_BADGE_NUM)
        {
            var da = context.Users.Find(USER_PIV_BADGE_NUM);
           Users u = (Users)da;
            context.Users.Remove(u);
            context.SaveChanges();
        }

    }
}
