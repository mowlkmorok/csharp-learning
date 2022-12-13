using System;
using System.Globalization;

namespace Tagged01.Entities
{
    class UsedProd : Product
    {

        public UsedProd(){}

        public UsedProd(string Name, double Price, DateTime manufactureDate)
            : base(Name, Price)
        {
            ManufactureDate = manufactureDate;
        }

        public DateTime ManufactureDate { get; set; }


        public override string priceTag()
        {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }

        
    }
    
}