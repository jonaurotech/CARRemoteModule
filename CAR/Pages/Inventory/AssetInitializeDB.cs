using System.Data.Entity;
using CAR;
using CAR.Inventory;

namespace CAR.Inventory
{
   

    class AssetInitializeDB : DropCreateDatabaseIfModelChanges<AssetContext>
    {
        AssetContext context = new AssetContext();

        
    }
}
