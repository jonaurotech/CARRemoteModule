using System.Collections;

namespace CAR.Inventory
{
    public interface ICenterRepository
    {
        void Add(Center c);
        void Edit(Center c);
        void Remove(string center);
        IEnumerable GetCenters(); Center FindByCenter(string center);
    }
}
