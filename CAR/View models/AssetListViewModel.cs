using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAR.Model;

namespace CAR.View_models
{
    public class AssetListViewModel
    {
        private CarContext _context;

        public AssetListViewModel()
        {
            _context = new CarContext();
            AssetList = _context.Assets.ToList();
        }

        public IList<ASSET> AssetList { get; private set; }
    }
}
