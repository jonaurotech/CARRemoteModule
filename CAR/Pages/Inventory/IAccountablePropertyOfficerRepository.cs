using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace CAR.Inventory
{
    public interface IAccountablePropertyOfficerRepository
    {
        void Add(AccountablePropertyOfficer a);
        void Edit(AccountablePropertyOfficer a);
        void Remove(string APO_PCO_PIV_BADGE_NUM);
        IEnumerable GetAccountablePropertyOfficers(); AccountablePropertyOfficer FindByAPO_PCO_PIV_BADGE_NUM(string APO_PCO_PIV_BADGE_NUM);
    }
}
