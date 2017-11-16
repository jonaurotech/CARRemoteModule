using CAR.Model;
using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CAR.View_models
{
    public class CreateAssetViewModel
    {
        private readonly CarContext _context;

        public ICommand NewAssetCommand { get; private set; }
        public ICommand ExistingAssetCommand { get; private set; }
        public ICommand OffsiteAssetCommand { get; private set; }
        public ICommand SubmitCommand { get; private set; }

        public bool NewAsset { get; set; }
        public bool OffsiteAsset { get; set; }
        public bool ExistingAsset { get; set; }
        public int AssetType { get; set; }
        public int Barcode { get; set; }

        public CreateAssetViewModel()
        {
            _context = new CarContext();
            NewAssetCommand = new DelegateCommand(() => {
                                                            NewAsset = true;
                                                            ExistingAsset = false;
                                                            OffsiteAsset = false;
                                                        });
            ExistingAssetCommand = new DelegateCommand(() =>
            {
                NewAsset = false;
                ExistingAsset = true;
                OffsiteAsset = false;
            });
            OffsiteAssetCommand = new DelegateCommand(() =>
            {
                NewAsset = false;
                ExistingAsset = false;
                OffsiteAsset = true;
            });

            SubmitCommand = new DelegateCommand(ExecuteSubmit);
        }

        private void ExecuteSubmit()
        {
            var asset = new ASSET();
            asset.BARCODE = Barcode;

            if (AssetType == 0)
            {
                _context.Assets.Add(asset);
                _context.SaveChanges();
            }
        }
    }
}
