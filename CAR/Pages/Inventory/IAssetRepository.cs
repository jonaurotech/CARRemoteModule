using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace CAR.Inventory
{
   public interface IAssetRepository
    {
        void Add(Asset a);
        void Edit(Asset a);
        void Remove(int Barcode);
        IEnumerable GetAssets(); Asset FindByBarcode(int Barcode);
    }
}

