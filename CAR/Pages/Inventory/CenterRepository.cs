using System.Collections.Generic;
using System.Linq;
using CAR.Inventory;
using System.Data.Entity;
using System.Collections;
using CAR;

namespace CAR.Inventory
{
    class CenterRepository
    {
        CenterContext context = new CenterContext();
        public void Add(Center c)
        {
            context.Centers.Add(c);
            context.SaveChanges();
        }

        public void Edit(Center c)
        {
            context.Entry(c).State = System.Data.Entity.EntityState.Modified;
        }

        public Center FindBycenter(string center)
        {
            var result = (from r in context.Centers
                          where r.center == center
                          select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetCenters()
        {
            return context.Centers;
        }
        public void Remove(string center)
        {
            var da = context.Centers.Find(center);
            Center c = (Center)da;
            context.Centers.Remove(c);
            context.SaveChanges();
        }
    }
}
