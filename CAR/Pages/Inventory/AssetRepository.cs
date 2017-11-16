using System.Collections.Generic;
using System.Linq;
using CAR.Inventory;
using System.Data.Entity;
using System.Collections;
using CAR;


namespace CAR.Inventory
{
    class AssetRepository : IAssetRepository
    {

        AssetContext context = new AssetContext();
        public void Add(Asset a)
        {
            context.Assets.Add(a);
            context.SaveChanges();
        }

        public void Edit(Asset a)
        {
            context.Entry(a).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public Asset FindByBarcode(int Barcode)
        {
            var result = (from r in context.Assets
            where r.barcode == Barcode
            select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetAssets()
        {
            return context.Assets;
        }
        public void Remove(int Barcode)
        {
            var da = context.Assets.Find(Barcode);
            Asset a = (Asset)da;
            context.Assets.Remove(a);
            context.SaveChanges(); }
    }
}
