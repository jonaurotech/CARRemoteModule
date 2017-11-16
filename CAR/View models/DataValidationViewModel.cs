using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CAR.View_models
{
    class DataValidationViewModel : ViewModelBase
    {
        private double doubleValue;
        private string stringValue;
        private decimal decimalValue;
        private DateTime dateTimeValue;
        [Range(-100d, 100d)]
        public double DoubleValue
        {
            get { return doubleValue; }
            set
            {
                doubleValue = value;
                this.OnPropertyChanged("DoubleValue");
            }
        }
        [Range(typeof(decimal), "-100", "100")]
        public decimal DecimalValue
        {
            get { return decimalValue; }
            set
            {
                decimalValue = value;
                this.OnPropertyChanged("DecimalValue");
            }
        }
        [Range(typeof(DateTime), "01.01.1900", "01.01.2099")]
        public DateTime DateTimeValue
        {
            get { return dateTimeValue; }
            set
            {
                dateTimeValue = value;
                this.OnPropertyChanged("DateTimeValue");
            }
        }
        [StringLength(6)]
        [Required()]
        public string StringValue
        {
            get { return stringValue; }
            set
            {
                if(value.Length > 7)
                {
                    throw new ValidationException(String.Format("Barcode entered is greater than {0}.", value.Length));
                }
                stringValue = value;
                this.OnPropertyChanged("StringValue");
            }
        }
    }
}
