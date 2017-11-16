using System.Collections;


namespace CAR.Inventory
{
    public interface IUserRepository
    {
        void Add(Users u);
        void Edit(Users u);
        void Remove(string USER_PIV_BADGE_NUM);
        IEnumerable GetUser(); Users FindByUser(string USER_PIV_BADGE_NUM);
    }
}
