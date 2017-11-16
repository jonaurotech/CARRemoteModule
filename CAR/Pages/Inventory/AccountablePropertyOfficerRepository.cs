using System.Collections.Generic;
using System.Linq;
using CAR.Inventory;
using System.Data.Entity;
using System.Collections;
using CAR;

namespace CAR.Inventory
{
    class AccountablePropertyOfficerRepository
    {
        AccountablePropertyOfficerContext context = new AccountablePropertyOfficerContext();
        public void Add(AccountablePropertyOfficer a)
        {
            context.AccountablePropertyOfficers.Add(a);
            context.SaveChanges();
        }

        public void Edit(AccountablePropertyOfficer a)
        {
            context.Entry(a).State = System.Data.Entity.EntityState.Modified;
        }

        public AccountablePropertyOfficer FindByAPO_PCO_PIV_BADGE_NUM(string APO_PCO_PIV_BADGE_NUM)
        {
            var result = (from r in context.AccountablePropertyOfficers
                          where r.APO_PCO_PIV_BADGE_NUM == APO_PCO_PIV_BADGE_NUM
                          select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetAccountablePropertyOfficers()
        {
            return context.AccountablePropertyOfficers;
        }
        public void Remove(string APO_PCO_PIV_BADGE_NUM)
        {
            var da = context.AccountablePropertyOfficers.Find(APO_PCO_PIV_BADGE_NUM);
            AccountablePropertyOfficer a = (AccountablePropertyOfficer)da;
            context.AccountablePropertyOfficers.Remove(a);
            context.SaveChanges();
        }
    }
}
